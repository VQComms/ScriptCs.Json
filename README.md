# ScriptCs.Json [![NuGet](http://img.shields.io/nuget/v/ScriptCs.Json.svg?style=flat)](https://www.nuget.org/packages/ScriptCs.Json/)

This is a cross platform ScriptCs library that allows you deserialize JSON into objects.

## Usage

`scriptcs -install ScriptCs.Json` 

```
public class Person
{
    public string FirstName{ get; set; }

    public string LastName{ get; set; }

    public string FullName{ get { return FirstName + " " + LastName; } }
}

var myjson = "{\"firstname\":\"bob\",\"lastname\":\"smith\"}";

var json = new Json();

var person = json.Deserialize<Person>(myjson);
Console.WriteLine(person.FullName);

var otherPerson = json.DeserializeFromFile<Person>("json.txt");
Console.WriteLine(otherPerson.FullName);

Console.WriteLine("Fin!");
```
