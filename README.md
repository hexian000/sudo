# sudo
A sudo for Windows cmd

# usage

1. Build by simply click "Build" in Visual Studio or download a prebuilt binary from the release page
2. Copy sudo.exe to %windir%\System32
3. Invoke your command like this:

```batch
net session >nul 2>&1 && echo OK & pause
```
