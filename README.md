# SIRGAN — Sistema de Registro Ganadero

Monorepo con las dos aplicaciones del sistema:

| Carpeta | App | Tecnología | Dónde se desarrolla |
|---|---|---|---|
| [`Solucion Ganaderia/`](Solucion%20Ganaderia/) | **Escritorio** (administración, base de datos principal) | WinForms · .NET Framework 4.7.2 · C# | Windows (Parallels) |
| [`ganaderia-tablet/`](ganaderia-tablet/) | **Tablet** (consulta / captura en campo) | React Native · Expo SDK 57 · TypeScript | macOS |

---

## Cómo funciona

### Idea general

```
 ┌──────────────────────────┐   exportable .db    ┌──────────────────────────┐
 │  Escritorio (WinForms)   │  ───────────────▶   │   Tablet (Expo / RN)     │
 │  PC vieja, x86           │   USB / carpeta /   │   abre el archivo con    │
 │  SQLite = fuente oficial │   red local         │   expo-sqlite            │
 └──────────────────────────┘                     └──────────────────────────┘
```

1. **El escritorio es el dueño de los datos.** Guarda todo en un archivo SQLite local
   (ranchos, lotes, animales, movimientos, sanidad, pesajes, etc.).
2. **Exportación:** el escritorio genera una copia consistente de la base con
   `VACUUM INTO 'export.db'`. El exportable **es el mismo archivo SQLite**, no un JSON,
   para no tener que mantener código de conversión entre las dos apps.
3. **Importación en la tablet:** la app copia el `.db` recibido a su almacenamiento y lo
   abre con `expo-sqlite`.
4. **Versión del esquema:** la base guarda su versión en `PRAGMA user_version`. La tablet
   la revisa antes de abrir el archivo y rechaza las versiones que no conoce.

> **Estado actual:** la capa de SQLite y la exportación/importación **todavía no están
> implementadas**. Esta sección describe el diseño acordado. Pendiente definir si la tablet
> solo consulta (un sentido) o también captura datos y los regresa (dos sentidos). Eso hay que
> decidirlo antes de crear las tablas.

### Reglas para que la base sirva en las dos apps

Las dos apps leen el mismo archivo, así que el esquema solo usa tipos que ambas entienden:

| Dato | Cómo se guarda | Evitar |
|---|---|---|
| Fechas | `TEXT` ISO-8601 (`2026-10-04T10:00:00Z`) o `INTEGER` con segundos desde 1970 | Ticks de `DateTime` de .NET |
| Verdadero/falso | `INTEGER` `0` / `1` | `"True"` / `"False"` como texto |
| Pesos y montos | `REAL`, o `INTEGER` en gramos o centavos | Tipos `decimal` propios de .NET |
| IDs | `INTEGER` autoincremental si es de un solo sentido; `TEXT` con UUID si la tablet también escribe | — |

### App de escritorio (WinForms)

- **`Program.cs`**: arranca `Form1`.
- **`Form1`**: ventana principal. Solo contiene el control `MainView` ocupando toda la ventana.
- **`MainView`** (`UserControl`): menú principal estilo consola:
  - 19 opciones: `1`–`9` (rancho, lotes, animales, movimientos, reportes, configuración) y
    `A`–`J` (ventas, compras, sanidad, reproducción, alimentación, pesajes, usuarios,
    respaldo, ayuda, salir).
  - **Teclado:** `1-9` / `A-J` abren una opción, `↑ ↓ ← →` mueven la selección, `Enter`
    confirma y `Esc` pide cerrar.
  - **Escalado:** el diseño base es de 1560 × 900. Cuando cambia el tamaño de la ventana,
    las posiciones y fuentes se escalan proporcionalmente, entre 0.55× y 2.2×.
  - **Tema claro/oscuro** con el botón "Modo".
  - **Eventos públicos:**
    - `MenuOptionActivated(Key, Text)`: se dispara al activar una opción.
    - `CloseRequested`: se dispara con `Esc` o con la opción `J`.

    > Por ahora `Form1` **no escucha esos eventos**, así que las opciones del menú todavía
    > no abren nada y `Esc` / `J. Salir` no cierran la ventana.

### App de tablet (Expo)

- Usa **Expo Router**. Cada archivo en `ganaderia-tablet/src/app/` es una pantalla y
  `_layout.tsx` define la navegación (pestañas nativas).
- Componentes, hooks y constantes van **fuera** de `src/app/` (`src/components`, `src/hooks`,
  `src/constants`).
- Por ahora es la **plantilla de `create-expo-app`**. Las pantallas "Home" y "Explore" son de
  ejemplo.

---

## Escritorio: compilar y ejecutar

### Requisitos (Windows)

- **Visual Studio 2022 (17.13 o posterior) o Visual Studio 2026**, con la carga de trabajo
  **"Desarrollo de escritorio de .NET"**. La solución usa el formato `.slnx`, que las
  versiones anteriores no abren.
- **Paquete de destino de .NET Framework 4.7.2** (se instala desde el Visual Studio Installer
  → Componentes individuales).

### Desarrollo

1. Abre `Solucion Ganaderia/Solucion Ganaderia.slnx`.
2. En la barra de herramientas elige la configuración **`Debug`** y la plataforma **`x86`**.
3. Presiona `F5`.

