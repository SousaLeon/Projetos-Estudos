using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Detect_Collider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.layer)
        {
            case 7:
                Red_Enemy.RE.Position.y -= 0.4f;
                Blue_Enemy.BE.Position.y -= 0.4f;
                Yellow_Enemy.YE.Position.y -= 0.4f;

                Red_Enemy.RE.Velocity *= -1;
                Blue_Enemy.BE.Velocity *= -1;
                Yellow_Enemy.YE.Velocity *= -1;

                Spawn_Bullet_Enemy.SBE.Pos.y -= 0.4f;
                break;
            case 8:
                Red_Enemy.RE.Position.y -= 0.4f;
                Blue_Enemy.BE.Position.y -= 0.4f;
                Yellow_Enemy.YE.Position.y -= 0.4f;

                Red_Enemy.RE.Velocity *= -1;
                Blue_Enemy.BE.Velocity *= -1;
                Yellow_Enemy.YE.Velocity *= -1;
                break;
            case 9:
                Red_Enemy.RE.Position.y -= 0.4f;
                Blue_Enemy.BE.Position.y -= 0.4f;
                Yellow_Enemy.YE.Position.y -= 0.4f;

                Red_Enemy.RE.Velocity *= -1;
                Blue_Enemy.BE.Velocity *= -1;
                Yellow_Enemy.YE.Velocity *= -1;
                break;
        }
    }
}
