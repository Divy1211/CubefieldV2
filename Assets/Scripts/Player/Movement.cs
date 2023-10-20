using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour {
    public float speed = 10.0f;
    public float jumpImpulse = 10.0f;
    public float gravityScale = 1.0f;

    private float g = 9.8f;

    private CubeAction _cubeAction;
    private Rigidbody _body;

    private bool _onGround = true;

    private void OnMovement(InputAction.CallbackContext ctx) {
        var x = ctx.ReadValue<Vector2>().x;
        var velocity = _body.velocity;

        _body.velocity = new Vector3((x != 0 ? x > 0 ? 1 : -1 : 0) * speed, velocity.y, velocity.z);
    }

    private void OnJump(InputAction.CallbackContext ctx) {
        if (!_onGround) return;

        _onGround = false;
        _body.AddForce(Vector3.up * jumpImpulse, ForceMode.Impulse);
    }

    private void OnFire(InputAction.CallbackContext ctx) { }

    private void Start() {
        _cubeAction = new CubeAction();
        _cubeAction.Enable();

        _cubeAction.Player.Movement.performed += OnMovement;
        _cubeAction.Player.Movement.canceled += OnMovement;

        _cubeAction.Player.Jump.performed += OnJump;
        _cubeAction.Player.Fire.performed += OnFire;

        _body = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        _body.AddForce(Vector3.down * (_body.mass * g * gravityScale), ForceMode.Acceleration);

        var pos = _body.transform.localPosition;
        _body.transform.localPosition = new Vector3(Mathf.Clamp(pos.x, -4, 4), pos.y, pos.z);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Ground")) {
            _onGround = true;
        }
    }
}