using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Enemy : MonoBehaviour
{
    [SerializeField] float Velocity;
    Rigidbody2D rig;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Destroy(gameObject, 3f);
    }
    void FixedUpdate()
    {
        rig.velocity = new Vector2(rig.velocity.x, -Velocity);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            Player_Settings.Player.Health--;
        }
    }
}
