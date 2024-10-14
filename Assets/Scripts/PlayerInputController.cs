using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerInputController : TownController
{
    private Camera camera;
    [SerializeField] Image image;
    protected override void Awake()
    {
        camera = Camera.main;
    }
    public void OnMove(InputValue inputValue)
    {
        Vector2 moveInput = inputValue.Get<Vector2>().normalized;
        if(!image.transform.gameObject.activeSelf) CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue inputValue)
    {
        Vector2 newAim = inputValue.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(newAim);
    }
}

