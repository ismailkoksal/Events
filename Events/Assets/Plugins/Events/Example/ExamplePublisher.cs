using UnityEngine;
using Events;

public class ExamplePublisher : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Any class can publish any event by calling this.Publish.
            this.Publish<SimpleEvent>();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Here is how you can publish an event with parameters.
            this.Publish(new ComplexEvent(18, "Hello world!"));
        }
    }
}