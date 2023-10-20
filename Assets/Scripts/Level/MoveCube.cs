using UnityEngine;

public class MoveCube : MonoBehaviour {
    private Rigidbody _body;

    private void Start() {
        _body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        _body.velocity = Vector3.back * 10;
        if (_body.transform.position.z < -10) {
            Destroy(gameObject);
        }
    }

    public void OnGameReset() {
        Destroy(gameObject);
    }
}