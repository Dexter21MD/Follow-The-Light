using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{

    // Start is called before the first frame update


    public void LoadGameLevel()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadMenuLevel()
    {
        SceneManager.LoadScene(0);
    }    

    public void ExitGame()
    {
        Application.Quit();
    }

}
