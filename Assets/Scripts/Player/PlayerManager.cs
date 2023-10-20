using UnityEngine;

public class PlayerManager : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if(!other.gameObject.CompareTag("Obstacle")) return;
        --StateLive.lives;
        if (StateLive.lives == 0) {
            Event.gameOver.Raise();
        }
    }

    public void OnGameReset() {
        GetComponent<Transform>().localPosition = new Vector3(0, -0.32f, 0);
    }
}