using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rigidbody = null;
    new public Rigidbody2D rigidbody {
        get => _rigidbody ? _rigidbody :
            _rigidbody = GetComponent<Rigidbody2D>();
    }

    private JackhammerScript _jackhammer = null;
    public JackhammerScript jackhammer {
        get => _jackhammer ? _jackhammer :
            _jackhammer = GetComponentInChildren<JackhammerScript>();
    }

    public ParticleSystem[] downBoostFlames;

    public PlayerInput controls;

    public float jumpingRange = 5f;

    public float lateralSpeed = 2f;
    public float lateralForce = 2f;
    public float lateralRange = 2f;
    public float lateralDir = 0f;
    public float currentLateralDir {
        //get => invertTilt ? -lateralDir : lateralDir;
        get => lateralDir;
        set => lateralDir = value;
    }

    public float tiltAngle = 10f;
    public float tiltSpeed = 10f;
    public float currentTilt = 0f;

    public bool downBoost = false;
    public float downBoostForce = 10;

    Vector2 worldPoint;

    private void Awake()
    {
        controls = new PlayerInput();

        controls.KeyboardControls.Steering.performed +=
            (val) => SetTiltFromValue(val.ReadValue<float>());

        controls.KeyboardControls.Steering.canceled +=
            (val) => SetTiltFromValue(0);

        controls.KeyboardControls.Jump.performed +=
            (val) => { jackhammer.jumping = 1; jackhammer.shouldJump = true; };

        controls.KeyboardControls.Jump.canceled +=
            (val) => jackhammer.jumping = 0;

        controls.KeyboardControls.HammerBoost.performed += (val) => {
            foreach (var effect in downBoostFlames) effect.Play();
            downBoost = true;
        };

        controls.KeyboardControls.HammerBoost.canceled += (val) => {
            foreach (var effect in downBoostFlames) effect.Stop();
            downBoost = false;
        };

        controls.MouseControls.SteeringPos.performed +=
            (val) => SetTiltFromScreenPos(val.ReadValue<Vector2>());

        controls.MouseControls.HammerBoost.performed += (val) => {
            foreach (var effect in downBoostFlames) effect.Play();
            downBoost = true;
        };

        controls.MouseControls.HammerBoost.canceled += (val) => {
            foreach (var effect in downBoostFlames) effect.Stop();
            downBoost = false;
        };
    }

    private void FixedUpdate()
    {
        rigidbody.MoveRotation(Mathf.LerpAngle(rigidbody.rotation,
            currentTilt, Time.deltaTime * tiltSpeed));

        //float angleDifference = Mathf.DeltaAngle(rigidbody.rotation, currentTilt);

        //rigidbody.AddTorque(angleDifference / 180 * tiltSpeed, ForceMode2D.Impulse);

        //rigidbody.angularVelocity = angleDifference / 180 * tiltSpeed;

        //currentLateralDir = (worldPoint.x > rigidbody.position.x ? 1f : -1f) *
        //    Mathf.Clamp01(Mathf.Abs(rigidbody.position.x - worldPoint.x) / lateralRange);

        if (downBoost) {
            rigidbody.AddForce(transform.up * -downBoostForce, ForceMode2D.Impulse);
        }

        if (currentLateralDir < 0f && rigidbody.velocity.x > -lateralSpeed)
            rigidbody.AddForce(Vector2.right * currentLateralDir * lateralForce, ForceMode2D.Force);
        else if (currentLateralDir > 0f && rigidbody.velocity.x < lateralSpeed)
            rigidbody.AddForce(Vector2.right * currentLateralDir * lateralForce, ForceMode2D.Force);
    }

    private void SetTiltFromScreenPos(Vector2 screenPos)
    {
        worldPoint = Camera.main.ScreenToWorldPoint(screenPos);
        Vector3 vector = worldPoint - rigidbody.position;

        jackhammer.jumping = Mathf.Clamp01(Mathf.Abs(worldPoint.y - rigidbody.position.y) / jumpingRange);

        currentTilt = Vector2.SignedAngle(Vector2.right, vector) - 90;

        currentLateralDir = (worldPoint.x > rigidbody.position.x ? 1f : -1f) *
            Mathf.Clamp01(Mathf.Abs(rigidbody.position.x - worldPoint.x) / lateralRange);
    }

    private void SetTiltFromValue(float value) {
        Debug.Log(string.Format("Setting Tilt To: {0}", value));
        currentTilt = tiltAngle * -value;
        currentLateralDir = value;
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }
}
