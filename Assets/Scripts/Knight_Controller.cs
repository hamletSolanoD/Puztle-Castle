using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Knight_Controller : MonoBehaviour
{
    public float WalkSpeed = 7f;
    public float Gravity = 9.81f;
    public float JumpForce = 12f;
    public bool Help = false;
    public Joystick joystick;
    public static CameraPositionControl Camera;
    private float YSpeed;
    private Animator AnimatorController;
    private CharacterController Controller;


    private void Start()
    {

        Controller = GetComponent<CharacterController>();
        AnimatorController = GetComponentInChildren<Animator>();

    }
    public static void setCameraPositionControl(CameraPositionControl camera)
    {
        Camera = camera;
    }

    void Update()
    {
        {


            // Jump 
            if (!Controller.isGrounded)
            {
                YSpeed -= Gravity * Time.deltaTime;
                AnimatorController.SetBool("Jump", true);

            }
            else
            {
                AnimatorController.SetBool("Jump", false);
                if (CrossPlatformInputManager.GetButtonDown("Jump"))
                {
                    YSpeed = JumpForce;

                }
            }
            if (CrossPlatformInputManager.GetButtonDown("Attack"))
            {

                AnimatorController.SetBool("Attack", true);
            }
            else
            {

                AnimatorController.SetBool("Attack", false);
            }


            float y = 0; //crosplatform y
            float x = 0;//crossplatform x
                        /// set Controlls color and position value to avoid incorrect movments
                        /// 

            switch (Camera.Get_Camera_Position())
            {

                case CameraPositionControl.BEHIND_POSITION:
                    y = joystick.Vertical * -1;
                    x = joystick.Horizontal * -1;
                    break;
                case CameraPositionControl.FRONT_POSITION:
                    y = joystick.Vertical;
                    x = joystick.Horizontal;
                    break;
                case CameraPositionControl.LEFT_POSITION:
                    x = joystick.Vertical * -1;
                    y = joystick.Horizontal;
                    break;
                case CameraPositionControl.RIGHT_POSITION:
                    x = joystick.Vertical;
                    y = joystick.Horizontal * -1;
                    break;
            }

            //Animation
            if (x != 0 || y != 0)
            {
                AnimatorController.SetBool("Walk", true);
                Debug.Log("funcionando");
            }
            else
            {
                AnimatorController.SetBool("Walk", false);
                Debug.Log(" no funcionando");
            }
            if (Help) { Debug.Log("X:" + x + " Y:" + y); }

            // AR Rotation
            if (x != 0 && y != 0)
            {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, (Mathf.Atan2(x, y) * Mathf.Rad2Deg) + 90f, transform.eulerAngles.z);
            }

            //    else if(x == 0 || y == 0) { AnimatorController.Stop(); }

            //Final AR Movment
            if (Help) { Debug.Log("YVelocity:" + YSpeed); };

            Vector3 FinalMovment = new Vector3(x * WalkSpeed * Time.deltaTime, YSpeed * Time.deltaTime, y * WalkSpeed * Time.deltaTime);

            Controller.Move(FinalMovment);
        //    this.transform.position = new Vector3(this.transform.position.x+(FinalMovment.x * Time.deltaTime), this.transform.position.y + (FinalMovment.y * Time.deltaTime), this.transform.position.z + (FinalMovment.z *Time.deltaTime));

        }
    }
}







    



