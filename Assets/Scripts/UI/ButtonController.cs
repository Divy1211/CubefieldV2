using UnityEngine;

public class ButtonController : MonoBehaviour {
    public void OnClickGameReset() {
        Event.gameReset.Raise();
    }
    public void OnClickEasyDifficulty() {
        Event.easyDifficulty.Raise();
    }
    public void OnClickMedDifficulty() {
        Event.medDifficulty.Raise();
    }
    public void OnClickHardDifficulty() {
        Event.hardDifficulty.Raise();
    }
    // public void OnClickStartStart() {
    //     Event.gameStart.Raise(null);
    // }
    // public void OnClickBackToMenu() {
    //     Event.backToMenu.Raise(null);
    // }
    // public void OnClickExitGame() {
    //     Event.exitGame.Raise(null);
    // }
}