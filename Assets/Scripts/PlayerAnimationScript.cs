using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
   

    private Animator _currentAnimation;
    // Start is called before the first frame update
    void Start()
    {
        _currentAnimation = GetComponent<Animator>();
        _currentAnimation.Play("PlayerIdleSouthAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            Debug.Log("down");
            _currentAnimation.Play("PlayerSouthAnimation");
        }
        else if (Input.GetKey("up") || Input.GetKey("w"))
        {
            Debug.Log("up");
            _currentAnimation.Play("PlayerNorthAnimation");
        }
        else if (Input.GetKey("left") || Input.GetKey("a"))
        {
            Debug.Log("left");
            _currentAnimation.Play("PlayerWestAnimation");
        }
        else if (Input.GetKey("right") || Input.GetKey("d"))
        {
            Debug.Log("right");
            _currentAnimation.Play("PlayerEastAnimation");
        }

    }
}
