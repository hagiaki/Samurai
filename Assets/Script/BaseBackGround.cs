using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBackGround : MonoBehaviour
{


    private float backSpeed = -0.05f;//背景スピード
    [SerializeField]
    protected float startLine;//開始位置
    [SerializeField]
    protected float deadline;//ループ位置
    [SerializeField]
    protected float y;
    [SerializeField]
    protected float z;


    public enum BackTeam{
        FRONT,
        MIDDLE,
        BACK
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void BackMove(BackTeam backTeam)
    {
        switch (backTeam)
        {
            case BackTeam.FRONT:
                startLine = 6.5f;
                deadline = -10.5f;
                y = -1.0f;
                z = -11.0f;
                break;
            case BackTeam.MIDDLE:
                startLine = 48.0f;
                deadline = -50.0f;
                y = 0.0f;
                z = 3.0f;
                break;
            case BackTeam.BACK:
                startLine = 124.0f;
                deadline = -124.0f;
                y = 0.0f;
                z = 12.5f;
                break;
        }
    }

    public void BackLoop()
    {
        transform.Translate(backSpeed, 0, 0);
        if (transform.position.x <= deadline)
        {
            transform.position = new Vector3(startLine, y, z);
        }
    }
}
