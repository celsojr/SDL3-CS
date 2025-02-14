# **SDL3-CS Project Template**  
A cross-platform C# template for **SDL3**, providing a simple starting point for SDL3-based projects.

## Motivation
Some C# developers may just want to experiment and prototype with SDL3 without having to learn C/C++ or any other language.

## Dependencies  
- **SDL3-CS** (Simple DirectMedia Layer 3 - Already included in the thirdparty folder)  
  - Download: [https://github.com/flibitijibibo/SDL3-CS](https://github.com/flibitijibibo/SDL3-CS)  
- **.NET 9.0+**  
  - Install via [https://dotnet.microsoft.com/](https://dotnet.microsoft.com/)  
- **Git**  
  - Install via [https://git-scm.com/](https://git-scm.com/)  
- **GitHub CLI (gh)**  
  - Install via [https://cli.github.com/](https://cli.github.com/)


# Getting Started  

### Clone the Repository
```sh
gh repo clone celsojr/SDL3-CS

cd SDL3-CS
```

# Building the Project  
### Windows / macOS / Linux
```sh
dotnet build
```

# Download Pre-Built SDL3 Binaries  
Instead of building SDL3 from source, you can use the **pre-compiled libraries** provided in the releases. I'm using the GitHub CLI to download from release, but you can use anything you want. You can even download it manually.

### Windows
```powershell
gh release download 1.0.0 -p SDL3-CS-windows.zip -R celsojr/SDL3-CS

Expand-Archive SDL3-CS-windows.zip -DestinationPath bin/Debug/net9.0
```

### macOS
```sh
gh release download 1.0.0 -p SDL3-CS-macOS.zip -R celsojr/SDL3-CS

unzip SDL3-CS-macOS.zip -d bin/Debug/net9.0
```

### Linux
```sh
gh release download 1.0.0 -p SDL3-CS-linux.zip -R celsojr/SDL3-CS

unzip SDL3-CS-linux.zip -d bin/Debug/net9.0
```

# Rename Libraries (if necessary)
Some platforms may require renaming `libSDL3.0.dylib` to `SDL3.dylib` for compatibility.

### macOS
```sh
mv bin/Debug/net9.0/libSDL3.0.dylib bin/Debug/net9.0/SDL3.dylib
```

### Linux
```sh
mv bin/Debug/net9.0/libSDL3.so.0 bin/Debug/net9.0/SDL3.so
```

# Set Environment Variables (if necessary) & Run
### Windows (PowerShell)
```powershell
$env:PATH = "$PWD\bin\Debug\net9.0;" + $env:PATH

bin\Debug\net9.0\SDL3-CS.exe
```

### macOS / Linux (Bash)
```sh
export DYLD_LIBRARY_PATH=$PWD/bin/Debug/net9.0:$DYLD_LIBRARY_PATH

bin/Debug/net9.0/SDL3-CS
```

## Debugging Library Loads
To check the loaded libraries:

### Linux
```sh
LD_DEBUG=libs bin/Debug/net9.0/SDL3-CS
```

### macOS
```sh
DYLD_PRINT_LIBRARIES=1 bin/Debug/net9.0/SDL3-CS
```

# Notes
- This is a **template project**, consider this as a starting point for prototyping.
- **SDL3-CS is required** for this project to function properly (included in the thirdparty folder).
- If you encounter issues with missing shared libraries, ensure your **library paths** are correctly set.

