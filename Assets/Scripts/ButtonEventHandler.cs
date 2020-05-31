using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{    
    Player player;
    public float moveSpeed = 10f;
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
            Debug.Log("ongoing");
            float z = Time.deltaTime * moveSpeed;
            player.transform.Translate(0, 0, z);
        }

        if(goBackward)
        {

        }

        if(rotateLeft)
        {

        }

        if(rotateRight)
        {

        }
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        switch(vb.VirtualButtonName)
        {
            case "btn1":                
                Debug.Log("btn pressed");
                goForward = true;
                break;
            case "btn2":
                // Do something
                break;
        }

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

}
