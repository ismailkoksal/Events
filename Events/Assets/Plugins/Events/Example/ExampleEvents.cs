using Events;

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