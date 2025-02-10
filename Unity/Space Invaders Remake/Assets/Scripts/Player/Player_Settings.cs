using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Player_Settings : MonoBehaviour
{
    float TimeCount;
    public int Health { get; set; } = 3;
    [SerializeField] int Velocity;

    [SerializeField] GameObject Bullet;
    [SerializeField] Transform Bullet_Spawn;
    Rigidbody2D rig;

    public static Player_Settings Player;
    void Awake()
    {
        Player = this;
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Death();
        if (!GameController.GC.EndGame)
        {
            TimeCount += Time.deltaTime;
            if (TimeCount >= 1f && Input.GetMouseButtonDown(0))
            {
                Instantiate(Bullet, Bullet_Spawn.position, Bullet_Spawn.rotation);
                TimeCount = 0f;
            }
        }              
    }

    void FixedUpdate()
    {
        if (!GameController.GC.EndGame)
        {
            float movement = Input.GetAxis("Horizontal");
            rig.velocity = new Vector2(movement * Velocity, rig.velocity.y);
        }
        
    }

    void Death()
    {
        if (Health <= 0)
        {
            Health = 0;
            Destroy(gameObject);
            GameController.GC.EndGameScreen.SetActive(true);
            GameController.GC.Loser.SetActive(true);
            GameController.GC.EndGame = true;
        }
    }
}
