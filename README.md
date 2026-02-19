# 7DtD HP Editor

A small utility for quickly and easily editing zombie stats in 7 Days to Die via the game's configuration file.

## Description

7DtD HP Editor allows you to easily change the health (HP) and defense of zombies in 7 Days to Die without manually editing XML files. The utility works with the `entityclasses.xml` file, automating the process of modifying the stats of all zombie types.

## Features

- Adjustable maximum zombie health
- Configure protection settings
- Support for all zombie types (normal, feral, radioactive)
- Automatic backup before changes
- Simple and intuitive interface

## Requirements

- .NET Framework 4.7.2
- 7 Days to Die (any version with `entityclasses.xml` support)

## Installation

### Releases

1. Download the latest version from the [Releases](https://github.com/Lonewolf239/7DtD_HP/releases) section
2. Unzip the archive to a convenient location
3. Run `7DtD_HP.exe`

## Usage

```bash
7DtD_HP.exe
```

The utility will automatically find the `entityclasses.xml` file in the game's default location.

## Config file location

By default, the file is located at:

C:\Program Files (x86)\Steam\steamapps\common\7 Days To Die\Data\Config\entityclasses.xml

Before making changes, the utility creates a backup copy: `backup-entityclasses.xml`

## License

This project is distributed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Author

[Lonewolf239](https://github.com/Lonewolf239)

## See also

- [NeoIni](https://github.com/Lonewolf239/NeoIni) - A library for working with INI files in .NET
