# skadiprices.csgofast

[![NuGet](https://img.shields.io/nuget/v/skadisteam.login.svg)](https://www.nuget.org/packages/skadisteam.login/)
[![Discord](https://img.shields.io/badge/discord-join%20chat-blue.svg)](https://discord.gg/0i5X3oDHJbDUsiGC)

If you join the discord, message igeligel.

|               | Build Status  | 
| ------------- |:-------------:| 
| Linux/Mac     | WIP | 
| Windows       | WIP |

.net core package to interact with the [csgofast.com pricing api](https://api.csgofast.com/sih/all).

## Project
An api wrapper around the csgofast.com pricing api.
It will enable you to read prices easily out of the csgofast api.

## Installation

You can use it as a nuget package. Just use it as reference in your project.json file.

Otherwise, you can build the project by yourself and reference the build like this:

1. You need to install .net core. For instructions head over [here](https://www.microsoft.com/net/core).
2. Open your command line.
3. Change directory to the package's source.
4. 
   ```
   $ dotnet restore
   ```
5. 
   ```
   $ dotnet build
   ```
6. Reference your build like this:

   ```
   "skadiprices.csgofast": "0.1.0-*"
   ```

   in your project.json file. For an example watch the [testing package](https://github.com/igeligel/skadiprices.csgofast/tree/master/src/skadiprices.csgofast.test).

## Documentation

The documentation is referenced here:

[Click me](https://github.com/igeligel/skadiprices.csgofast/blob/master/documentation/public.md) to get to the documentation


## Contribute

Watch the [master repository](https://github.com/igeligel/skadisteam) for more information.

## Authors
- [igeligel](https://github.com/igeligel)

## Contact
[![Steam](https://raw.githubusercontent.com/encharm/Font-Awesome-SVG-PNG/master/black/png/16/steam-square.png "Steam Account") Steam](http://steamcommunity.com/profiles/76561198028630048/)

[![Twitter](https://raw.githubusercontent.com/encharm/Font-Awesome-SVG-PNG/master/black/png/16/twitter.png "Twitter") Twitter](https://twitter.com/kevinpeters_)

[![Discord](http://i.imgur.com/wlwOQpl.png "Discord") Discord (I am igeligel there. Just send me a direct message)](https://discord.gg/0i5X3oDHJbDUsiGC)

## License
[MIT](https://github.com/igeligel/skadiprices.csgofast/blob/master/LICENSE)
