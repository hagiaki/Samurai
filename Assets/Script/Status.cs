using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public float speed = 5.0f;
    public bool hit = false;
    public GameObject PlayerObject;
    protected float power = 1000f;
    public GameObject bullet;
    protected float interval = 1.0f;

    protected void shot()
    {
        GameObject newbullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;//�������̏ꏊ�̊m��(�e�A�����ꏊ�A�p������)�^�𑵂���

    }
}
