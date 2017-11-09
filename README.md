# NetStandardIntro
A set of exercises to practice converting to .NET Standard, hopefully exposing some of the weirder bugs you might encounter

## RomanNumerals

Create a new .NET standard class library.

Set it to .NET Standard 1.4

Add "existing items" from RomanNumerals.

Change RomanNumerals.Tests to reference RomanNumerals.Standard [cb77be8]

## StarWars

Create a new .NET standard class library.

Set it to .NET Standard 1.4

Add "existing items" from StarWars

Switch from WebRequest to HttpClient [3103866]

Run unit tests (observe the exception)

Add nuget reference to System.Net.Http

Run unit tests (still breaking)

Add to .csproj

```
<PropertyGroup>
  <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
  <GenerateBindingRedirectsOutputType>true</GenerateBindingRedirectsOutputType>
</PropertyGroup>
```

Rebuild.  Run unit tests (now missing Newtonsoft.JSON) [23f3ae7]

Add nuget reference

Rebuild.  Run unit tests (passing!) [74f31be35]

## FizzBuzz

Create a new .NET standard class library.

Set it to .NET Standard 2.0 (fancy!)

Add code

Add nuget reference to Dapper.NET (basic - this has a .NET Standard package)

Add nuget reference to Sqlite.Data.Core (This only has a .NET Framework package -- DUN DUN DUN!!!!)

Run unit tests (all pass!) [SecondOven]