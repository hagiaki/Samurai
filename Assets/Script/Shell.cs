using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BaseCharacter;

public class Shell : MonoBehaviour
{
    public float power = 1000f;
    public GameObject bullet;
    public Transform spawnpoint;
    public float lifeTime = 1.0f;
    bool isAddForce = false;
    private Vector3 direction;
    protected BaseCharacter.Team mTeam;

    // Update is called once per frame
    void Update()
    {
        if (!isAddForce)
        {
            this.GetComponent<Rigidbody>().AddForce(direction * power);//コンポーネントを参照、瞬間的な力を加える
            isAddForce = true;
        }
        lifeTime -= 1.0f * Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(bullet);
        }
    }
    
    public void setDirection(Vector3 dir)
    {
        direction = dir;

    }

    public void setTeam(Team team)
    {
        mTeam = team;
    }

    public Team getTeam()
    {
        return mTeam;
    }
}
/*newbullet.GetComponent<Rigidbody>().AddForce(Vector3.right * power);
        Destroy(newbullet, 1.0f);*/
