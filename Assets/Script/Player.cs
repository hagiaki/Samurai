using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour//MonoBehaviorÇÃíÜêgÇåpè≥
{
    private float speed = 5.0f;
    public float bulletspeed;
    public bool hit = false;
    public GameObject PlayerObject;
    public float power = 1000f;
    public GameObject bullet;
    public Transform spawnpoint;

    void Move()
    {
        
    }

    void shot()
    {
        GameObject newbullet = Instantiate(bullet, spawnpoint.position, Quaternion.identity) as GameObject;
        newbullet.GetComponent<Rigidbody>().AddForce(Vector3.right * power);
        Destroy(newbullet, 1.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movedirection = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movedirection.y = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movedirection.y = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movedirection.x = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movedirection.x = -1;
        }
        movedirection.Normalize();
        movedirection *= speed * Time.deltaTime;
        transform.position += movedirection;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shot();
        }
    }
}
