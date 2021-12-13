using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void LoadScene()
    {
        Debug.Log("GO");
        SceneManager.LoadScene(1);
        
    }
    

}
