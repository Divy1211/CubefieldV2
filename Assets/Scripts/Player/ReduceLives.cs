using UnityEngine;

public class ReduceLives : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if(!other.gameObject.CompareTag("Obstacle")) return;
        --StateLive.lives;
        if (StateLive.lives == 0) {
            Event.gameOver.Raise();
        }
    }
}