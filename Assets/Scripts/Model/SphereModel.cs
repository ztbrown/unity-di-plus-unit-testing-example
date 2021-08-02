using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModel : ISphereModel
{
    public Vector3 UpdatePosition(Vector2 input) 
    {
        input = Vector2.ClampMagnitude(input, 1f);
        return new Vector3(input.x,0.5f,input.y);
    }

}

public interface ISphereModel
{
    public Vector3 UpdatePosition(Vector2 input);
}

