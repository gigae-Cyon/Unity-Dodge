using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;
    public GameObject newRecordText;

    private float surviveTime;
    private bool isGameover;
    private Scene currentScene;
    private string difficulty;

    void Start() {
        surviveTime = 0;
        isGameover = false;
        currentScene = SceneManager.GetActiveScene();
        if (currentScene.name == "NormalScene") {difficulty = "Normal";}
        else if (currentScene.name == "HardScene") {difficulty = "Hard";}
        else if (currentScene.name == "CrazyScene") {difficulty = "Crazy";}
    }

    void Update() {
        if (!isGameover) {
            surviveTime += Time.deltaTime;
            timeText.text = "Time: " + string.Format("{0:0.00}", TruncateScoreFloatingPoint(surviveTime));
            if (Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene("MainMenu");
            }
        }
        else {
            if (Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene(currentScene.name);
            }
            else if (Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

    public void EndGame() {
        isGameover = true;
        gameoverText.SetActive(true);

        surviveTime = TruncateScoreFloatingPoint(surviveTime);
        float bestTime = PlayerPrefs.GetFloat(difficulty);

        if (surviveTime > bestTime) {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat(difficulty, bestTime);
            newRecordText.SetActive(true);
        }

        recordText.text = "Best Time: " + bestTime;
    }

    private float TruncateScoreFloatingPoint(float score) {
        return (float) Math.Truncate(score * 100) / 100f; // 소수점 둘째 자리 아래로 버림
    }
}
