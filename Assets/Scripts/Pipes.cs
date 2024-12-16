using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pipes : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.5f;
    [SerializeField] private GameObject _pipe;
    private float timer;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
       if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

     Destroy(pipe, 10f);
    }
}

