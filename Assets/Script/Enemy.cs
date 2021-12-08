using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseCharacter
{
    private const float shotRate = 0.5f;//固定の値
    private float shotRealTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        team = Team.ENEMY;
    }

    // Update is called once per frame
    void Update()
    {
        shotRealTime += Time.deltaTime;
        if (shotRealTime >= shotRate)
        {
            shot(Direction.LEFT);
            shotRealTime = 0;
        }
    }

    private void OnTriggerEnter(Collider other)//当たった瞬間の処理
    {
        Shell shell = other.GetComponent<Shell>();
        if (shell == null)
        {
            return;
        }
        if (shell.getTeam() != GetTeam())//自分のTeamではなかった場合
        {
            Destroy(this.gameObject);
        }
    }
}
