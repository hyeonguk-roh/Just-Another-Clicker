using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

using TMPro;

using UnityEngine;

using Random = System.Random;

public class RandomItemList : MonoBehaviour
{
    public TMP_Text randomObject; 

    public TMP_Text objIntro;

    public void PushButton() {
        if (PlayerPrefs.HasKey("ObjectName")) {
            randomObject.text = PlayerPrefs.GetString("ObjectName");
        } else {
            // Create a random object
            System.Random random = new Random();

            // Create a string builder to store the word
            StringBuilder word = new StringBuilder();

            // Generate a random length between 3 and 6
            int length = random.Next(3, 7);

            // Generate a random vowel
            char vowel = "aeiouy"[random.Next(6)];

            // Generate a random consonant
            char consonant = "bcdfghjklmnpqrstvwxyz"[random.Next(21)];

            // Add the vowel and consonant to the word
            word.Append(consonant);
            word.Append(vowel);

            // Loop until the word reaches the desired length
            while (word.Length < length)
            {
                char vowels = "aeiouy"[random.Next(6)];
                char consonants = "bcdfghjklmnpqrstvwxyz"[random.Next(21)];
                
                word.Append(consonants);
                word.Append(vowels);
            }

            // Add an 's' to make the word plural
            word.Append('s');

            // Print the word
            randomObject.text = word.ToString();
            PlayerPrefs.SetString("ObjectName", randomObject.text);
            objIntro.text = PlayerPrefs.GetString("ObjectName");
        }
    }
}
