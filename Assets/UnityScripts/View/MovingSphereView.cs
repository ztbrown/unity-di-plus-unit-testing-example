using UnityEngine;
using Zenject;

public class MovingSphereView : MonoBehaviour
{
    [Inject]
    ISphereController _sphereController;

    void Update() 
    {
        transform.localPosition = _sphereController
            .UpdatePosition(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
