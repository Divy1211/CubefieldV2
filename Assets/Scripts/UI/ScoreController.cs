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

    private TextMeshProUGUI _scoreText;

    private void Start() {
        _scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        switch (type) {
            case HudType.Lives: {
                _scoreText.text = "Lives: " + ActiveState.lives;
                break;
            }
            case HudType.Highscore: {
                _scoreText.text = "Top Score: " + PersistState.highScore;
                break;
            }
            case HudType.Bullets: {
                _scoreText.text = "Bullets: " + ActiveState.bulletCount;
                break;
            }
            case HudType.Score: {
                _scoreText.text = "Score: " + ActiveState.score;
                break;
            }
        }
    }
}