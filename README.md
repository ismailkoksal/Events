# Events

Use this if you want to do Event-Driven Programming very easily in your project.

## Getting Started

For a quick import into an existing project, just get the [UnityPackage](EventsPackage.unitypackage).

The Events folder is an empty project with only the plugin imported and some examples! :)

See the [Code Usage](#code-usage) for details on how to use it in your project.

## Prerequisites

There are absolutely no prerequisites to this plugin.

Everything comes into a few files (and most of them are used for demo).

## Code Usage

<details><summary>Examples of Events :</summary>
```csharp
public class SimpleEvent : Event
{
    // You can have an event with no parameter at all.
}

public class ComplexEvent : Event
{
    // Or you can have an event which carries parameters across all observers.

    public int myInt { get; private set; }
    public string myString { get; private set; }

    public ComplexEvent() { }

    public ComplexEvent(int myInt)
    {
        this.myInt = myInt;
    }

    public ComplexEvent(int myInt, string myString)
    {
        this.myInt = myInt;
        this.myString = myString;
    }
}
```
</details>

## Screenshots

![Example 1](Screenshots/Example_1.PNG)
![Example 2](Screenshots/Example_2.PNG)

## Notes

* Last tested with [Unity 2018.2.1f1](https://unity3d.com/unity/whatsnew/unity-2018.2.1).

## Authors

* **[Arthur Cousseau](https://www.linkedin.com/in/arthurcousseau/)**

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details