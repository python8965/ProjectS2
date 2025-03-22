using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;
    Rigidbody2D rigid;

    SpriteRenderer spriter;
    Animator anim;
    void Awake()
    {   
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    
    private void FixedUpdate()
    {
        //1. Èû 
        //rigid.AddForce(inputVec);
        //2. ¼Óµµ
        //rigid.linearVelocity = inputVec;


        Vector2 nextVec = inputVec.normalized * speed*Time.fixedDeltaTime;  
        //3. À§Ä¡ 
        rigid.MovePosition(rigid.position +nextVec);

    }
    private void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();

    }
    private void LateUpdate()
    {
        anim.SetFloat("Speed",inputVec.magnitude);
        
        if (inputVec.x != 0)
        {
            spriter.flipX = (inputVec.x < 0);
        }
    }
}
