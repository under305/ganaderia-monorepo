using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Solucion_Ganaderia
{
    public partial class MainView : UserControl
    {
        public class MenuOptionEventArgs : EventArgs
        {
            public string Key { get; }
            public string Text { get; }

            public MenuOptionEventArgs(string key, string text)
            {
                Key = key;
                Text = text;
            }
        }

        public event EventHandler<MenuOptionEventArgs> MenuOptionActivated;
        public event EventHandler CloseRequested;

        private static readonly Color LightCardBg = Color.FromArgb(237, 234, 221);
        private static readonly Color LightPageBg = Color.FromArgb(244, 242, 233);
        private static readonly Color LightBorder = Color.FromArgb(46, 50, 38);
        private static readonly Color LightTextPrimary = Color.FromArgb(35, 38, 29);
        private static readonly Color LightTextSecondary = Color.FromArgb(51, 54, 44);
        private static readonly Color LightTextMuted = Color.FromArgb(110, 122, 98);

        private static readonly Color DarkCardBg = Color.FromArgb(30, 36, 30);
        private static readonly Color DarkPageBg = Color.FromArgb(18, 22, 18);
        private static readonly Color DarkBorder = Color.FromArgb(90, 100, 80);
        private static readonly Color DarkTextPrimary = Color.FromArgb(228, 230, 218);
        private static readonly Color DarkTextSecondary = Color.FromArgb(200, 204, 190);
        private static readonly Color DarkTextMuted = Color.FromArgb(140, 155, 128);

        private static readonly Color SelectedBg = Color.FromArgb(58, 94, 58);
        private static readonly Color HoverBg = Color.FromArgb(210, 214, 190);
        private static readonly Color ExitText = Color.FromArgb(163, 58, 46);

        // Tamaño de diseño de referencia (coincide con MainView.Size en el Designer):
        // la escala en vivo se calcula comparando el tamaño real contra este valor.
        private const int BaseWidth = 1560;
        private const int BaseHeight = 900;
        private const float MinScale = 0.55f;
        private const float MaxScale = 2.2f;

        private List<(Label Label, string Key)> _menuItems;
        private readonly Dictionary<Control, Rectangle> _baseBounds = new Dictionary<Control, Rectangle>();
        private readonly Dictionary<Control, float> _baseFontSizes = new Dictionary<Control, float>();
        private Label _selectedLabel;
        private bool _darkMode;
        private float _currentScale;

        public MainView()
        {
            InitializeComponent();
            BuildMenuMap();
            WireMenuEvents();
            SelectItem(lblItem1, activate: false);
            lblClock.Text = DateTime.Now.ToString("H:mm:ss");

            CaptureScalableBaseline();
            Resize += (s, e) => ApplyScale();
            ApplyScale();
        }

        private void CaptureScalableBaseline()
        {
            foreach (var c in new Control[] { lblRanchoTitle, lblLoteActivo, lblClock, lblOperador, lblMenuBarTitle, btnModo, lblFooterHints, lblCursor })
            {
                _baseBounds[c] = c.Bounds;
                _baseFontSizes[c] = c.Font.Size;
            }

            foreach (var (label, _) in _menuItems)
            {
                _baseBounds[label] = label.Bounds;
                _baseFontSizes[label] = label.Font.Size;
            }

            foreach (var c in new Control[] { pnlHeader, pnlMenuBar, pnlFooter, pnlMenuLeft })
            {
                _baseBounds[c] = c.Bounds;
            }
        }

        private bool _isScaling;

        private void ApplyScale()
        {
            if (Width <= 0 || Height <= 0 || _isScaling)
            {
                return;
            }

            float scale = Math.Min(Width / (float)BaseWidth, Height / (float)BaseHeight);
            scale = Math.Max(MinScale, Math.Min(MaxScale, scale));
            if (Math.Abs(scale - _currentScale) < 0.01f)
            {
                return;
            }
            _currentScale = scale;

            _isScaling = true;
            try
            {
                ApplyScaleCore();
            }
            finally
            {
                _isScaling = false;
            }
        }

        private void ApplyScaleCore()
        {
            pnlHeader.Height = ScaledValue(_baseBounds[pnlHeader].Height);
            pnlMenuBar.Height = ScaledValue(_baseBounds[pnlMenuBar].Height);
            pnlFooter.Height = ScaledValue(_baseBounds[pnlFooter].Height);
            pnlMenuLeft.Width = ScaledValue(_baseBounds[pnlMenuLeft].Width);

            RescaleControl(lblRanchoTitle, resize: false);
            RescaleControl(lblLoteActivo, resize: false);
            RescaleControl(lblMenuBarTitle, resize: false);
            RescaleControl(lblClock, resize: true);
            RescaleControl(lblOperador, resize: true);
            RescaleControl(btnModo, resize: true);
            RescaleControl(lblCursor, resize: true);
            RescaleFont(lblFooterHints);

            foreach (var (label, _) in _menuItems)
            {
                RescaleControl(label, resize: true);
            }
        }

        private int ScaledValue(int baseValue) => (int)Math.Round(baseValue * _currentScale);

        private void RescaleControl(Control c, bool resize)
        {
            var b = _baseBounds[c];
            var location = new Point(ScaledValue(b.X), ScaledValue(b.Y));
            c.Location = location;
            if (resize)
            {
                c.Size = new Size(ScaledValue(b.Width), ScaledValue(b.Height));
            }
            RescaleFont(c);
        }

        private void RescaleFont(Control c)
        {
            float newSize = Math.Max(6f, _baseFontSizes[c] * _currentScale);
            c.Font = new Font(c.Font.FontFamily, newSize, c.Font.Style);
        }

        private void BuildMenuMap()
        {
            _menuItems = new List<(Label, string)>
            {
                (lblItem1, "1"), (lblItem2, "2"), (lblItem3, "3"), (lblItem4, "4"), (lblItem5, "5"),
                (lblItem6, "6"), (lblItem7, "7"), (lblItem8, "8"), (lblItem9, "9"),
                (lblItemA, "A"), (lblItemB, "B"), (lblItemC, "C"), (lblItemD, "D"), (lblItemE, "E"),
                (lblItemF, "F"), (lblItemG, "G"), (lblItemH, "H"), (lblItemI, "I"), (lblItemJ, "J"),
            };
        }

        private void WireMenuEvents()
        {
            foreach (var (label, key) in _menuItems)
            {
                label.Click += (s, e) => SelectItem(label, activate: true);
                label.MouseEnter += (s, e) => ApplyHover(label, true);
                label.MouseLeave += (s, e) => ApplyHover(label, false);
            }
        }

        private void ApplyHover(Label label, bool hovering)
        {
            if (label == _selectedLabel)
            {
                return;
            }
            label.BackColor = hovering ? HoverBg : (_darkMode ? DarkCardBg : LightCardBg);
        }

        private void SelectItem(Label label, bool activate)
        {
            if (_selectedLabel != null)
            {
                _selectedLabel.BackColor = _darkMode ? DarkCardBg : LightCardBg;
                _selectedLabel.ForeColor = _selectedLabel == lblItemJ ? ExitText : (_darkMode ? DarkTextPrimary : LightTextPrimary);
                _selectedLabel.Font = new Font(_selectedLabel.Font, FontStyle.Regular);
            }

            _selectedLabel = label;
            _selectedLabel.BackColor = SelectedBg;
            _selectedLabel.ForeColor = Color.White;
            _selectedLabel.Font = new Font(_selectedLabel.Font, FontStyle.Bold);

            if (activate)
            {
                var key = _menuItems.Find(m => m.Label == label).Key;
                var text = label.Text.Substring(label.Text.IndexOf(' ')).Trim();
                MenuOptionActivated?.Invoke(this, new MenuOptionEventArgs(key, text));

                if (label == lblItemJ)
                {
                    CloseRequested?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void MoveSelection(int direction)
        {
            int index = _menuItems.FindIndex(m => m.Label == _selectedLabel);
            if (index < 0)
            {
                return;
            }
            int next = (index + direction + _menuItems.Count) % _menuItems.Count;
            SelectItem(_menuItems[next].Label, activate: false);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                case Keys.Left:
                    MoveSelection(-1);
                    return true;
                case Keys.Down:
                case Keys.Right:
                    MoveSelection(1);
                    return true;
                case Keys.Enter:
                    SelectItem(_selectedLabel, activate: true);
                    return true;
                case Keys.Escape:
                    CloseRequested?.Invoke(this, EventArgs.Empty);
                    return true;
            }

            if (keyData >= Keys.D1 && keyData <= Keys.D9)
            {
                var digitKey = ((char)('1' + (keyData - Keys.D1))).ToString();
                var match = _menuItems.Find(m => m.Key == digitKey);
                if (match.Label != null)
                {
                    SelectItem(match.Label, activate: true);
                    return true;
                }
            }
            else if (keyData >= Keys.A && keyData <= Keys.J)
            {
                var letterKey = ((char)('A' + (keyData - Keys.A))).ToString();
                var match = _menuItems.Find(m => m.Key == letterKey);
                if (match.Label != null)
                {
                    SelectItem(match.Label, activate: true);
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            _darkMode = !_darkMode;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var cardBg = _darkMode ? DarkCardBg : LightCardBg;
            var pageBg = _darkMode ? DarkPageBg : LightPageBg;
            var border = _darkMode ? DarkBorder : LightBorder;
            var textPrimary = _darkMode ? DarkTextPrimary : LightTextPrimary;
            var textSecondary = _darkMode ? DarkTextSecondary : LightTextSecondary;
            var textMuted = _darkMode ? DarkTextMuted : LightTextMuted;

            BackColor = pageBg;
            pnlConsole.BackColor = cardBg;
            pnlHeader.BackColor = cardBg;
            pnlMenuBar.BackColor = cardBg;
            pnlMenuBody.BackColor = cardBg;
            pnlMenuLeft.BackColor = cardBg;
            pnlMenuRight.BackColor = cardBg;
            pnlFooter.BackColor = cardBg;
            pnlHeaderDivider.BackColor = border;
            pnlFooterDivider.BackColor = border;

            lblRanchoTitle.ForeColor = textPrimary;
            lblClock.ForeColor = textPrimary;
            lblCursor.ForeColor = textPrimary;
            lblLoteActivo.ForeColor = textMuted;
            lblOperador.ForeColor = textSecondary;
            lblMenuBarTitle.ForeColor = textPrimary;
            lblFooterHints.ForeColor = textSecondary;

            btnModo.BackColor = cardBg;
            btnModo.ForeColor = textSecondary;
            btnModo.FlatAppearance.BorderColor = border;
            btnModo.Text = _darkMode ? "Modo: Oscuro (clic para cambiar)" : "Modo: Claro (clic para cambiar)";

            foreach (var (label, _) in _menuItems)
            {
                if (label == _selectedLabel)
                {
                    continue;
                }
                label.ForeColor = label == lblItemJ ? ExitText : textPrimary;
                label.BackColor = cardBg;
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void tmrCursor_Tick(object sender, EventArgs e)
        {
            lblCursor.Visible = !lblCursor.Visible;
        }

        private void lblItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
