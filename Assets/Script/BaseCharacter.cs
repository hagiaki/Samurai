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
    protected int life = 3;

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
        GameObject newbullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;//ƒƒ‚ƒŠ‚ÌêŠ‚ÌŠm•Û(’eA”­¶êŠAp¨§Œä)Œ^‚ğ‘µ‚¦‚é
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
}
