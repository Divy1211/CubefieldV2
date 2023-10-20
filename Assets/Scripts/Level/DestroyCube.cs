using UnityEngine;

public class DestroyCube : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag) {
            case "Bullet":
            case "Player": {
                Destroy(gameObject);
                break;
            }
        }
    }
}