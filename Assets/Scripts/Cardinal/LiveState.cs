using UnityEngine;

public class LiveState : MonoBehaviour {
    public static int score;
    public static int lives = 3;
    public static int bulletCount = 0;

    private static int _difficultyMultiplier = 1;
    private static float _elapsedTime;

    private void Update() {
        _elapsedTime += Time.deltaTime;
        score = Mathf.RoundToInt(_difficultyMultiplier * _elapsedTime * _elapsedTime);
    }

    public void OnGameOver() {
        Time.timeScale = 0.0f;
    }

    public void OnGameReset() {
        Time.timeScale = 1.0f;
        score = 0;
        lives = 3;
        _elapsedTime = 0;
    }
}