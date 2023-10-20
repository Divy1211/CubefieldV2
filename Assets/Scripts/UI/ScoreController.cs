using TMPro;
using UnityEngine;

public enum HudType {
    Score,
    Highscore,
    Lives,
    Bullets
}

public class ScoreController : MonoBehaviour {
    public HudType type;

    private TextMeshProUGUI scoreText;

    private void Start() {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        switch (type) {
            case HudType.Lives: {
                scoreText.text = "Lives: " + LiveState.lives;
                break;
            }
            case HudType.Highscore: {
                scoreText.text = "Top Score: " + StatePersist.highScore;
                break;
            }
            case HudType.Bullets: {
                scoreText.text = "Bullets: " + LiveState.bulletCount;
                break;
            }
            case HudType.Score: {
                scoreText.text = "Score: " + LiveState.score;
                break;
            }
        }
    }
}