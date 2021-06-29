using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class LeaverPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Platform;
    public float Speed = 5;
    public Transform DestinationSpot;
    public Transform OriginSpot;
    public bool Switch = false;

    void Start()
    {
        
    }
    public void ResetAll() {
        Switch = true;

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.name == "Knight") {
            if (CrossPlatformInputManager.GetButtonDown("Attack"))
            {
                Switch = !Switch;
                Debug.Log("Pegando dentro");
                
            }

        }
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Switch)
        {
            Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, OriginSpot.position, Speed * Time.deltaTime);
        }

        else
        {
            Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, DestinationSpot.position, Speed * Time.deltaTime);

        }
    }
}
