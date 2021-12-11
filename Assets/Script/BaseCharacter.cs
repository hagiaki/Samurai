using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
    public float speed = 5.0f;
    public bool hit = false;
    public GameObject PlayerObject;
    protected float power = 1000f;
    public GameObject bullet;
    protected Team team;
    public int life = 3;
    protected int damage = 5;

    public enum Direction{
        RIGHT,
        LEFT
    }
    public enum Team{
        PLAYER,
        ENEMY
    }

    protected void shot(Direction direction)
    {
        GameObject newbullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;//メモリの場所の確保(弾、発生場所、姿勢制御)型を揃える
        Shell shell = newbullet.GetComponent<Shell>();
        shell.setTeam(GetTeam());

        switch(direction){
            case Direction.RIGHT:
                shell.setDirection(Vector3.right);
                break;
            case Direction.LEFT:
                shell.setDirection(Vector3.left);
                break;
        }
    }

    public Team GetTeam()
    {
        return team;
    }

    public void OnTriggerEnter(Collider other)//当たった瞬間の処理
    {
        Shell shell = other.GetComponent<Shell>();
        if (shell == null)
        {
            return;
        }
        if (shell.getTeam() != GetTeam())//自分のTeamではなかった場合
        {
            life -= damage;
            if (life <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
