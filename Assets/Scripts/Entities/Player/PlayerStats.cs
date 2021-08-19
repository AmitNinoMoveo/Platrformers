using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UIManager))]
public class PlayerStats : Entity
{
    private UIManager _uiManager;
    private GameManager _gameManager;
    [SerializeField]
    private int _coins;
    public int Coins
    {
        get => _coins;
        private set => _coins = value > 0 ? value : 0;
    }
    public override void Start()
    {
        base.Start();
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (_uiManager == null) Debug.LogError("PlayerStats::UI Manager is null");
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (_gameManager == null) Debug.LogError("PlayerStats::Game Manager is null");

        _uiManager.changeLivesText(CurrentLife);
    }
    public void ChangeCoinsByAmount(int amount = 1)
    {
        Coins += amount;
        _uiManager.changeCoinsText(Coins);
    }
    public override void changeCurrentLifeAmount(int amount = 1)
    {
        base.changeCurrentLifeAmount(amount);
        if (!IsAlive) _gameManager.setGameOver();
        _uiManager.changeLivesText(CurrentLife);
    }
}
