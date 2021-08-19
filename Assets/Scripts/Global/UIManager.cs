using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _currentCoinsText;
    public Text CurrentCoinsText
    {
        get => _currentCoinsText;
        private set => _currentCoinsText = value;
    }
    [SerializeField]
    private Text _currentLivesText;
    public Text CurrentLivesText
    {
        get => _currentLivesText;
        private set => _currentLivesText = value;
    }
    private void Start()
    {
        CurrentCoinsText.text = "Coins: " + 0;
    }
    public void changeCoinsText(int newCoinsAmount)
    {
        CurrentCoinsText.text = "Coins: " + newCoinsAmount;
    }
    public void changeLivesText(int newLivesAmount)
    {
        CurrentLivesText.text = "Lives: " + newLivesAmount;
    }

}
