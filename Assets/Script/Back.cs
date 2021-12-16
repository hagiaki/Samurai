using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : BaseBackGround
{
    // Start is called before the first frame update
    void Start()
    {
        BackMove(BackTeam.BACK);
    }

    // Update is called once per frame
    void Update()
    {
        BackLoop();
    }
}
