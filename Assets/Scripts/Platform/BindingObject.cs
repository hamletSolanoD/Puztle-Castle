using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindingObject : MonoBehaviour
{
    public GameObject Parent;
    void Start()
    {
        Parent.gameObject.SetActive(false);
        Parent.gameObject.SetActive(true);
    }

    private void OnTriggerStay(Collider other){
            if (other.transform.name == "Knight")
            {
            GameObject.Find("Knight").transform.SetParent(Parent.transform);
            Debug.Log("en la plataforma ");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Knight") {
            GameObject.Find("Knight").transform.SetParent(GameObject.Find("World").GetComponent<Transform>());
            Debug.Log( "fuera de la plataforma ");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
