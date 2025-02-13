# **SDL3-CS Project Template**  
A cross-platform **C# binding** for **SDL3**, providing a simple starting point for SDL3-based projects.

## **📌 Prerequisites**  
### **Dependencies**  
- **SDL3** (Simple DirectMedia Layer 3)  
  - Download: [https://github.com/libsdl-org/SDL](https://github.com/libsdl-org/SDL)  
- **.NET 9.0+**  
  - Install via [https://dotnet.microsoft.com/](https://dotnet.microsoft.com/)  
- **Git**  
  - Install via [https://git-scm.com/](https://git-scm.com/)  


# **🚀 Getting Started**  

### **1️⃣ Clone the Repository**
```sh
gh repo clone celsojr/SDL3-CS

cd SDL3-CS
```

# **🛠 Building the Project**  
### **Windows / macOS / Linux**
```sh
dotnet build
```

# **⬇️ Download Pre-Built SDL3 Binaries**  
Instead of building SDL3 from source, you can use the **pre-compiled libraries** provided in the releases. I'm using the GitHub CLI to download from release, but you can use anything you want. You can even download it manually.

### **Windows**
```powershell
gh release download 1.0.0 -p SDL3-CS-windows.zip -R celsojr/SDL3-CS

Expand-Archive SDL3-CS-windows.zip -DestinationPath bin/Debug/net9.0
```

### **macOS**
```sh
gh release download 1.0.0 -p SDL3-CS-macOS.zip -R celsojr/SDL3-CS

unzip SDL3-CS-macOS.zip -d bin/Debug/net9.0
```

### **Linux**
```sh
gh release download 1.0.0 -p SDL3-CS-linux.zip -R celsojr/SDL3-CS

unzip SDL3-CS-linux.zip -d bin/Debug/net9.0
```

# **🔄 Rename Libraries (If Necessary)**
Some platforms may require renaming `libSDL3.0.dylib` to `SDL3.dylib` for compatibility.

### **macOS**
```sh
mv bin/Debug/net9.0/libSDL3.0.dylib bin/Debug/net9.0/SDL3.dylib
```

### **Linux**
```sh
mv bin/Debug/net9.0/libSDL3.0.so.0 bin/Debug/net9.0/SDL3.so.0
```

# **🖥️ Set Environment Variables & Run**
### **Windows (PowerShell)**
```powershell
$env:PATH = "$PWD\bin\Debug\net9.0;" + $env:PATH

bin\Debug\net9.0\SDL3-CS.exe
```

### **macOS / Linux (Bash)**
```sh
export DYLD_LIBRARY_PATH=$PWD/bin/Debug/net9.0:$DYLD_LIBRARY_PATH

DYLD_PRINT_LIBRARIES=1 ./bin/Debug/net9.0/SDL3-CS
```

# **📢 Notes**
- This is a **template project**, consider this as a starting point for prototyping.
- **SDL3 is required** for this project to function properly (included in the lib folder).
- If you encounter issues with missing shared libraries, ensure your **library paths** are correctly set.

