using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int Speed;
    Rigidbody2D rig;
    public Vector2 pos { get; private set; }
    public static Player player;

    void Awake()
    {
        player = this;
        rig = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }
    void FixedUpdate()
    {
        if (!GameController.GC.EndGame)
        {
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, -4, 4), transform.position.y);
            float movement = Input.GetAxis("Horizontal");
            rig.velocity = new Vector2(movement * Speed, rig.velocity.y);
        }        
    }
}
