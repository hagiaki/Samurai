using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour//MonoBehaviorÇÃíÜêgÇåpè≥
{
    private float speed = 0.1f;
    public float bulletspeed;
    public bool hit = false;
    public GameObject PlayerObject;

    void Move()
    {
        
    }

    void Shot()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed, 0, 0);
        }
    }
}
