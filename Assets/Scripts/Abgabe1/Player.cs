using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float MOVE_SPEED = 10f;
    private const float ROTATION_SPEED = 300f;
    private int score = 0;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
    }

    private void FixedUpdate()
    {

        float y = Input.GetAxis("Horizontal") * Time.deltaTime * ROTATION_SPEED;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * MOVE_SPEED;
        
        transform.Rotate(0, y, 0);
        transform.Translate(0, 0, z);

    }

        void OnCollisionEnter(Collision collisionInfo)
    {        
        if (collisionInfo.gameObject.tag == "Collectable")
        {
            Destroy(collisionInfo.gameObject);
            score++;
            Debug.Log(score);
        }
    }

    public Vector3 GetPosition()
    {
        return pos;
    }
}
