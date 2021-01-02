using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{

    public GameObject Spoon;
    public GameObject dscreen;
    public GameObject wScreen;
    public GameObject mov;
    public ParticleSystem Particle;
    public Vector2 poss;
    private bool check = true;
    
    void Update()
    {
        if(transform.position.y <= -5.5f)
        {
            Kill();
        }
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Knife"))
        {
            Kill();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pot"))
        {
            Won();
        }
        
    }
    void Kill()
    {
        if (check)
        {
            dscreen.SetActive(true);
            Spoon.SetActive(false);
            mov.GetComponent<MoveLeft>().enabled = false;
            Particle.Play();
            Pos.started = false;
        }
       
    }
    void Won()
    {
        if (check)
        {
            wScreen.SetActive(true);
            Spoon.SetActive(false);
            mov.GetComponent<MoveLeft>().speed = 3;
            check = false;

        }
       
        
    }
    public void SetPos()
    {
        poss = Spoon.transform.position;
        poss.y += 5;
        transform.position = poss;
    }
}
