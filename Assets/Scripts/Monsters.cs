using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    private const float MOVE_SPEED = 0.01f;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Game Over");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerPos = player.GetPosition();
        Vector3 monsterPos = transform.position;

        float x = GetSign(playerPos.x-monsterPos.x) * MOVE_SPEED + monsterPos.x;
        float z = GetSign(playerPos.z-monsterPos.z) * MOVE_SPEED + monsterPos.z;

        transform.position = new Vector3(x, monsterPos.y, z);
    }

    float GetSign(float number)
    {
        if(number >= 0)
        {
            return 1f;
        }
        else
        {
            return -1f;
        }
    }


} // Class END