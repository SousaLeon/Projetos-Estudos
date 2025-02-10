using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Protected : MonoBehaviour
{
    private int Life = 20;

    void Update()
    {
        if (Life <= 0)
        {
            Life = 0;
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            Life -= 5;
        }
        if (collision.gameObject.layer == 12)
        {
            Life -= 2;
        }
    }
}
