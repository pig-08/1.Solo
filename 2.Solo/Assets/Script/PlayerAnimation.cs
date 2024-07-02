using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private int runAni = Animator.StringToHash("Run");
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void RunAnimator(Vector2 palyer)
    {
        _animator.SetBool(runAni, palyer.x != 0);
        _spriteRenderer.flipX = palyer.x != 0 ? palyer.x < 1 : _spriteRenderer.flipX;
    }
}
