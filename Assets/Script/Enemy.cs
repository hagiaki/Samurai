using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Enemy : BaseCharacter
{
    private const float shotRate = 0.5f;//ŒÅ’è‚Ì’l
    private float shotRealTime = 0;
    

    

    // Start is called before the first frame update
    void Start()
    {
        team = Team.ENEMY;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);
        shotRealTime += Time.deltaTime;
        if (shotRealTime >= shotRate)
        {
            shot(Direction.LEFT);
            shotRealTime = 0;
        }
        moveDirection.x = -1;
        moveDirection.y = 1;
        moveDirection.Normalize();
        transform.position += moveDirection * speed * Time.deltaTime;
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    
}
