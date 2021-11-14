using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Tuyaux tuyaux;

    private void Start()
    {
        
        gameOverCanvas.SetActive(false);
        
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        tuyaux.d_speed = 0;
        Debug.Log(tuyaux.d_speed);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }


}
