using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private Rigidbody2D _rb;

    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector2 _movement;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovingPlayer();


    }


    void MovingPlayer()
    {
        _horizontalMovement = Input.GetAxis("Horizontal");
        _verticalMovement = Input.GetAxis("Vertical");

        _movement = new Vector2(_horizontalMovement, _verticalMovement);

        _rb.AddForce(_movement * _speed);

    }
}
