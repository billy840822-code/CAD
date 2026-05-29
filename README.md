# PipePanel — AutoCAD 2020 Plugin

A dockable palette panel for AutoCAD 2020 with **Diameter** and **System** dropdowns.
Type `PPANEL` in AutoCAD to toggle the panel.

---

## Download (No compile needed)

Go to [**Releases**](../../releases) and download `PipePanel.dll` from the latest build.

---

## Install

1. Create the folder:
   ```
   %APPDATA%\Autodesk\ApplicationPlugins\PipePanel.bundle\Contents\
   ```
2. Copy `PipePanel.dll` → `Contents\`
3. Copy `PipePanel.bundle\PackageContents.xml` → `PipePanel.bundle\`
4. Restart AutoCAD 2020
5. Type command: `PPANEL`

---

## If the GitHub Actions build fails

`AcWindows.dll` is required but is **not** on NuGet — it ships with AutoCAD only.

### Fix (one-time setup):
1. Find the file on your computer:
   ```
   C:\Program Files\Autodesk\AutoCAD 2020\AcWindows.dll
   ```
2. Copy it into this repo at:
   ```
   PipePanel/libs/AcWindows.dll
   ```
3. Commit and push — GitHub Actions will pick it up and build successfully.

> **Note:** `AcWindows.dll` is added to `.gitignore` by default for licensing reasons.
> You may need to force-add it: `git add -f PipePanel/libs/AcWindows.dll`

---

## Usage

| Action | Result |
|--------|--------|
| `PPANEL` | Toggle palette open/closed |
| Select Diameter + System, click **Apply** | Prints to AutoCAD command line |
| Click **Reset** | Restores both dropdowns to index 0 |

### Example output:
```
Diameter: DN50 (2in) | System: Fire Protection (FPS)
```
