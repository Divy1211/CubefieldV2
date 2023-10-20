using UnityEngine;

public class MoveCam : MonoBehaviour {
    public GameObject player;

    private Transform playerPos;
    private Transform camPos;

    void Start() {
        playerPos = player.GetComponent<Transform>();
        camPos = GetComponent<Transform>();
    }

    void Update() {
        var pos = camPos.position;
        camPos.position = new Vector3(playerPos.position.x, pos.y, pos.z);
    }
}