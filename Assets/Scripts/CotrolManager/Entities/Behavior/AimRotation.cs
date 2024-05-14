using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private ControlManager controlManager;      

    private void Awake()
    {
        controlManager = GetComponent<ControlManager>();       
    }

    void Start()
    {
        controlManager.OnLookEvent += OnAim;
    }    

    private void OnAim(Vector2 newAimDirection)
    {
        float rotZ = MathF.Atan2(newAimDirection.y, newAimDirection.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }       
}
