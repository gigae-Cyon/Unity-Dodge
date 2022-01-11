using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartButton : MonoBehaviour
{
    public void GameStartNormal() {
        SceneManager.LoadScene("NormalScene");
    }
    public void GameStartHard() {
        SceneManager.LoadScene("HardScene");
    }
    public void GameStartCrazy() {
        SceneManager.LoadScene("CrazyScene");
    }
    
}
