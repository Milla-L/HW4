using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private int points = 0;
    private bool isGameover;

    private void Start()
    {
        isGameover = true;
        Locator.Instance.Player.getPoint += OnPlayerScore;
        Locator.Instance.Player.endGame += OnPlayerDeath;
        UpdateUI();
    }

    public void UpdateUI()
    {
        scoreText.text = points.ToString();
    }

    private void OnPlayerScore() 
    {
        if (isGameover == true) 
        {
            points++;
            UpdateUI();
        }

    }

    private void OnPlayerDeath() 
    {
        isGameover = false;
    }
}
