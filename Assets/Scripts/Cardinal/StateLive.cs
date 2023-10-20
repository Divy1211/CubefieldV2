using UnityEngine;

public class StateLive : MonoBehaviour {
    public static int score;
    public static int lives = 3;

    private static int _difficultyMultiplier = 1;
    private static float _gameStartTime;

    private void Update() {
        float delta = Time.time - _gameStartTime;
        score = Mathf.RoundToInt(_difficultyMultiplier * delta * delta);
    }

    public void OnGameOver() {
        Time.timeScale = 0.0f;
    }

    public void OnGameReset() {
        Time.timeScale = 1.0f;
        score = 0;
        lives = 3;
        _gameStartTime = Time.time;
    }
}