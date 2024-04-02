using UnityEngine;

public class PlayerMovementV2 : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private float _horizontalInput;

    private float _verticalInput;

    private Vector3 _direction;

    // Update is called once per frame
    void FixedUpdate()
    {
        MovingPlayer();
    }

    void MovingPlayer()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        _direction = new Vector3(_horizontalInput, _verticalInput, 0);
        transform.position += _direction * _speed * Time.deltaTime;
    }
}
