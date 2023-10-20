using UnityEngine;

public class UIController : MonoBehaviour {
    public GameObject gameUi;
    public GameObject gameOverUi;
    public GameObject pausedUi;
    public GameObject loadingUi;

    public void OnGameOver() {
        gameUi.SetActive(false);
        gameOverUi.SetActive(true);
    }

    // public void OnGamePause() {
    //     gameUi.SetActive(!isPaused);
    //     pausedUi.SetActive(isPaused);
    // }

    // public void OnGameReset() {
    //     gameUi.SetActive(true);
    //     gameOverUi.SetActive(false);
    // }
    //
    // public void OnGameStart() {
    //     loadingUi.SetActive(true);
    // }
}