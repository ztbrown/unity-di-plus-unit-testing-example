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

    public Vector3 Update(Vector2 input) 
    {
        return _model.UpdatePosition(input);
    }

}

public interface ISphereController
{
    public Vector3 Update(Vector2 input);
}
