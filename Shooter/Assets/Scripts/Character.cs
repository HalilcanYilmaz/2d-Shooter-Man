using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D _r2d;
    private Animator _anim;
    Vector3 charPos;
    [SerializeField] GameObject _camera;
    SpriteRenderer _sprite;

    private void Start()
    {
        _r2d = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        charPos = transform.position;
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // _r2d.velocity = new Vector2(speed, 0f);
    }
    private void Update()
    {
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos;
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _anim.SetFloat("speed", 0f);
        }
        else
        {
            _anim.SetFloat("speed", 1f);
        }

        if (Input.GetAxis("Horizontal") > 0.01f) 
        {        
            _sprite.flipX = false;

        } else if (Input.GetAxis("Horizontal") < -0.01)
        {
            _sprite.flipX = true;
        }
        


    }

    private void LateUpdate()
    {
        _camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1f);
    }

















}
