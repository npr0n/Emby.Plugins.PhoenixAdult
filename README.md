# PhoenixAdult

This metadata provider helps fill Emby with information for your adult videos by pulling from the original site

[![GPL 2.0 License](https://img.shields.io/github/license/DirtyRacer1337/Emby.Plugins.PhoenixAdult)](./LICENSE) [![Current Release](https://img.shields.io/github/release/DirtyRacer1337/Emby.Plugins.PhoenixAdult)](https://github.com/DirtyRacer1337/Emby.Plugins.PhoenixAdult/releases/latest)

------------

## Required Libraries
- [PhoenixAdult.NET](https://github.com/DirtyRacer1337/PhoenixAdult.NET)

## Build Process
1. Clone or download this repository
2. Ensure you have .NET Core SDK setup and installed
3. Build plugin with following command.
```sh
dotnet publish --configuration Release --output bin
```
4. Place the resulting file in the `plugins` folder under the program data directory or inside the portable install directory
