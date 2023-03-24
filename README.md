# RA Unlock Sound Manager
Portable windows application achievement unlock sound randomizer for RetroArch, PCSX2, bizhawk and Duckstation.

# Prerequisites
* Windows
* A bunch of your favorite achievement unlock sounds as MP3, WAV or OGG files
* [ffmpeg](https://ffmpeg.org/)
* [.NET 6 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

# Usage
Upon launching the program the first time, you will be told you need to configure the application.  By clicking the settings button, you will find 6 fields of settings you need to enter.

* Unlock Sound Directory - Required
* ffmpeg Executable Path - Required
* RetroArch Executable Path
* PCSX2 Executable Path
* bizhawk Executable Path
* Duckstation Executable Path

At least one emulator executable path must be provded for this program to work.

Once this is selected, you can see a list of your sound objects and the emulator you wish to use.  You may choose to randomize the choice of unlock sound.  Once you select your sound and emulator settings and launch, this program will automatically convert the sound object and transfer it to the chosen emulator.  Before launching, the user or randomly chosen unlock sound will play.
