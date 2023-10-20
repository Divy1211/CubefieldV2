using UnityEngine;

public class DestroyCube : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if(gameObject.CompareTag(other.gameObject.tag)) return;

        switch (other.gameObject.tag) {
            case "Player":
            case "Obstacle":
            case "Bullet": {
                Destroy(gameObject);
                break;
            }
        }
    }
}