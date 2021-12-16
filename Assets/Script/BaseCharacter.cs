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

    [SerializeField]//public‚Å‚È‚­‚Ä‚àinspecter‚É•\¦‚Å‚«‚é
    protected int attack = 5;

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
        shell.setAttack(attack);

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

    public void OnTriggerEnter(Collider other)//“–‚½‚Á‚½uŠÔ‚Ìˆ—
    {
        Shell shell = other.GetComponent<Shell>();
        if (shell == null)
        {
            return;
        }
        if (shell.getTeam() != GetTeam())//©•ª‚ÌTeam‚Å‚Í‚È‚©‚Á‚½ê‡
        {
            life -= shell.getAttack();
            if (life <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
