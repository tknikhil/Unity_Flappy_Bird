using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	
	public float upForce=200f;
	private bool isDead=false;
	private Rigidbody2D mRigidBody2D;
	private Animator anim;

	
    // Start is called before the first frame update
    void Start()
    {
        mRigidBody2D=GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		if(isDead==false){
			if(Input.GetMouseButtonDown(0)){
				mRigidBody2D.velocity= Vector2.zero;
				mRigidBody2D.AddForce(new Vector2(0 /*x axis*/,upForce/*y axis*/));
				anim.SetTrigger("Flap");
                FindObjectOfType<AudioManager>().Play("Flap");
			}
		}
        
    }
    void OnCollisionEnter2D()
    {
        mRigidBody2D.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        GameControl.instance.BirdDied();
    }
}
