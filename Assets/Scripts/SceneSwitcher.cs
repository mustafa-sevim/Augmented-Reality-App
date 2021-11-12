using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private static int turn = 0;
    public void nextScene()
    {
        if(turn != 2){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            turn++;
        }
        else{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
            turn = 0;
        }
    }
}
