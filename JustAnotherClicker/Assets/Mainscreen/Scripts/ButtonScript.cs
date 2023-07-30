using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ButtonScript : MonoBehaviour
{
    private int gameState = 0;

    private double score = 0;
    private double incrementLevel = 1;

    public TMP_Text scoreText;

    public Animator dialogue;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Score")) {
            score = double.Parse(PlayerPrefs.GetString("Score"), System.Globalization.CultureInfo.InvariantCulture);
        } else {
            PlayerPrefs.SetString("Score", score.ToString());
        }

        if (PlayerPrefs.HasKey("GameState")) {
            gameState = PlayerPrefs.GetInt("GameState");
        } else {
            PlayerPrefs.SetInt("GameState", gameState);
        }

        if (PlayerPrefs.HasKey("IncrementLevel")) {
            incrementLevel = double.Parse(PlayerPrefs.GetString("IncrementLevel"), System.Globalization.CultureInfo.InvariantCulture);
        } else {
            PlayerPrefs.SetString("IncrementLevel", incrementLevel.ToString());
        }

        dialogue.SetInteger("dialogueState", gameState);
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score + " " + PlayerPrefs.GetString("ObjectName");
    }

    public void PushButton() {
        score += incrementLevel;
        PlayerPrefs.SetString("Score", score.ToString());
    }

    public void Dialogue() {
        gameState++;
        dialogue.SetInteger("dialogueState", gameState);
        PlayerPrefs.SetInt("GameState", gameState);
        Debug.Log(dialogue.GetInteger("dialogueState"));
    }
}
