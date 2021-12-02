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
        GameObject newbullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;//ƒƒ‚ƒŠ‚ÌêŠ‚ÌŠm•Û(’eA”­¶êŠAp¨§Œä)Œ^‚ğ‘µ‚¦‚é

    }
}
