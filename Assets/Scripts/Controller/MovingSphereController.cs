using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphereController : ISphereController
{
    public Vector3 UpdatePosition(float x, float y) 
    {
        return new Vector3(x,0.5f,y);
    }
}

interface ISphereController
{
    public Vector3 UpdatePosition(float x, float y);
}
