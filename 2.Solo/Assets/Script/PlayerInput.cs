using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float x;
    public Vector2 PlayerDir { get; private set;}
    private void Update()
    {
        PInput();
    }
    private void PInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        PlayerDir = new Vector2(x,0);
    }
}
