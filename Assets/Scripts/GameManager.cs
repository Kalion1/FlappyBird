using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Tuyaux tuyaux;
    public bool gameOver = false;
    public GameObject ScoreCanvas;
    public AddScore AddScore;
 

    private void Start()
    {

        ScoreCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        
        
    }


    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        gameOver = true;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }


}
