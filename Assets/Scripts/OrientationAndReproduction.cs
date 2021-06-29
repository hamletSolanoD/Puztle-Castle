using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
public class OrientationAndReproduction : MonoBehaviour
{
    public bool OnVideo, VerticalOrientation;
    public VideoPlayer Video;
    private string DestinationScene;
    private double VideoDuration;

    // Start is called before the first frame update
    void Start()
    {
        if (OnVideo) {
            Screen.orientation = ScreenOrientation.Landscape;
            Video.clip = MenuesScript.GetVideo();
            DestinationScene = MenuesScript.GetScene();
            VideoDuration = (double)Mathf.Floor((float)(Video.clip.length )) ;

        }
        if (VerticalOrientation) {
            Screen.orientation = ScreenOrientation.Portrait;
        }

        
    }
    public void SkipVideo() {

        SceneManager.LoadScene(DestinationScene);

    }
   
       

    // Update is called once per frame
    void Update()
    {
        if (OnVideo) {
            Debug.Log(Video.clip.name);
            Debug.Log(DestinationScene);
            Debug.Log(Video.time);
            Debug.Log(VideoDuration);
            if (Video.time >= VideoDuration) {
                Debug.Log("Termino we");
                SceneManager.LoadScene(DestinationScene);
            }
        }
        

  
    }
}

