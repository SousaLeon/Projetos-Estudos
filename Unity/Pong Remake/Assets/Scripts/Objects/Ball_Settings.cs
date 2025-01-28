using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball_Settings : MonoBehaviour
{
    float Velocity = 6;
    float OriginalVelocity;
    float timecount;
    int xValue;
    int yValue;    
    bool Respawn;

    Rigidbody2D rig;
    Vector2 OriginalPosition;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        OriginalPosition = transform.position;
        OriginalVelocity = Velocity;
    }

    void Start()
    {
        BallMovement();
    }
    private void Update()
    {
        if (Respawn){RespawnBall();}
    }
    void BallMovement()
    {
        if (UI_Controller._Controller.EndGame)
        {
            rig.velocity = Vector2.zero;
        }
        else
        {
            xValue = Random.Range(2, 4) == 2 ? 1 : -1;
            yValue = Random.Range(-1, 2);
            rig.velocity = new Vector2(Velocity * xValue, Velocity * yValue);
        }        
    }  
    void RespawnBall()
    {
        transform.position = OriginalPosition;
        Velocity = 0;
        timecount += Time.deltaTime;

        if (timecount >= 1f)
        {
            Velocity = OriginalVelocity;
            BallMovement();            
            Respawn = false;
            timecount = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.layer)
        {
            case 6:
                UI_Controller._Controller._Ponto_P1++;
                Respawn = true;
                break;

            case 7:
                UI_Controller._Controller._Ponto_P2++;
                Respawn = true;
                break;
        }
    }
}
