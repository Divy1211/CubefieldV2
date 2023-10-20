using UnityEngine;

public class MoveCam : MonoBehaviour {
    public GameObject player;

    private Transform _playerPos;
    private Transform _camPos;

    void Start() {
        _playerPos = player.GetComponent<Transform>();
        _camPos = transform;
    }

    void Update() {
        var pos = _camPos.position;
        _camPos.position = new Vector3(_playerPos.position.x, pos.y, pos.z);
    }
}