using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isGameOver;
    public bool IsGameOver
    {
        get => _isGameOver;
        set
        {
            _isGameOver = value;
        }
    }
    private void Start()
    {
        IsGameOver = false;
    }
    public void setGameOver()
    {
        IsGameOver = true;
        SceneManager.LoadScene(0); // Game Scene
    }
}
