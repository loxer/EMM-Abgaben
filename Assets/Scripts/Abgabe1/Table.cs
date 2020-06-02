using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotate = Mathf.Sin(Time.time) * 360;
        transform.rotation = Quaternion.Euler(0, rotate, 0);
    }
}
