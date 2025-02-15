using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int SpeedX = 3;
    int MultiX;
    bool BtnPressed;

    Rigidbody2D rig;
    Vector2 pos;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        MultiX = Random.Range(1, 3) == 1 ? 1 : -1;
        BtnPressed = false;
        pos = transform.position;
    }    
    void Update()
    {
        if (!BtnPressed && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rig.velocity = new Vector2(SpeedX * MultiX, 3);
            BtnPressed = true;
        }     
    }
    void EndMap()
    {
        transform.position = pos;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == 7)
        {
            EndMap();
        }
    }
}
