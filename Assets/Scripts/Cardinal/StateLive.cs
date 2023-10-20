using UnityEngine;

public class StateLive : MonoBehaviour {
    public static int score;
    public static int lives = 3;

    private static int _difficultyMultiplier = 1;

    private void Update() {
        score = Mathf.RoundToInt(_difficultyMultiplier * Time.time * Time.time);
    }

    public void OnGameOver() {
        Time.timeScale = 0.0f;
    }
}