using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwitchARCamera : MonoBehaviour
{

    private bool ARSwitchButton;
  //  public Camera ARCamera;
    public Camera GameCamera;
   // public GameObject World;


    public bool help;
    

    // Start is called before the first frame update
    void Start()
    {
        ARSwitchButton = true;
        ARSwitchMethod();



    }
    public void StopVuforia()
    {/*
        World.transform.parent = null;
        World.GetComponentInChildren<CharacterController>().enabled = true;
        foreach (MeshRenderer Render in World.GetComponentsInChildren<MeshRenderer>())
        {
            Render.enabled = true;
        }
        foreach (MeshCollider collider in World.GetComponentsInChildren<MeshCollider>())
        {
            collider.enabled = true;
        }
        foreach (BoxCollider collider in World.GetComponentsInChildren<BoxCollider>())
        {
            collider.enabled = true;
        }
        GameCamera.enabled = true;// unactive and active only the camera objecto to stay with the 3D follower
                                  //  CameraDevice.Instance.Stop();
        ARCamera.gameObject.SetActive(false); // unactive the ARCameara to avoid the camara 3D plan in te normal view 
            */                                  //  if (help) { Debug.Log("Vuforia se ha detenido " + CameraDevice.Instance.IsActive().ToString()); 
    
     

    }
    public void StartVuforia() {/*
        World.transform.parent = GameObject.Find("Card-Target").transform;
        GameCamera.enabled = false; 
       // CameraDevice.Instance.Init();
       // CameraDevice.Instance.Start();
        ARCamera.gameObject.SetActive(true);
       // if (help) { Debug.Log("Vuforia se ha Iniciado " + CameraDevice.Instance.IsActive().ToString()); }*/
        }
    public void ChangeCamerasGame() {
        Knight_Controller.setCameraPositionControl(GameCamera.GetComponent<CameraPositionControl>());
        Color_Position_Controllers.setCameraPositionControl(GameCamera.GetComponent<CameraPositionControl>());
    }
    public void ChangeCamerasAR()
    {
       //Knight_Controller.setCameraPositionControl(ARCamera.GetComponent<CameraPositionControl>());
       // Color_Position_Controllers.setCameraPositionControl(ARCamera.GetComponent<CameraPositionControl>());
    }
    public void ARDropdownMethod(TMP_Dropdown d)
    {
        if (d.value == 0)
        {
            StopVuforia();
            ChangeCamerasGame();
            ARSwitchButton = false;
        }
       else if (d.value == 1)
        {
            StartVuforia();
            ChangeCamerasAR();
            ARSwitchButton = true;
        }


    }
    public void ARSwitchMethod()
    {
        if (ARSwitchButton)
        {
            StopVuforia();
            ChangeCamerasGame();
            ARSwitchButton = false;
        }
        else if (!ARSwitchButton)
        {
            StartVuforia();
            ChangeCamerasAR();
            ARSwitchButton = true;
        }


    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
