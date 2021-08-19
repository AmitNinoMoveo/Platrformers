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
    private void Start()
    {
        CurrentCoinsText.text = "Coins: " + 0;
    }
    public void changeCoinsText(int newCoinsAmount)
    {
        CurrentCoinsText.text = "Coins: " + newCoinsAmount;
    }
}
