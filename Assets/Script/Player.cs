using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseCharacter//MonoBehaviorÇÃíÜêgÇåpè≥
{
    /*public float speed = 5.0f;
    public float bulletspeed;
    public bool hit = false;
    public GameObject PlayerObject;
    public float power = 1000f;
    public GameObject bullet;*/

    // Start is called before the first frame update
    void Start()
    {
        team = Team.PLAYER;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movedirection = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movedirection.y = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movedirection.y = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movedirection.x = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movedirection.x = -1;
        }
        movedirection.Normalize();
        movedirection *= speed * Time.deltaTime;
        transform.position += movedirection;

        if (Input.GetKeyDown(KeyCode.Space))
        {
           shot(Direction.RIGHT);
        }
    }

    /*private void OnTriggerEnter(Collider other)//ìñÇΩÇ¡ÇΩèuä‘ÇÃèàóù
    { 

        Shell shell = other.GetComponent<Shell>();
        if (shell == null)
        {
            return;
        }
        if (shell.getTeam() != GetTeam())//é©ï™ÇÃTeamÇ≈ÇÕÇ»Ç©Ç¡ÇΩèÍçá
        {
            life -= 1;
            if (life <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }*/
}
