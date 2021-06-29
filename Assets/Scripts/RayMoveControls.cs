using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayMoveControls : MonoBehaviour
{
    private GameObject FocusedGameObject;

    // Start is called before the first frame update

    void Start()
    {
        
    }
    private void RayFocusedGameObject() {
        Ray rayRecObjects = FindObjectOfType<Camera>().ScreenPointToRay(Input.GetTouch(0).position);



    }

    // Update is called once per frame
    void Update()

    {
        
    }
}
