using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBackGround : MonoBehaviour
{


    
    [SerializeField]
    protected float startLine;//開始位置
    [SerializeField]
    protected float deadline;//ループ位置
    [SerializeField]
    protected float y;
    [SerializeField]
    protected float z;

    private float backSpeed;//背景スピード


    public enum BackTeam{
        FRONT,
        MIDDLE,
        BACK,
        GROUND1,
        GROUND2
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
                startLine = 54.0f;
                deadline = -58.5f;
                y = -5.5f;
                z = 4.0f;
                backSpeed = -0.125f;
                break;
            case BackTeam.MIDDLE:
                startLine = 105.0f;
                deadline = -97.5f;
                y = -3.14f;
                z = 8.0f;
                backSpeed = -0.1f;
                break;
            case BackTeam.BACK:
                startLine = 124.0f;
                deadline = -124.0f;
                y = 0.0f;
                z = 12.5f;
                backSpeed = -0.05f;
                break;
            case BackTeam.GROUND1:
                startLine = 0.0f;
                deadline = -2000.0f;
                y = -7.5f;
                z = 0.0f;
                backSpeed = -0.125f;
                break;
            case BackTeam.GROUND2:
                startLine = 2000.0f;
                deadline = 0.0f;
                y = -7.5f;
                z = 0.0f;
                backSpeed = -0.125f;
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
