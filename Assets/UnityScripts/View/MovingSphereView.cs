using UnityEngine;
using Zenject;

public class MovingSphereView : MonoBehaviour
{
    [Inject]
    ISphereController _sphereController;

    void Awake()
    {
        _sphereController.Awake(transform.localPosition);
    }

    void Update() 
    {
        Vector2 localPosition;
        localPosition.x = Input.GetAxis("Horizontal");
        localPosition.y = Input.GetAxis("Vertical");
        transform.localPosition = _sphereController.Update(localPosition);
    }
}
