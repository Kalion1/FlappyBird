using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public float d_speed = 0.5f;
    public GameManager gameManager;

    private void Update()
    {
        transform.position = transform.position + new Vector3(-0.01f * d_speed, 0f, 0f);

        if (transform.position.x <= -10)
        {
            transform.position = transform.position + new Vector3(18f, 0f, 0f);
        }

        if (gameManager.gameOver)
        {
            d_speed = 0;
            Debug.Log("mort");
        }

    }

    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Player>() != null)

            Score.score++;
    }
}
