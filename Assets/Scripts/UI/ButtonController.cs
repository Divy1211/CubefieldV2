using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
    public void OnClickGameReset() {
        Event.gameReset.Raise();
    }
    public void OnClickEasyDifficulty() {
        Event.easyDifficulty.Raise();
        SceneManager.LoadSceneAsync("Level", LoadSceneMode.Single);
    }
    public void OnClickMedDifficulty() {
        Event.medDifficulty.Raise();
        SceneManager.LoadSceneAsync("Level", LoadSceneMode.Single);
    }
    public void OnClickHardDifficulty() {
        Event.hardDifficulty.Raise();
        SceneManager.LoadSceneAsync("Level", LoadSceneMode.Single);
    }
    public void OnClickBackToMenu() {
        Event.gameReset.Raise();
        Event.backToMenu.Raise();
        SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
    }
    public void OnClickExitGame() {
        Event.exitGame.Raise();
        Application.Quit();
    }
}