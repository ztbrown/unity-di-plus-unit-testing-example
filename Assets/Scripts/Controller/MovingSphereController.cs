using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphereController : ISphereController
{
    public Vector3 UpdatePosition(Vector2 input) 
    {
        input = Vector2.ClampMagnitude(input, 1f);
        return new Vector3(input.x,0.5f,input.y);
    }
}

interface ISphereController
{
    public Vector3 UpdatePosition(Vector2 input);
}
