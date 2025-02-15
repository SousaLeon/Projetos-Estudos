using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int SpeedX = 5;
    int MultiX;
    public int QuantObject { get; set; } = 60;
    bool BtnPressed;

    Rigidbody2D rig;
    Vector2 pos;

    public static Ball ball;
    void Awake()
    {
        ball = this;
        rig = GetComponent<Rigidbody2D>();
        MultiX = Random.Range(1, 3) == 1 ? 1 : -1;
        BtnPressed = false;
        pos = transform.position;
    }    
    void Update()
    {
        if (!BtnPressed && Input.GetKeyDown(KeyCode.UpArrow) && !GameController.GC.EndGame)
        {
            rig.velocity = new Vector2(SpeedX * MultiX, 3);
            BtnPressed = true;
        }
    }
    void EndMap()
    {
        MultiX = Random.Range(1, 3) == 1 ? 1 : -1;
        transform.position = pos;
        Player.player.transform.position = Player.player.pos;
        BtnPressed = false;
        rig.velocity = Vector2.zero;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(collision.gameObject);
            GameController.GC.HighScore += 50;
            GameController.GC.HighScorePoint.text = GameController.GC.HighScore.ToString();
            GameController.GC.HighScorePointInGame.text = GameController.GC.HighScore.ToString();
            QuantObject--;
        }
        if (collision.gameObject.layer == 7)
        {
            EndMap();
        }
    }
}