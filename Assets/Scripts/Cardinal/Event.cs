using UnityEngine;

public class Event : MonoBehaviour {
    public static GameEvent gameOver;
    public static GameEvent gamePause;
    public static GameEvent gameReset;

    public GameEvent _gameOver;
    public GameEvent _gamePause;
    public GameEvent _gameReset;
    void Start() {
        gameOver = _gameOver;
        gamePause = _gamePause;
        gameReset = _gameReset;
    }
}