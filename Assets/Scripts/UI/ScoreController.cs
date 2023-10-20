using TMPro;
using UnityEngine;

public enum HudType {
    Score,
    Highscore,
    Lives,
    Bullets,
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
                scoreText.text = "Lives: " + ActiveState.lives;
                break;
            }
            case HudType.Highscore: {
                scoreText.text = "Top Score: " + PersistState.highScore;
                break;
            }
            case HudType.Bullets: {
                scoreText.text = "Bullets: " + ActiveState.bulletCount;
                break;
            }
            case HudType.Score: {
                scoreText.text = "Score: " + ActiveState.score;
                break;
            }
        }
    }
}