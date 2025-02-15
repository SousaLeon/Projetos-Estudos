using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int Speed;
    Rigidbody2D rig;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -4, 4), transform.position.y);
        float movement = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(movement * Speed, rig.velocity.y);
    }
}
