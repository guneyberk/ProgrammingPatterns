using Unity.VisualScripting;
using UnityEngine;



public interface IJoystick
{
    public void JoystickOverride();
}

public interface IAimJoystick
{
    public Quaternion LookRotation();
}

public class MovementJoystick : IJoystick
{
    FixedJoystick FixedJoystick;
    Rigidbody Rigidbody;
    float MoveSpeed;
    public MovementJoystick(Rigidbody rigidbody, FixedJoystick fixedJoystick, float moveSpeed)
    {
        Rigidbody = rigidbody;
        MoveSpeed = moveSpeed;
        FixedJoystick = fixedJoystick;
    }

    public void JoystickOverride()
    {
        Rigidbody.velocity = new Vector3(FixedJoystick.Horizontal * MoveSpeed, 0, FixedJoystick.Vertical * MoveSpeed);
    }

}

public class AimJoystick : IAimJoystick
{
    Rigidbody _rigidbody;

    public AimJoystick(Rigidbody rigidbody)
    {
        _rigidbody = rigidbody;
    }
    public Quaternion LookRotation()
    {
        return Quaternion.LookRotation(_rigidbody.velocity);
    }
}
[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _movementJoystick;
    [SerializeField] private FixedJoystick _aimJoystick;
    [SerializeField] private float _moveSpeed;


    MovementJoystick movementObj;
    AimJoystick aimObj;

    private void Start()
    {
        aimObj = new AimJoystick(_rigidbody);
        movementObj = new MovementJoystick(_rigidbody, _movementJoystick, _moveSpeed);
    }

    private void FixedUpdate()
    {
        movementObj.JoystickOverride();
        if (_aimJoystick.Horizontal != 0 || _aimJoystick.Vertical != 0)
        {
            transform.rotation = aimObj.LookRotation();
        }
    }


}
