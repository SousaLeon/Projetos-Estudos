using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Settings : MonoBehaviour
{
    float Velocity = 6;

    Rigidbody2D rig;

    Vector2 OriginalPosition;

    float OriginalVelocity;
    bool Respawn;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        BallMovement();
        OriginalPosition = transform.position;
        OriginalVelocity = Velocity;     
    }
    private void Update()
    {
        if (Respawn)
        {
            RespawnBall();
        }
    }

    void BallMovement()
    {
        if (Stadium_Field_UI.SF_UI.EndGame)
        {
            rig.velocity = Vector2.zero;
        }
        else
        {
            rig.velocity = new Vector2(Velocity, Velocity);
        }        
    }

    float timecount;
    void RespawnBall()
    {
        transform.position = OriginalPosition;
        Velocity = 0;
        timecount += Time.deltaTime;

        if (timecount >= 1f)
        {
            Velocity = OriginalVelocity;
            BallMovement();
            timecount = 0;
            Respawn = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //PLAYER2
        if (collision.gameObject.layer == 7)
        {
            Stadium_Field_UI.SF_UI._Ponto_P2++;
            Respawn = true;
        }
        //PLAYER1
        if (collision.gameObject.layer == 6)
        {
            Stadium_Field_UI.SF_UI._Ponto_P1++;
            Respawn = true;
        }
    }

}
