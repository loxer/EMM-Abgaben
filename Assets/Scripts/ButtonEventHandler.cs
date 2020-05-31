using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    Player player;
    public float moveSpeed = 10f;

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


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        switch(vb.VirtualButtonName)
        {
            case "btn1":
                float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
                player.transform.Translate(0, 0, z);
                Debug.Log("btn pressed");
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
