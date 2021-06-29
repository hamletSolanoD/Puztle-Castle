using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingSword : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Item;
    public GameObject Item2;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Knight") {
            Item2.SetActive(true);
            Item.SetActive(false);
          

        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
