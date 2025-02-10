using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Enemy : MonoBehaviour
{
    float TimeCount;
    public Vector2 Position;
    public float Velocity { get; set; } = 0.3f;

    public static Red_Enemy RE;
    void Awake()
    {
        RE = this;
        Position = transform.position;
    }

    void Update()
    {
        if (!GameController.GC.EndGame)
        {
            TimeCount += Time.deltaTime;

            if (TimeCount >= 1f)
            {
                Position.x += Velocity;
                transform.position = Position;
                TimeCount = 0f;
            }
        }        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
