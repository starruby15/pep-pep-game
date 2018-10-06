using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
public class GameControl : MonoBehaviour {

    public static GameControl instance; 
    public GameObject gameOverText;
    public GameObject gameOverText2;
    public Text scoreText; 
    

    public bool gameOver = false;
    public float scrollSpeed = -2.5f;

    private int score; 

 
	// Use this for initialization
   
    void Awake () {
		if(instance == null)
        {
            instance = this;
           
        }
        else if (instance != this)
        {
            Destroy(gameObject); 
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver!=true && score == 3)
        {
            SceneManager.LoadScene("gamewon", LoadSceneMode.Single);
        }
        
	}

    public void PepScored()
    {
        if (gameOver)
        {
            return; 
        }
        score++;
        scoreText.text = "Happy Dreams: " + score.ToString(); 
    }
    
    public void PepDied()
    {
        gameOverText.SetActive(true);
        gameOverText2.SetActive(true); 
        gameOver = true;
        SceneManager.LoadScene("gameover", LoadSceneMode.Single);
    }
}
