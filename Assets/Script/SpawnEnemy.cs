using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private const float spawnRate = 2.0f;
    private float spawnRealTime = 0;
    public GameObject enemy;
    public float dx = 17;
    private float dy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnRealTime += Time.deltaTime;
        if (spawnRealTime >= spawnRate)
        {
            spawnNewEnemy();
            spawnRealTime = 0;
        }
    }

    void spawnNewEnemy()
    {
        dy = Random.Range(-4.0f, 6.0f);
        GameObject newenemy = Instantiate(enemy, new Vector3(dx,dy,0), Quaternion.identity);
    }
}
