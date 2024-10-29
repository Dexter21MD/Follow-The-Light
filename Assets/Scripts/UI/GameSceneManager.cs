using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    int sceneIndex;
    // Start is called before the first frame update
    void Awake()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadGameLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

}
