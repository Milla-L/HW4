using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBlock : MonoBehaviour
{
    [SerializeField] private float speed = 4.0f;
    [SerializeField] private Collider2D coincollider;

    private void Start()
    {
        Locator.Instance.Player.endGame += OnPlayerDeath;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnPlayerDeath()
    {
        
    }
}
