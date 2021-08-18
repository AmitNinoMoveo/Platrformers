using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerInput : Entity
{
    private CharacterController _characterController;
    public CharacterController CharacterController
    {
        get => _characterController;
        private set
        {
            _characterController = value;
        }
    }
    private Vector3 _direction;
    public Vector3 Direction
    {
        get => _direction;
        private set => _direction = value;
    }
    private bool _isSpacePressed;
    public bool IsSpacePressed
    {
        get => _isSpacePressed;
        private set => _isSpacePressed = value;
    }
    public virtual void Start()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    public virtual void Update()
    {
        Direction = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        IsSpacePressed = Input.GetButtonDown("Jump");
    }
}
