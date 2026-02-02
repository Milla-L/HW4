using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private GameObject scoreblock;
    [SerializeField] private UI ui;
    [SerializeField] private float miny;
    [SerializeField] private float maxy;

    private float timer = 2;

    private void Start()
    {

    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            CreatePipe();
            timer = 2;
        }
    }

    public void CreatePipe()
    {
        float pipepos = Random.Range(miny, maxy);
        Vector3 pipespawnpos = new Vector3(transform.position.x, pipepos, 0);
        float scoreblockpos = pipepos - 2.75f;
        Vector3 scorespawnpos = new Vector3(transform.position.x, scoreblockpos, 0);
        Instantiate(pipePrefab, pipespawnpos, Quaternion.identity);
        Instantiate(scoreblock, scorespawnpos, Quaternion.identity);
    }

}
