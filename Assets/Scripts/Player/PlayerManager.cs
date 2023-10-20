using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public AudioClip collideSfx;
    public AudioClip powerupSfx;
    public AudioClip gameOverSfx;

    private AudioSource audioSrc;

    private void Start() {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other) {
        switch (other.gameObject.tag) {
            case "Obstacle": {
                audioSrc.PlayOneShot(collideSfx);
                if (--ActiveState.lives == 0) {
                    audioSrc.PlayOneShot(gameOverSfx);
                    Event.gameOver.Raise();
                } else {
                    Event.screenShake.Raise();
                }

                break;
            }
            case "LaserPowerup": {
                audioSrc.PlayOneShot(powerupSfx);
                ActiveState.bulletCount += 5;
                break;
            }
        }
    }

    public void OnGameReset() {
        GetComponent<Transform>().localPosition = new Vector3(0, -0.32f, 0);
        ActiveState.bulletCount = 0;
        StopAllCoroutines();
    }
}