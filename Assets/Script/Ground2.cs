using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground2 : BaseBackGround
{
    // Start is called before the first frame update
    void Start()
    {
        BackMove(BackTeam.GROUND2);
    }

    // Update is called once per frame
    void Update()
    {
        BackLoop();
    }
}
