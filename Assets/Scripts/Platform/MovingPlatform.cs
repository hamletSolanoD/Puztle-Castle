using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform DestinationSpot;
    public Transform OriginSpot;
    public float Speed;
    public bool Switch;
    private void Start()
    {
        Switch = false;
    
    }
    private void setSwitch() {


    }

    void Update()
    {
        setSwitch();
        if (transform.position == DestinationSpot.position)
        {
            Switch = true;
         
        }

        if (transform.position == OriginSpot.position)
        {
            Switch = false;
          
        }

        if (Switch)
        {

            transform.position = Vector3.MoveTowards(transform.position, OriginSpot.position, Speed * Time.deltaTime);
          
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, Speed * Time.deltaTime);
        
        }
   }
}
