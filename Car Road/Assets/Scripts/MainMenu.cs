using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Video used to help me figure this out: https://www.youtube.com/watch?time_continue=239&v=BjEqZfK15Ws&feature=emb_title

    public string startGameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(startGameScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
