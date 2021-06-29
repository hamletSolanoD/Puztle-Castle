using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class MenuesScript : MonoBehaviour
{

    
    // Start is called before the first frame update
    private static VideoClip Vid;
    private static string Nivel;

    public void ChangeScene(string Scene) {
        SceneManager.LoadScene(Scene);
    }
    public void LevelsScene()
    {

    }
    public void SetVideo(VideoClip vid)
    {
        Vid = vid;
    }
    public void SetVideo(string Scene)
    {
        Nivel = Scene;
    }
    public static VideoClip  GetVideo() {
        return Vid;
    }
    public static string GetScene()
    {
        return Nivel;
    }
    public void PlayMusic(AudioClip clip)
    {
        GameObject.FindObjectOfType<AudioSource>().Stop();
        GameObject.FindObjectOfType<AudioSource>().clip = clip;
        GameObject.FindObjectOfType<AudioSource>().Play();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
