using UnityEngine;

public class BgmController : MonoBehaviour {
    private AudioSource _audioSrc;
    private void Start() {
        _audioSrc = GetComponent<AudioSource>();
    }

    public void OnGameOver() {
        _audioSrc.Stop();
    }

    public void OnGameReset() {
        _audioSrc.Play();
    }
}