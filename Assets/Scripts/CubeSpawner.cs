using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] TMP_InputField speed;
    [SerializeField] TMP_InputField delaySpawnTime;
    [SerializeField] TMP_InputField distance;

    public GameObject myPrefab;

    public float _speed;
    public float _delaySpawnTime;

    public Vector3 moveToDistance;
    public Vector3 startPos = Vector3.zero;

    bool _spawnCubeOn = false;

    public void Spawn()
    {
        _delaySpawnTime = float.Parse(delaySpawnTime.text);
        _speed = float.Parse(speed.text);
        _delaySpawnTime = float.Parse(delaySpawnTime.text);
        moveToDistance.z = float.Parse(distance.text);
        _spawnCubeOn = true;
        StartCoroutine(Spawner());
    }

    public void StopSpawn()
    {
        _spawnCubeOn = false;
    }

    private IEnumerator Spawner()
    {
        while (_spawnCubeOn == true)
        {
            yield return new WaitForSeconds(_delaySpawnTime);
            Instantiate(myPrefab, startPos, Quaternion.identity);
        }
    }
}
