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
    protected float _length = 1;
    protected float amplitude = 5.0f;
    protected int period = 3;
    public int life = 3;
    public float lifeTime = 64.0f;

    [SerializeField]//public�łȂ��Ă�inspecter�ɕ\���ł���
    protected int attack = 5;

    public enum Direction{
        RIGHT,
        LEFT
    }
    public enum Team{
        PLAYER,
        ENEMY
    }

    public enum Height{
        UP,
        DOWN
    }

    protected void shot(Direction direction)
    {
        GameObject newbullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;//�������̏ꏊ�̊m��(�e�A�����ꏊ�A�p������)�^�𑵂���
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

    public void OnTriggerEnter(Collider other)//���������u�Ԃ̏���
    {
        Shell shell = other.GetComponent<Shell>();
        if (shell == null)
        {
            return;
        }
        if (shell.getTeam() != GetTeam())//������Team�ł͂Ȃ������ꍇ
        {
            life -= shell.getAttack();
            if (life <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
