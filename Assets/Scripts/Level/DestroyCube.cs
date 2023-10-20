using UnityEngine;

public class DestroyCube : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag) {
            case "Bullet":
            case "Player": {
                gameObject.SetActive(false);
                // Destroy(gameObject);
                break;
            }
        }
    }

    public void OnGameReset() {
        gameObject.SetActive(false);
        // Destroy(gameObject);
    }
}