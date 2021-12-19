using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground1 : BaseBackGround
{
    // Start is called before the first frame update
    void Start()
    {
        BackMove(BackTeam.GROUND1);
    }

    // Update is called once per frame
    void Update()
    {
        BackLoop();
    }
}
