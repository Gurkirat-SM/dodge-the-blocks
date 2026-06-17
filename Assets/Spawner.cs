using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject blockPrefab;

    public GameManager gameManager;

    float timer = 0f;

    public float leftBoundary = -7f;

    public float rightBoundary = 7f;

    void Update()
    {
        timer += Time.deltaTime;

        float spawnInterval = GetSpawnInterval();

        if (timer >= spawnInterval)
        {
            SpawnBlock();

            timer = 0f;
        }
    }

    void SpawnBlock()
    {
        float randomX = Random.Range(
            GameArea.Instance.leftBoundary,
            GameArea.Instance.rightBoundary
        );

        Vector3 pos = new Vector3(
            randomX,
            GameArea.Instance.topSpawnY,
            0
        );

        Instantiate(blockPrefab, pos, Quaternion.identity);
    }

    float GetSpawnInterval()
    {
        int difficulty = gameManager.GetDifficultyLevel();

        float interval = 1f - (difficulty * 0.1f);

        return Mathf.Max(0.4f, interval);
    }
}