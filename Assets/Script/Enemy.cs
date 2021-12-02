using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Status
{
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("update", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        shot();
    }
}
