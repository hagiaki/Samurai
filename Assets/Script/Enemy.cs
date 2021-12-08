using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        shotRealTime += Time.deltaTime;
        if (shotRealTime >= shotRate)
        {
            shot(Direction.LEFT);
            shotRealTime = 0;
        }
    }

    private void OnTriggerEnter(Collider other)//“–‚½‚Á‚½uŠÔ‚Ìˆ—
    {
        Shell shell = other.GetComponent<Shell>();
        if (shell == null)
        {
            return;
        }
        if (shell.getTeam() != GetTeam())//©•ª‚ÌTeam‚Å‚Í‚È‚©‚Á‚½ê‡
        {
            Destroy(this.gameObject);
        }
    }
}
