using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepper : MonoBehaviour {

    public float upforce = 200f;

    private bool isDead = false;

    private Rigidbody2D rb2d;
    private Animator anim; 

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>(); 
        rb2d = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
        if(isDead == false)
        {
            if(Input.GetMouseButtonDown(0))
            {  
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upforce));
                anim.SetTrigger("Spin");
            }
        }
		
	}

    private void OnCollisionEnter2D()
    {
        rb2d.velocity = Vector2.zero; 
        isDead = true;
        anim.SetTrigger("Die");
        GameControl.instance.PepDied(); 
        
    }
}
