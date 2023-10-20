using UnityEngine;

public class PlayerManager : MonoBehaviour {
    private void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag) {
            case "Obstacle": {
                if (--LiveState.lives == 0) {
                    Event.gameOver.Raise();
                }

                break;
            }
            case "LaserPowerup": {
                LiveState.bulletCount += 10;
                break;
            }
        }
    }

    public void OnGameReset() {
        GetComponent<Transform>().localPosition = new Vector3(0, -0.32f, 0);
        LiveState.bulletCount = 0;
        StopAllCoroutines();
    }
}