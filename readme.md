```sh
# pre-compiled libs
cp -r $HOME/Repos/Moonworks-Test/moonlibs/macos/* $HOME/Repos/SDL3-CS/bin/Debug/net9.0

# After renaming `libSDL3.0.dylib` to just `SDL3.dylib` this is working
mv $HOME/Repos/SDL3-CS/bin/Debug/net9.0/libSDL3.0.dylib $HOME/Repos/SDL3-CS/bin/Debug/net9.0/SDL3.dylib

# Path to the pre-compiled libs
DYLD_LIBRARY_PATH=$HOME/Repos/Moonworks-Test/moonlibs/macos:$DYLD_LIBRARY_PATH

dotnet build

# DYLD_PRINT_LIBRARIES to see what it’s actually loading.
DYLD_PRINT_LIBRARIES=1 ./bin/Debug/net9.0/SDL3-CS

```
