using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator _animator;
    Rigidbody rb;
    private float m_jumpForce = 4;
    // Start is called before the first frame update
    void Start()
    {
        _animator = this.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * m_jumpForce,ForceMode.Impulse);
            _animator.SetTrigger("Jump");
        }
            if(Input.GetKey(KeyCode.W))
        {
            
            _animator.SetBool("walk1",true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("walk1",false);
        }
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetBool("idle2",true);
        }
        if (Input.GetMouseButtonDown(1))
        {
            _animator.SetTrigger("combo");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("idle2",false);
        }
    }
}
