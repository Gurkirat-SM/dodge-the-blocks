using UnityEngine;

public class Block : MonoBehaviour
{
    Rigidbody2D rb;

    GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        gameManager = FindAnyObjectByType<GameManager>();

        UpdateGravity();
    }

    void Update()
    {
        if (transform.position.y < GameArea.Instance.bottomDestroyY)
        {
            if (gameManager != null)
            {
                gameManager.AddScore();
            }

            Destroy(gameObject);
        }
    }

    void UpdateGravity()
    {
        if (gameManager != null)
        {
            int difficulty = gameManager.GetDifficultyLevel();

            rb.gravityScale = 1f + (difficulty * 0.2f);
        }
    }
}