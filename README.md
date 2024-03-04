# Set Parent and dotnet 8 Tests

## Branch: main

Latest dotnet 8 version, maui and default Windows App SDK version

Known issues:
1. [ ] Not resizing from the top of the window
2. [ ] Using Set Parent interop method, new window opens inside the main Window, but app crashed when the child window is closed

## Branch: tests/v8.0.7-1.4.231219000

Latest dotnet 8 version, maui and Windows App Sdk version 1.4.231219000

Known issues:
1. [X] Not resizing from the top of the window - **Fixed**
2. [ ] Using Set Parent interop method, new window opens inside the main Window, but app crashed when the child window is closed

## Branch: tests/v8.0.7-1.4.240211001

Latest dotnet 8 version, maui and Windows App Sdk version 1.4.240211001

Known issues:
1. [X] Not resizing from the top of the window - **Fixed**
2. [ ] Set Parent funcionality:
   1. [ ] New window opens inside the main Window - **App Crashed**
   2. [ ] App crashed when the child window is closed - **N/A**

## Branch: tests/v8.0.7-1.5.240227000

Latest dotnet 8 version, maui and Windows App Sdk version 1.5.240227000

Known issues:
1. [X] Not resizing from the top of the window - **Fixed**
2. [ ] Set Parent funcionality:
   1. [X] New window opens inside the main Window
   2. [ ] App crashed when the child window is closed - **N/A**

