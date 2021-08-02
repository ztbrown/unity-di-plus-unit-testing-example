using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : ISphereController
{
    ISphereModel _model;

    public SphereController(ISphereModel model)
    {
        _model = model;
    }

    public void Awake(Vector3 input)
    {
        _model.Awake(input);
    }

    public Vector3 Update(Vector2 input) 
    {
        return _model.UpdatePosition(input);
    }

}

public interface ISphereController
{
    public Vector3 Update(Vector2 input);
    public void Awake(Vector3 input);
}