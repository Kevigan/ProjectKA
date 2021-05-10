using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController2D : MonoBehaviour
{
    Rigidbody2D rigid;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void Move(Vector2 direction)
    {
       
        //rigid.MovePosition(rigid.position + (direction * Time.fixedDeltaTime));
        rigid.velocity = direction * Time.fixedDeltaTime;
    }
}
