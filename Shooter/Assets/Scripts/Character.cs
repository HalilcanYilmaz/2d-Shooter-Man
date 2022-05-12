using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 0.0f;
    private Rigidbody2D _r2d;
    private Animator _anim;


    private void Start()
    {
        _r2d = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 2f;
        }
        else
        {
            speed = 0f;
        }

        _anim.SetFloat("speed", speed);
        _r2d.velocity = new Vector2(speed, 0f);






    }



















}
