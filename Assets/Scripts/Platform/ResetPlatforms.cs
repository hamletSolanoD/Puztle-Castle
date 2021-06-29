using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ResetPlatforms : MonoBehaviour
{
 
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.name == "Knight") {
            if (CrossPlatformInputManager.GetButtonDown("Attack"))
            {

             foreach(LeaverPlatform i in GameObject.FindObjectsOfType<LeaverPlatform>()){
                    i.ResetAll();
                   
                }

            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
