using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerInput
{
    public override void Update()
    {
        base.Update();
        CharacterController.Move(Direction * Speed * Time.deltaTime);
    }
}
