using UnityEngine;
using Zenject;

public class MovingSphereView : MonoBehaviour
{
    [Inject]
    ISphereController _sphereController;

    void Update() 
    {
        Vector2 localPosition;
        localPosition.x = Input.GetAxis("Horizontal");
        localPosition.y = Input.GetAxis("Vertical");
        transform.localPosition = _sphereController.UpdatePosition(localPosition);
    }
}
