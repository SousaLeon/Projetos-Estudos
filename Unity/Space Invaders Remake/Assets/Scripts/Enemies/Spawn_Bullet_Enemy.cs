using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Bullet_Enemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] List<Transform> bullets = new List<Transform>();
    int Number_Spawn;
    float TimeCount;

    public Vector2 Pos;

    public static Spawn_Bullet_Enemy SBE;
    void Awake() { SBE = this; Pos = transform.position; }

    void Update()
    {
        if (!GameController.GC.EndGame)
        {
            TimeCount += Time.deltaTime;
            if (TimeCount >= 1f)
            {
                transform.position = Pos;
                Number_Spawn = Random.Range(0, 17);

                switch (Number_Spawn)
                {
                    case 0:
                        Instantiate(bullet, bullets[0].position, bullets[0].rotation);
                        break;
                    case 1:
                        Instantiate(bullet, bullets[1].position, bullets[1].rotation);
                        break;
                    case 2:
                        Instantiate(bullet, bullets[2].position, bullets[2].rotation);
                        break;
                    case 3:
                        Instantiate(bullet, bullets[3].position, bullets[3].rotation);
                        break;
                    case 4:
                        Instantiate(bullet, bullets[4].position, bullets[4].rotation);
                        break;
                    case 5:
                        Instantiate(bullet, bullets[5].position, bullets[5].rotation);
                        break;
                    case 6:
                        Instantiate(bullet, bullets[6].position, bullets[6].rotation);
                        break;
                    case 7:
                        Instantiate(bullet, bullets[7].position, bullets[7].rotation);
                        break;
                    case 8:
                        Instantiate(bullet, bullets[8].position, bullets[8].rotation);
                        break;
                    case 9:
                        Instantiate(bullet, bullets[9].position, bullets[9].rotation);
                        break;
                    case 10:
                        Instantiate(bullet, bullets[10].position, bullets[10].rotation);
                        break;
                    case 11:
                        Instantiate(bullet, bullets[11].position, bullets[11].rotation);
                        break;
                    case 12:
                        Instantiate(bullet, bullets[12].position, bullets[12].rotation);
                        break;
                    case 13:
                        Instantiate(bullet, bullets[13].position, bullets[13].rotation);
                        break;
                    case 14:
                        Instantiate(bullet, bullets[14].position, bullets[14].rotation);
                        break;
                    case 15:
                        Instantiate(bullet, bullets[15].position, bullets[15].rotation);
                        break;
                    case 16:
                        Instantiate(bullet, bullets[16].position, bullets[16].rotation);
                        break;
                }
                TimeCount = 0;
            }
        }        
    }
}
