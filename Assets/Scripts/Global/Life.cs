using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : WorldInfo
{
    [SerializeField]
    private int _maxLife;
    public int MaxLife
    {
        get => _maxLife;
        set
        {
            if (value >= 1)
            {
                _maxLife = value;
            }
        }
    }
    [SerializeField]
    private int _currentLife;
    public int CurrentLife
    {
        get => _currentLife;
        set
        {
            if (value >= 0 || value <= MaxLife)
            {
                _currentLife = value;
            }
        }
    }
    [SerializeField]
    private bool _isAlive;
    public bool IsAlive
    {
        get => _isAlive;
        set
        {
            _isAlive = value;
        }
    }
    public virtual void Start()
    {
        IsAlive = true;
        CurrentLife = MaxLife;
    }
    public virtual void changeCurrentLifeAmount(int amount = 1)
    {
        if ((amount + CurrentLife) <= 0)
        {
            IsAlive = false;
            CurrentLife = 0;
            return;
        }
        else if ((amount + CurrentLife) >= MaxLife)
        {
            CurrentLife = MaxLife;
            return;
        }
        else
        {
            CurrentLife += amount;
        }
    }
}
