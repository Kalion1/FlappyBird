using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuyaux : MonoBehaviour
{
    public GameManager gameManager;
    public float d_speed = 1f;
    void Update()
    {
       
        
        transform.position = transform.position + new Vector3(-0.01f * d_speed, 0f, 0f);

        if (transform.position.x <= -10)
        {
            transform.position = transform.position + new Vector3(15f, 0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>() != null)
        {
            p_collision.gameObject.SetActive(false);
            gameManager.GameOver();
            Debug.Log("mort");
        }
    }
}
