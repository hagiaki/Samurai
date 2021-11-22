using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public float power = 1000f;
    public GameObject bullet;
    public Transform spawnpoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shot();
        }
    }

    void shot()
    {
        GameObject newbullet = Instantiate(bullet, spawnpoint.position, Quaternion.identity) as GameObject;
        newbullet.GetComponent<Rigidbody>().AddForce(Vector3.right * power);
        Destroy(newbullet, 1.0f);
    }
}
