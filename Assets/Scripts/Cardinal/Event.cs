using UnityEngine;

public class Event : MonoBehaviour {
    public static GameEvent gameOver;
    public static GameEvent gameReset;
    public static GameEvent screenShake;
    public static GameEvent easyDifficulty;
    public static GameEvent medDifficulty;
    public static GameEvent hardDifficulty;
    public static GameEvent backToMenu;
    public static GameEvent exitGame;

    public GameEvent _gameOver;
    public GameEvent _gameReset;
    public GameEvent _screenShake;
    public GameEvent _easyDifficulty;
    public GameEvent _medDifficulty;
    public GameEvent _hardDifficulty;
    public GameEvent _backToMenu;
    public GameEvent _exitGame;
    void Start() {
        gameOver = _gameOver;
        gameReset = _gameReset;
        screenShake = _screenShake;
        easyDifficulty = _easyDifficulty;
        medDifficulty = _medDifficulty;
        hardDifficulty = _hardDifficulty;
        backToMenu = _backToMenu;
        exitGame = _exitGame;
    }
}