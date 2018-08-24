using UnityEngine;
using Events;

public class ExampleObserver : MonoBehaviour,
    IEventHandler<SimpleEvent>,
    IEventHandler<ComplexEvent> // You can handle as many events as you want!
{

    // We can subscribe in Awake, to be able to respond to events that are published in Start.
    // Note that you won't be able to catch events that have been published before you subscribed!
    void Awake()
    {
        // This is how you suscribe to an event.
        this.Subscribe<SimpleEvent>();
        // I don't know why it is not recognized by VS for autocompletion, though
        this.Subscribe<ComplexEvent>();
    }

    void IEventHandler<SimpleEvent>.Handle(SimpleEvent @event) // This is a possible writing of the method
    {
        Debug.Log("SimpleEvent");
    }

    public void Handle(ComplexEvent @event) // This is another possible writing of the method. You decide!
    {
        Debug.Log("ComplexEvent with arguments: " + @event.myInt + " and '" + @event.myString + "'");
    }

    void Destroy()
    {
        // It is recommended to unsuscribe to the events you were subscribed to,
        // when you're not able to catch them anymore.
        this.Unsubscribe<SimpleEvent>();
        this.Unsubscribe<ComplexEvent>();
    }
}