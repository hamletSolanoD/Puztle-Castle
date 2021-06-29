using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionControl : MonoBehaviour
{

    public const int  FRONT_POSITION   =  1;
    public const int  BEHIND_POSITION  = -1;
    public const int  LEFT_POSITION    = -2;
    public const int  RIGHT_POSITION   =  2;
    public bool Static = false;
    public int StaticPosition = 0;
    public bool Help = false;

    public int Get_Camera_Position()
    {
     
            float Position = transform.eulerAngles.y;
        // Front
        if (Static) {
            return StaticPosition;
        }
        else if (Position >= 0 && Position <= 45 || Position >= 315 && Position <= 360)
        {
            if (Help) { Debug.Log("Front"); }
            return FRONT_POSITION;
        }
        // Behind
        else if (Position >= 135 && Position <= 225)
        {
            if (Help) { Debug.Log("Behind"); }
            return BEHIND_POSITION;
        }
        // Right
        else if (Position >= 45 && Position <= 135)
        {
            if (Help) { Debug.Log("Right"); }
            return RIGHT_POSITION;
        }
        // Left
        else if (Position >= 225 && Position <= 315)
        {
            if (Help) { Debug.Log("Left"); }
            return LEFT_POSITION;
        }
        else { if (Help) { Debug.Log("No Detectado"); } }
            return 0;
        }

     
  

  
    
    void Update()
    {
        Get_Camera_Position();
    }
}
