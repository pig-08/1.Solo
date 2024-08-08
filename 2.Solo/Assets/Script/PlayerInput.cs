using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float x;
    public Vector2 PlayerDir { get; set;}
    private Rigidbody2D _rigidbody2D;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        PInput();
    }
    private void PInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        PlayerDir = new Vector2(x, _rigidbody2D.velocity.y);
    }
}
