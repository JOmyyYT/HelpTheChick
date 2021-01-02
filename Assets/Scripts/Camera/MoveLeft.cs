using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;

    private void FixedUpdate()
    {
        if (Pos.started)
        {
            transform.Translate(new Vector2(1, 0) * speed * Time.fixedDeltaTime);
        }
        
    }
}
