using UnityEngine;

public class Event : MonoBehaviour {
    public static GameEvent gameOver;
    public static GameEvent gameReset;
    public static GameEvent screenShake;

    public GameEvent _gameOver;
    public GameEvent _gameReset;
    public GameEvent _screenShake;
    void Start() {
        gameOver = _gameOver;
        gameReset = _gameReset;
        screenShake = _screenShake;
    }
}