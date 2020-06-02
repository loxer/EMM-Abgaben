using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed;
    public float smoothRotationSpeed;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 offsetRotated = target.rotation * offset;
        Vector3 desiredPosition = target.position + offsetRotated;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition; // Thx to -> https://www.youtube.com/watch?v=MFQhpwc6cKE&t=391s

        Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
        Quaternion smoothedRotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothRotationSpeed * Time.deltaTime);
        transform.rotation = smoothedRotation;
        
    }

}
