using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FinalBallInteraction : MonoBehaviour
{
    // Start is called before the first frame update
        public Animator AnimatorController;
    void Start()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.name == "Knight")
        {
            if (CrossPlatformInputManager.GetButtonDown("Attack"))
            {
                AnimatorController.SetBool("Active", true);

            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
