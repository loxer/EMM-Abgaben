using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{    
    Player player;
    public float moveSpeed = 10f;
    public float rotationSpeed = 300f;
    private bool goForward = false;
    private bool goBackward = false;
    private bool rotateLeft = false;
    private bool rotateRight = false;

    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();

        player = GetComponentInChildren<Player>();
        
        for(int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
    }

    void FixedUpdate()
    {
        if(goForward)
        {
            Debug.Log("goForward");
            float z = Time.deltaTime * moveSpeed;
            player.transform.Translate(0, 0, z);
        }

        if(goBackward)
        {
            Debug.Log("goBackward");
            float z = Time.deltaTime * moveSpeed;
            player.transform.Translate(0, 0, -z);
        }

        if(rotateLeft)
        {
            Debug.Log("rotateLeft");
            float y = Time.deltaTime * rotationSpeed;
            player.transform.Rotate(0, y, 0);
        }

        if(rotateRight)
        {
            Debug.Log("rotateRight");
            float y = Time.deltaTime * rotationSpeed;
            player.transform.Rotate(0, -y, 0);
        }
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch(vb.VirtualButtonName)
        {
            case "goForward":
                goForward = true;
                break;
            case "goBackward":
                goBackward = true;
                break;
            case "rotateLeft":
                rotateLeft = true;
                break;
            case "rotateRight":
                rotateRight = true;
                break;
        }

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch(vb.VirtualButtonName)
        {
            case "goForward":
                goForward = false;
                break;
            case "goBackward":
                goBackward = false;
                break;
            case "rotateLeft":
                rotateLeft = false;
                break;
            case "rotateRight":
                rotateRight = false;
                break;
        }
    }

}
