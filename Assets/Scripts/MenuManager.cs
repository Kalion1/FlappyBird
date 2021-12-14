using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    void Start()
    {
        Screen.SetResolution(750, 1334, true);
    }

    public void LoadScene()
    {
        Debug.Log("GO");
        SceneManager.LoadScene(1);
        
    }
    

}
