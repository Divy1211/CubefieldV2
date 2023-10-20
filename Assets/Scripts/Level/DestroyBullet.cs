using System.Collections;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {
    public AudioClip cubeBlownSfx;

    private Rigidbody _body;

    private IEnumerator DestroyAfter(float time) {
        yield return new WaitForSecondsRealtime(time);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other) {
        if (!other.gameObject.CompareTag("Obstacle")) return;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<AudioSource>().PlayOneShot(cubeBlownSfx);
        _body.velocity = Vector3.zero;

        StartCoroutine(DestroyAfter(cubeBlownSfx.length));
    }

    private void Start() {
        _body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        if (_body.transform.position.z > 8) {
            Destroy(gameObject);
        }
    }
}