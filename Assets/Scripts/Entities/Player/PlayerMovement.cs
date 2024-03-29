﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerInput
{
    [SerializeField]
    private float _gravity;
    public float Gravity
    {
        get => _gravity;
        private set => _gravity = value;
    }
    [SerializeField]
    private float _jumpHeight;
    public float JumpHeight
    {
        get => _jumpHeight;
        set => _jumpHeight = value > 1 ? value : 1;
    }
    [SerializeField]
    private bool _isGrounded;
    public bool IsGrounded
    {
        get => _isGrounded;
        private set => _isGrounded = value;
    }
    [SerializeField]
    private bool _canDoubleJump;
    public bool CanDoubleJump
    {
        get => _canDoubleJump;
        private set => _canDoubleJump = value;
    }
    private CharacterController _controller;
    public CharacterController Controller
    {
        get => _controller;
        private set
        {
            _controller = value;
        }
    }
    private Vector3 _direction;
    public Vector3 Direction
    {
        get => _direction;
        private set => _direction = value;
    }
    private Vector3 _velocity;
    private float _yVelocity;
    public virtual void Start()
    {
        Controller = GetComponent<CharacterController>();
    }
    public override void Update()
    {
        base.Update();
        IsGrounded = Controller.isGrounded;
        Move();
    }
    void generateDirection()
    {
        Direction = new Vector3(HorizontalInput, 0, 0);
    }
    void applyGravtiyOrJump()
    {
        if (IsGrounded && IsSpacePressed)
        {
            CanDoubleJump = true;
            _yVelocity = JumpHeight;
        }
        else if (!IsGrounded && IsSpacePressed && CanDoubleJump)
        {
            CanDoubleJump = false;
            _yVelocity += JumpHeight;
        }
        else
        {
            _yVelocity -= Gravity;
        }
        _velocity.y = _yVelocity;
    }
    void calculateVelocity()
    {
        _velocity = Direction * Speed;
    }
    void CalculateMovement()
    {
        generateDirection();
        calculateVelocity();
        applyGravtiyOrJump();
    }
    void Move()
    {
        CalculateMovement();
        Controller.Move(_velocity * Time.deltaTime);
    }
}
