using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color_Position_Controllers : MonoBehaviour
{
    private Image Image_Color;
    public static CameraPositionControl Camera;
    // Start is called before the first frame update
    void Start()
    {
        Image_Color = GetComponent<Image>();
    }
    public static void setCameraPositionControl(CameraPositionControl camera)
    {
        Camera = camera;
    }

    private void ChangeColorWithPosition() {

        if (Camera.Get_Camera_Position() == CameraPositionControl.FRONT_POSITION)
        {
            Image_Color.color = new Color(0.20f, 0.40f, 0.70f);
        }
        else if (Camera.Get_Camera_Position() == CameraPositionControl.BEHIND_POSITION)
        {
            Image_Color.color = new Color(0.70f, 0.50f, 0.20f);
        }
        else if (Camera.Get_Camera_Position() == CameraPositionControl.LEFT_POSITION)
        {
            Image_Color.color = new Color(0.10f, 0.90f, 0.50f);
        }
        else if (Camera.Get_Camera_Position() == CameraPositionControl.RIGHT_POSITION)
        {
            Image_Color.color = new Color(0.51f, 0.80f, 0.13f);

        }
        else { Debug.Log("Sin color"); }

    }
    // Update is called once per frame
    void Update()
    {
        ChangeColorWithPosition();


    }
}
