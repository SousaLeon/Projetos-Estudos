using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Settings : MonoBehaviour
{
    public float Velocity;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        if (!Stadium_Field_UI.SF_UI.EndGame)
        {
            transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -3.2f, 3.2f));

            float movVertical = Input.GetAxis("Vertical_2");
            rig.velocity = new Vector2(rig.velocity.x, movVertical * Velocity);
        }

        if (Stadium_Field_UI.SF_UI.EndGame)
        {
            rig.velocity = Vector2.zero;
            transform.position = new Vector2(7, 0);
        }
    }
}
