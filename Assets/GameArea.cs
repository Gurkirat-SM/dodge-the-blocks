using UnityEngine;

public class GameArea : MonoBehaviour
{
    public static GameArea Instance;

    public float leftBoundary = -7f;

    public float rightBoundary = 7f;

    public float topSpawnY = 5f;

    public float bottomDestroyY = -6f;

    void Awake()
    {
        Instance = this;
    }
}