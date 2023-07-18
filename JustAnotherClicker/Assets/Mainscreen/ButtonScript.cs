using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ButtonScript : MonoBehaviour
{
    private int gameState = 0;

    private int score = 0;
    private int incrementLevel = 1;

    public TMP_Text scoreText;

    public Animator dialogue;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Score")) {
            score = PlayerPrefs.GetInt("Score");
        } else {
            PlayerPrefs.SetInt("Score", score);
        }

        if (PlayerPrefs.HasKey("GameState")) {
            gameState = PlayerPrefs.GetInt("GameState");
        } else {
            PlayerPrefs.SetInt("GameState", gameState);
        }

        dialogue.SetInteger("dialogueState", gameState);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + score;
    }

    public void PushButton() {
        score += incrementLevel;
        PlayerPrefs.SetInt("Score", score);
    }

    public void Dialogue() {
        gameState++;
        dialogue.SetInteger("dialogueState", gameState);
        PlayerPrefs.SetInt("GameState", gameState);
    }
}
