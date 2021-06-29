using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RayCubeFollower : MonoBehaviour
{

    private bool CenteredKnight;
    public GameObject CameraGame;
    public float velocityX;
    public float velocityY;
    public float acelerationX;
    public float acelerationY;
    public bool FrontalView = false;
    private float firstVelocityX;
    private float firstVelocityY;

    void Start() {


        firstVelocityX = velocityX;
        firstVelocityY = velocityY;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Knight")
        {

            CenteredKnight = false;
            Debug.Log("Is not  Centered");
        }
    }
        
    

    private void MoveCamera() {
        if (!FrontalView)
        {
            if (!CenteredKnight)
            {
                velocityX += acelerationX * Time.deltaTime;
                CameraGame.transform.eulerAngles = new Vector3(0, CameraGame.transform.eulerAngles.y + ((RayCubeFolloweSides.getSide()) * velocityX), 0);
            }
        }
        else if (FrontalView) {

            if (RayCubeFolloweSides.getSide() == -1 || RayCubeFolloweSides.getSide() == 1) {
                velocityX += acelerationX * Time.deltaTime;
                    CameraGame.transform.eulerAngles = new Vector3(0, CameraGame.transform.eulerAngles.y + (-1 * (RayCubeFolloweSides.getSide()) * velocityX), 0);
                }
            if (RayCubeFolloweSides.getSide() == 2 || RayCubeFolloweSides.getSide() == -2)
            {
                velocityY += acelerationY * Time.deltaTime;
                CameraGame.transform.position = new Vector3(CameraGame.transform.position.x, CameraGame.transform.position.y + ((RayCubeFolloweSides.getSide()/(2)) * velocityY), CameraGame.transform.position.z);
            }
            else if (RayCubeFolloweSides.getSide() == 5   || RayCubeFolloweSides.getSide() == 4)
            {
                Debug.Log("centered");
            }
            else if (CenteredKnight)
            {     
                CameraGame.transform.eulerAngles = new Vector3(0, 0, 0);
            }

        }
           

        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Knight")
        {
          CenteredKnight = true;
                velocityX = firstVelocityX;
                Debug.Log("Is  Centered");    
           
        }
    }

    public bool GetCenteredKnight() {
        return CenteredKnight;
    }
    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }
}
