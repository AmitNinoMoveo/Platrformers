using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UIManager))]
public class PlayerStats : Entity
{
    private UIManager _uiManager;
    [SerializeField]
    private int _coins;
    public int Coins
    {
        get => _coins;
        private set => _coins = value > 0 ? value : 0;
    }
    public virtual void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (_uiManager == null) Debug.LogError("PlayerStats::UI Manager is null");
    }
    public void ChangeCoinsByAmount(int amount = 1)
    {
        Coins += amount;
        _uiManager.changeCoinsText(Coins);
    }
}
