using System.Collections;
using UnityEngine;

public class MoveCam : MonoBehaviour {
    public GameObject player;

    private Transform _playerPos;
    private Transform _camPos;
    private Vector3 _startPos;


    private void Start() {
        _playerPos = player.GetComponent<Transform>();
        _camPos = transform;
        _startPos = _camPos.position;
    }

    private void Update() {
        _camPos.position = new Vector3(_playerPos.position.x, _startPos.y, _startPos.z);
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