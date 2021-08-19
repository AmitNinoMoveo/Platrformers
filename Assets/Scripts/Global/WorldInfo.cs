using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldInfo : MonoBehaviour
{

    private float _yTopScreenBorder = 15f;
    public float YTopScreenBorder
    {
        get => _yTopScreenBorder;
        private set => _yTopScreenBorder = value;
    }
    private float _yBottomScreenBorder = -7f;
    public float YBottomScreenBorder
    {
        get => _yBottomScreenBorder;
        private set => _yBottomScreenBorder = value;
    }
    private float _xLeftScreenBorder = -20f;
    public float XLeftScreenBorder
    {
        get => _xLeftScreenBorder;
        private set => _xLeftScreenBorder = value;
    }
    private float _xRightScreenBorder = 30f;
    public float XRightScreenBorder
    {
        get => _xRightScreenBorder;
        private set => _xRightScreenBorder = value;
    }
}
