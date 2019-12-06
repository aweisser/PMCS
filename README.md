User PMCS.Core.CLI.Programm to parse existing C# code and create a .mse file.

You may then import the .mse file into [CodeCity](https://wettel.github.io/codecity-faq.html) to render your C# code as a Code City.

![Code City](https://wettel.github.io/pics/codecity_screenshot.png)

PMCS stands for Parsing and Modeling C# Systems.
The code in this repository is a fork from Erik Doernenburgs [PMCS project on bitbucket](https://bitbucket.org/erikdoe/pmcs).
The original PMCS code was written by Ermira Daka, and then donated for further development.

## Project Structure

### PMCS
Project *PMCS* represents https://bitbucket.org/erikdoe/pmcs/commits/99012d8659a3d4509bf75bf8a09e460a3298ebe9.
This is the latest commit from Erik (2009-07-29) and will not be extended on github.

### PMCS.Core
Project *PMCS.Core* is a new .NET Core 2.1 version of the PMCS core model.

### PMCS.Core.CLI
Project *PMCS.Core.CLI* is a command line interface for .NET Core 2.1.