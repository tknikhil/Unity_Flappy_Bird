using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
	private Rigidbody2D mRigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        mRigidbody2d=GetComponent<Rigidbody2D>();
		mRigidbody2d.velocity=new Vector2 (GameControl.instance.scrollSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
		if(GameControl.instance.gameover==true){
			mRigidbody2d.velocity=Vector2.zero;
		}
    }
}
