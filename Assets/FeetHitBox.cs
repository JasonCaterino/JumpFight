using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetHitBox : MonoBehaviour {
    public Jumper jumper;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float y = .35f;
        float x = .0172f;
        //Vector2 p = new Vector3(jumper.transform.position.x + x, jumper.transform.position.y - y, 0);
        //transform.position = p;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("die");

        HeadHitBox head = collision.gameObject.GetComponent<HeadHitBox>();
        if (head)
        {
            if (gameObject.transform.parent.parent.GetComponent<Jumper>().falling == true)
            {
                collision.transform.parent.parent.GetComponent<Jumper>().die();
            }
        }
    }
}
