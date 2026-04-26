using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverText; // UI text

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");

            // game over
            if (gameOverText != null)
                gameOverText.SetActive(true);

            // stop time (pauses game)
            Time.timeScale = 0f;
        }
    }
}