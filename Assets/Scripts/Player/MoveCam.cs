using System.Collections;
using UnityEngine;

public class MoveCam : MonoBehaviour {
    public GameObject player;

    private Transform _playerPos;
    private Transform _camPos;

    private void Start() {
        _playerPos = player.GetComponent<Transform>();
        _camPos = transform;
    }

    private void Update() {
        var pos = _camPos.position;
        _camPos.position = new Vector3(_playerPos.position.x, pos.y, pos.z);
    }

    private IEnumerator Shake(float duration, float intensity = 1) {
        float elapsedTime = 0;

        while (elapsedTime < duration) {
            elapsedTime += Time.deltaTime;
            _camPos.position += Random.insideUnitSphere * intensity;
            yield return null;
        }
    }

    public void OnScreenShake() {
        StartCoroutine(Shake(1.0f, 0.1f));
    }
}