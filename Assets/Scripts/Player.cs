using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpHeight;

    public delegate void Jump();
    public event Jump playerJump;

    public delegate void Die();
    public event Die endGame;

    public delegate void Score();
    public event Score getPoint;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpHeight);
            playerJump?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.tag.Equals("Pipe"))
        {
            endGame?.Invoke();
            this.enabled = false;
            DestroyPipes();
        }

        if (collide.gameObject.tag.Equals("Score"))
        {
            getPoint?.Invoke();
        }
    }

    private void DestroyPipes()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Pipe");
        foreach (GameObject gameObject in gameObjects)
        {
            Destroy(gameObject);
        }
    }
}
