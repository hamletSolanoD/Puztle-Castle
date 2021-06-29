using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSucces : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text Phrase;
    public string PhraseS;
    public AudioClip FinalAudio;
    

    void Start()
    {
        
    }
    private void LevelCompleted() {
        GameObject.FindObjectOfType<AudioSource>().Stop();
        GameObject.FindObjectOfType<AudioSource>().clip = FinalAudio;
        GameObject.FindObjectOfType<AudioSource>().Play();
        GameObject.Find("ControllsGUI").GetComponent<Canvas>().enabled = false;
        GameObject.Find("LevelSuccesGUI").GetComponent<Canvas>().enabled = true;
        Phrase.text = PhraseS;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Knight")
        {
            LevelCompleted();



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
