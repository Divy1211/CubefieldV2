using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour {
    public GameObject bulletPrefab;

    public float speed = 10.0f;
    public float jumpImpulse = 10.0f;
    public float gravityScale = 3.0f;

    public AudioClip jumpSfx;
    public AudioClip shootSfx;

    private CubeAction _cubeAction;
    private Rigidbody _body;
    private AudioSource _audioSrc;

    private float _velocityX;
    private bool _onGround = true;

    private void OnMovement(InputAction.CallbackContext ctx) {
        var x = ctx.ReadValue<Vector2>().x;
        _velocityX = (x != 0 ? x > 0 ? 1 : -1 : 0) * speed;
    }

    private void OnJump(InputAction.CallbackContext ctx) {
        if (!_onGround) return;

        _audioSrc.PlayOneShot(jumpSfx);
        _onGround = false;
        _body.AddForce(Vector3.up * jumpImpulse, ForceMode.Impulse);
    }

    private void OnFire(InputAction.CallbackContext ctx) {
        if (ActiveState.bulletCount == 0) return;

        _audioSrc.PlayOneShot(shootSfx);
        --ActiveState.bulletCount;
        GameObject bullet = Instantiate(
            bulletPrefab, transform.position + Vector3.forward * 1.5f, bulletPrefab.transform.rotation
        );
        Rigidbody body = bullet.GetComponent<Rigidbody>();
        body.velocity = Vector3.forward * 10;
    }

    private void Start() {
        _cubeAction = new CubeAction();
        _cubeAction.Enable();

        _cubeAction.Player.Movement.performed += OnMovement;
        _cubeAction.Player.Movement.canceled += OnMovement;

        _cubeAction.Player.Jump.performed += OnJump;
        _cubeAction.Player.Fire.performed += OnFire;

        _body = GetComponent<Rigidbody>();
        _audioSrc = GetComponent<AudioSource>();
    }

    private void FixedUpdate() {
        var vel = _body.velocity;
        _body.velocity = new Vector3(_velocityX, vel.y, vel.z);
        _body.AddForce(Vector3.down * (_body.mass * 9.8f * gravityScale), ForceMode.Acceleration);

        var pos = _body.transform.localPosition;
        _body.transform.localPosition = new Vector3(
            Mathf.Clamp(pos.x, -ActiveConfig.lineWidth+2, ActiveConfig.lineWidth-2), pos.y, pos.z
        );
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground")) {
            _onGround = true;
        }
    }
}