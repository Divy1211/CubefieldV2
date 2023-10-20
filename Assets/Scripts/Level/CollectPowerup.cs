using UnityEngine;

public class CollectPowerup : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}