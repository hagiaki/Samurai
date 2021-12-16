using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontBack : BaseBackGround
{
    // Start is called before the first frame update
    void Start()
    {
         BackMove(BackTeam.FRONT);
    }

    // Update is called once per frame
    void Update()
    {
        BackLoop();
    }
}
