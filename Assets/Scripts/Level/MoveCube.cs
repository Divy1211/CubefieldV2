using UnityEngine;

public class MoveCube : MonoBehaviour {
    private Rigidbody _body;

    private void Start() {
        _body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        _body.velocity = Vector3.back * ActiveState.speed;
        if (!(_body.transform.position.z < -10)) return;

        if (gameObject.CompareTag("LaserPowerup")) {
            Destroy(gameObject);
            return;
        }
        gameObject.SetActive(false);
        // Destroy(gameObject);
    }
}