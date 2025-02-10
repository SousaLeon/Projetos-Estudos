
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Player : MonoBehaviour
{
    [SerializeField] int Velocity;

    Rigidbody2D rig;
    
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        if (!GameController.GC.EndGame)
        {
            rig.velocity = new Vector2(rig.velocity.x, Velocity);
            Destroy(gameObject, 3f);
        }            
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.layer)
        {
            case 6:
                Destroy(gameObject);                
                break;
            case 7:
                Destroy(collision.gameObject);
                Destroy(gameObject);
                GameController.GC.EnemyAmount--;
                break;
            case 8:
                Destroy(collision.gameObject);
                Destroy(gameObject);
                GameController.GC.EnemyAmount--;
                break;
            case 9:
                Destroy(collision.gameObject);
                Destroy(gameObject);
                GameController.GC.EnemyAmount--;
                break;
        }
    }
}
