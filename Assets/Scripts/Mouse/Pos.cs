using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos : MonoBehaviour
{
    public Rigidbody2D rb;
    public float offY;
    public float offX;
    public static bool started;
    public GameObject Chick;
    // Update is called once per frame
    private void Start()
    {
        started = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !started)
        {
            started = true;
            Chick.SetActive(true);
            Chick.GetComponent<DeathScript>().SetPos();
            
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector2 pos = ray.GetPoint(1);
        pos.x += offX;
        pos.y += offY;
        MovePosition(pos);
    }
    void MovePosition(Vector3 position)
    {
        Vector3 oldVel = rb.velocity;
        //Get the position offset
        Vector3 delta = position - transform.position;
        //Get the speed required to reach it next frame
        Vector3 vel = delta / Time.fixedDeltaTime;

        rb.velocity = vel;
        }
}
