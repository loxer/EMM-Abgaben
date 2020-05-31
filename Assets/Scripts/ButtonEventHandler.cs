using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    Player player;
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInChildren<Player>();

        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vbs.Length; ++i)
        {
            vbs[i].RegisterEventHandler(this);
        }
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
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
