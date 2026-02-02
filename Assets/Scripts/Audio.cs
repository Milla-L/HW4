using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource jumpsound;
    [SerializeField] private AudioSource scoresound;
    [SerializeField] private AudioSource diesound;
    // Start is called before the first frame update
    void Start()
    {
        Locator.Instance.Player.playerJump += OnPlayerJump;
        Locator.Instance.Player.endGame += OnPlayerDie;
        Locator.Instance.Player.getPoint += OnPlayerScore;
    }

    private void OnPlayerJump()
    {
        jumpsound?.Play();
    }

    private void OnPlayerDie()
    {
        diesound?.Play();
    }

    private void OnPlayerScore()
    {
        scoresound?.Play();
    }
}
