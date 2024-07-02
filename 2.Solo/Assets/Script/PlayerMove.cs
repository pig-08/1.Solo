using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerAnimation _playerAnimation;
    private Rigidbody2D _playerrigidbody2D;
    [SerializeField]private int Speed = 10;
    private void Awake()
    {
        _playerrigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    private void FixedUpdate()
    {
        _playerrigidbody2D.velocity = _playerInput.PlayerDir * Speed;
        _playerAnimation.RunAnimator(_playerInput.PlayerDir);
    }
}
