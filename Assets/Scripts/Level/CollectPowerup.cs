using UnityEngine;

public class CollectPowerup : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
    public void OnGameReset() {
        Destroy(gameObject);
    }
}