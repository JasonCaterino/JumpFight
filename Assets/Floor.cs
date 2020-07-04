using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {

        collision.gameObject.GetComponent<Jumper>().canJump = true;
        collision.gameObject.GetComponent<Jumper>().falling = false;
    }
}
