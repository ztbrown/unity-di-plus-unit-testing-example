using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModel : ISphereModel
{
    Vector3 _localPosition;

    public void Awake(Vector3 localPosition)
    {
        _localPosition = localPosition;
    }

    public Vector3 UpdatePosition(Vector2 input) 
    {
        input = Vector2.ClampMagnitude(input, 1f);
        _localPosition += new Vector3(input.x, 0.0f, input.y);
        return _localPosition; 
    }

}

public interface ISphereModel
{
    public Vector3 UpdatePosition(Vector2 input);
    public void Awake(Vector3 input);
}

