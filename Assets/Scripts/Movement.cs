using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CubeSpawner cubeSpawner;

    private void Start()
    {
        cubeSpawner = GameObject.Find("CubeSpawner").GetComponent<CubeSpawner>();
    }

    void Update()
    {
        var step = cubeSpawner._speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(this.gameObject.transform.position, cubeSpawner.moveToDistance, step);
        if(this.gameObject.transform.position == cubeSpawner.moveToDistance)
        {
            Destroy(this.gameObject);
        }
    }
}
