using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;

    void Start() {
        surviveTime = 0;
        isGameover = false;
    }

    void Update() {
        if (!isGameover) {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + (int)surviveTime;
            if (Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene("MainMenu");
            }
        }
        else {
            if (Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene("SampleScene");
            }
            else if (Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

    public void EndGame() {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (surviveTime > bestTime) {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time: " + (int)bestTime;
    }
}
