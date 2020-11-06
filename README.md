# Timesheet Generator

## About
This is a simple program I wrote to generate blank timesheet text files. I normally create new file every monday morning and it's quite repetitive. This program makes it easier. <br>
It is written in C# and targets dotnet core 3.1.

## Usage
To use this, :
```
dotnet run <dd> <mm> <yyy>

eg

dotnet run 13 06 2020 // for 13 June 2020
```


## Expected Output
A txt file with a structure like:
```
Monday June 13, 2020
Log On -
Lunch -
Log Off -

------------

Tuesday June 14 2020 ...etc
```