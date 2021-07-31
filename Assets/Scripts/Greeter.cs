using UnityEngine;

public class Greeter
{
    private string _message;
    private Vector3 velocity;

    public Greeter(string message)
    {
        _message = message;
    }

    public string sayHello() {
        return _message;
    }
}