### Compilar para la PC vieja (x86)

La PC de destino es de 32 bits, así que **siempre compila con la plataforma `x86`**. No uses
`Any CPU`: el proyecto tiene `PreferNativeArm64` activado y en esa plataforma no genera un
ejecutable x86.

**Desde Visual Studio:** selecciona `Release` | `x86` y luego **Compilar → Compilar solución**.

**Desde la línea de comandos** ("Developer PowerShell for VS"):

```powershell
msbuild "Solucion Ganaderia\Solucion Ganaderia\Solucion Ganaderia.csproj" /p:Configuration=Release /p:Platform=x86
```

El resultado queda en:

```
Solucion Ganaderia\Solucion Ganaderia\bin\x86\Release\
```

### Instalar en la PC vieja

1. Copia **toda** la carpeta `bin\x86\Release\` (no solo el `.exe`). Cuando se agregue SQLite,
   ahí también quedarán sus librerías nativas.
2. La PC necesita **Windows 7 SP1 o posterior** y tener instalado **.NET Framework 4.7.2**
   (instalador offline de Microsoft).
3. Ejecuta `Solucion Ganaderia.exe`.

> Si compilas en Parallels sobre una Mac con Apple Silicon, el `.exe` x86 corre emulado, así
> que funciona igual. Aun así, **prueba en la PC real** cada vez que agregues dependencias
> nativas (SQLite).

---

## Tablet: instalar dependencias y desarrollar

### Requisitos (macOS)

- **Node.js LTS**.
- **pnpm**: el proyecto lo fija en `package.json` (`packageManager: pnpm@10.8.1`). Para
  activarlo, ejecuta una vez:
  ```bash
  corepack enable
  ```
- Para probar la app, al menos una de estas opciones:
  - **Expo Go** en la tablet física (misma red Wi-Fi que la Mac).
  - **Android Studio** con un emulador de tablet.
  - **Xcode** con el simulador de iPad.

> El `README.md` de `ganaderia-tablet/` es el de la plantilla y dice `npm install`. Usa
> **pnpm**: el lockfile del repo es `pnpm-lock.yaml`.

### Primer arranque

```bash
cd ganaderia-tablet
pnpm install
pnpm start
```

`pnpm start` abre el servidor de desarrollo de Expo. Desde ahí:

- Escanea el QR con **Expo Go** en la tablet, o
- presiona `a` para abrir el emulador de Android o `i` para el simulador de iOS.

Atajos equivalentes: `pnpm android`, `pnpm ios`, `pnpm web`.

### Agregar dependencias

Usa **siempre** `expo install`, que elige la versión compatible con el SDK 57. No uses
`pnpm add` directamente:

```bash
npx expo install expo-sqlite
```

Si agregas una librería con código nativo que no viene incluida en Expo Go, necesitarás una
*development build*: `npx expo run:android` / `npx expo run:ios`, o con EAS.

### Antes de dar algo por terminado

```bash
npx expo lint
npx tsc --noEmit
npx expo-doctor
```

### Generar el instalable

Con **EAS Build** (compila en la nube; no necesitas Android Studio):

```bash
npx eas-cli@latest login
npx eas-cli@latest build:configure
npx eas-cli@latest build --platform android --profile preview
```

Para que el perfil `preview` genere un `.apk` instalable directo en la tablet, en `eas.json`
pon `"android": { "buildType": "apk" }` dentro de ese perfil.

Las carpetas `ios/` y `android/` se generan solas (no se versionan ni se editan a mano). La
configuración nativa va en `app.json`.

---

## Flujo de trabajo entre Mac y Parallels

- El repo vive en **git**. Clónalo **por separado** en la Mac y en Windows, y sincroniza con
  `push` / `pull` contra un remoto (p. ej. GitHub privado).
- **No abras el repo desde la carpeta compartida de Parallels** (`\\Mac\...`). Visual Studio
  y `node_modules` sobre una unidad de red son lentos y causan bloqueos de archivos.
- La carpeta compartida sí sirve para pasar archivos `.db` de prueba. En la Mac se pueden
  inspeccionar con `sqlite3` o DB Browser for SQLite.
- Los `.db` / `.sqlite` están en `.gitignore` para no subir datos reales.

---

## Pendientes

- [ ] Definir si la sincronización es de un sentido o de dos.
- [ ] Definir cómo se transfiere el archivo (USB, carpeta, red local) y si la tablet es Android o iPad.
- [ ] Confirmar el Windows de la PC destino. Con XP o Vista habría que bajar la versión de .NET Framework.
- [ ] Quitar `PreferNativeArm64` y dejar `x86` como única plataforma de la solución.
- [ ] Agregar SQLite al escritorio (`System.Data.SQLite.Core`) y crear el esquema versionado.
- [ ] Conectar `MenuOptionActivated` / `CloseRequested` en `Form1`.
- [ ] Limpiar la plantilla de Expo (`pnpm reset-project`) y cambiar `orientation` en `app.json` (hoy está en `portrait`).
- [ ] Corregir la codificación de los comentarios en `MainView.cs` (aparece "TamaÃ±o" en vez de "Tamaño").
