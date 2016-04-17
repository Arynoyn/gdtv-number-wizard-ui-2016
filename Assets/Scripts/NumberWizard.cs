using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;
	
    public int MaxGuessesAllowed = 5;
    public Text GuessText;
    
    // Use this for initialization
	void Start () {
	    StartGame();
	}
	
	public void GuessHigher(){
        min = guess;
        NextGuess();
    }
    
    public void GuessLower(){
        max = guess;
        NextGuess();
    }
    
    void StartGame() {
        max = 1000;
        min = 1;
        NextGuess();
    }
    
    void NextGuess() { 
        guess = Random.Range(min, max + 1);
        GuessText.text = guess.ToString();
        MaxGuessesAllowed--; 
        if (MaxGuessesAllowed <= 0) { Application.LoadLevel("Win"); }
    }
    
}
