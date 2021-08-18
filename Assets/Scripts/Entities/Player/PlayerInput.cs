using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerInput : PlayerStats
{
    private float _horizontalInput;
    public float HorizontalInput
    {
        get => _horizontalInput;
        private set => _horizontalInput = value;
    }
    private bool _isSpacePressed;
    public bool IsSpacePressed
    {
        get => _isSpacePressed;
        private set => _isSpacePressed = value;
    }
    public virtual void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        IsSpacePressed = Input.GetButtonDown("Jump");
    }
}
