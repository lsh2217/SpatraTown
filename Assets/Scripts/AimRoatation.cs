using System;
using UnityEngine;


public class AimRoatation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerRenderer;

    private TownController controller;
    private void Awake()
    {
        controller = GetComponent<TownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 vector)
    {
        RotateArm(vector);
    }

    private void RotateArm(Vector2 vector)
    {
        float rotZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        playerRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}

