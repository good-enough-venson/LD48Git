using UnityEngine;

public class SetCenterOfGravity : MonoBehaviour
{
    private Rigidbody2D _rigidbody = null;
    new public Rigidbody2D rigidbody {
        get {
            if (_rigidbody == null)
                _rigidbody = GetComponent<Rigidbody2D>();
            return _rigidbody;
        } set { _rigidbody = value; }
    }

    public Transform centerPoint;

    private void Awake() { rigidbody.centerOfMass = centerPoint.position; }
}
