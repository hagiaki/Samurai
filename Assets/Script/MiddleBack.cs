using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleBack : BaseBackGround
{
    // Start is called before the first frame update
    void Start()
    {
        BackMove(BackTeam.MIDDLE);
    }

    // Update is called once per frame
    void Update()
    {
        BackLoop();
    }
}
