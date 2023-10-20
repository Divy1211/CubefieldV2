using UnityEngine;

public class ButtonController : MonoBehaviour {
    public void OnClickGameReset() {
        Event.gameReset.Raise();
    }
    // public void OnClickGamePause() {
    //     LiveState.isPaused;
    //     Event.gamePause.Raise();
    // }
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