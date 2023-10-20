using UnityEngine;

public class StatePersist : MonoBehaviour {
    public static int highScore {
        get => _stats.highScore;
        set => _stats.highScore = value;
    }

    public GameStats stats;

    private static GameStats _stats;
    private void Start() {
        _stats = stats;
    }
}