using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour {
    public bool isHighscore;
    public bool isLife;

    private TextMeshProUGUI scoreText;

    private void Start() {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        if (isLife) {
            scoreText.text = "Lives: " + StateLive.lives;
            return;
        }

        if (isHighscore) {
            scoreText.text = "Top Score: " + StatePersist.highScore;
            return;
        }

        scoreText.text = "Score: " + StateLive.score;
    }
}