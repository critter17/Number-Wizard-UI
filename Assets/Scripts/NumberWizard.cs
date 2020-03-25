using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] SceneLoader sceneLoader;
    int guess;
    public int numGuesses;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        numGuesses = 0;
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
        CheckNumGuesses();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
        CheckNumGuesses();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void CheckNumGuesses()
    {
        numGuesses++;
        if (numGuesses >= 5 && sceneLoader != null)
            sceneLoader.LoadNextScene();
    }
}