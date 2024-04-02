using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    [SerializeField]
    private Animator _southAnimation;

    [SerializeField]
    private Animation _northAnimation;

    [SerializeField]
    private Animation _westAnimation;

    [SerializeField]
    private Animator _eastAnimation;

    private Animator _currentAnimation;
    // Start is called before the first frame update
    void Start()
    {
        _currentAnimation = _southAnimation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("Down"))
        {
            _currentAnimation = _southAnimation;
        }
        else if (Input.GetKeyDown("Up"))
        {
            //_currentAnimation = _northAnimation;
        }
    }
}
