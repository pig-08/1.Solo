using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput _playerInput;
    private PlayerAnimation _playerAnimation;
    private Rigidbody2D _playerrigidbody2D;
    private bool _ground = true;
    [SerializeField]private int Speed = 10;
    private void Awake()
    {
        _playerrigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    private void FixedUpdate()
    {
        Vector2 dir = _playerInput.PlayerDir;
        _playerrigidbody2D.velocity = dir.normalized * Speed;
        _playerAnimation.RunAnimator(_playerInput.PlayerDir);
    }
}
