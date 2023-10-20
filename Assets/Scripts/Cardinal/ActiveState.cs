using UnityEngine;

public enum Difficulty {
    Easy = 0,
    Medium = 1,
    Hard = 2,
}

public class ActiveState : MonoBehaviour {
    public static float speed;
    public static int score;
    public static int lives = 3;
    public static int bulletCount = 0;

    public bool mainMenu;

    private static float _elapsedTime;

    public GameConfig easy;
    public GameConfig med;
    public GameConfig hard;

    private static GameConfig _easy;
    private static GameConfig _med;
    private static GameConfig _hard;

    private void Awake() {
        _easy = easy;
        _med = med;
        _hard = hard;
        if(mainMenu) {
            ActiveConfig.config = _easy;
        }
    }

    private void Update() {
        _elapsedTime += Time.deltaTime;
        score = Mathf.RoundToInt(ActiveConfig.difficultyMultiplier * _elapsedTime * _elapsedTime);
    }

    private void FixedUpdate() {
        speed += ActiveConfig.acceleration;
    }

    public void OnGameOver() {
        Time.timeScale = 0.0f;
        PersistState.highScore = Mathf.Max(PersistState.highScore, score);
    }

    public void OnGameReset() {
        Time.timeScale = 1.0f;
        score = 0;
        lives = 3;
        _elapsedTime = 0;
        speed = ActiveConfig.speed;
    }

    public void OnDifficultySelected(int dif) {
        Difficulty difficulty = (Difficulty)dif;
        ActiveConfig.config = difficulty != Difficulty.Easy ? difficulty != Difficulty.Medium ? _hard : _med : _easy;

        speed = ActiveConfig.speed;
        _elapsedTime = 0;
    }
}