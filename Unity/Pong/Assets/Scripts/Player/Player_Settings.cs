using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Settings : MonoBehaviour
{
    public float Velocity;

    Rigidbody2D rig;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        if (!UI_Controller._Controller.EndGame)
        {
            transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -3.2f, 3.2f));

            float movVertical = Input.GetAxis("Vertical");
            rig.velocity = new Vector2(rig.velocity.x, movVertical * Velocity);
        }

        if (UI_Controller._Controller.EndGame)
        {
            rig.velocity = Vector2.zero;
            transform.position = new Vector2(-7, 0);
        }
    }
}
