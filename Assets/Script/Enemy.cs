using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class Enemy : BaseCharacter
{
    private const float shotRate = 0.5f;//ŒÅ’è‚Ì’l
    private float shotRealTime = 0;

    public enum TYPE
    {
        UP,
        DOWN
    }

    [SerializeField]
    private TYPE mType;


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
        switch (mType)
        {
            case TYPE.UP:
                moveDirection.x = -1;
                moveDirection.y = 1;
                break;
            case TYPE.DOWN:
                moveDirection.x = -1;
                moveDirection.y = -1;
                break;
        }
        //moveDirection.x = -1;
        //moveDirection.y = 1;
        moveDirection.Normalize();
        //mType = getType();
        transform.position += moveDirection * speed * Time.deltaTime;
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
    public void setType(TYPE type)
    {
        mType = type;
    }

    public TYPE getType()
    {
        return mType;
    }
    
}
