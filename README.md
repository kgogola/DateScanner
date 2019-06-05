# DateScanner
Command line application in C# with unit tests.


The .NET Framework software takes two dates in proper format as input and returns appropriate scope in chronological order.

Example usage with expected results printed in console are presented below:

program.exe

INPUT: 01.01.2017 05.01.2017

OUTPUT: 01 - 05.01.2017

program.exe

INPUT: 01.01.2017 05.02.2017

OUTPUT: 01.01 – 05.02.2017

program.exe

INPUT: 01.01.2016 05.01.2017

OUTPUT 01.01.2016 – 05.01.2017
