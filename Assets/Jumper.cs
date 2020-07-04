using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {
    public int playerNum;
    float p = 0;
    float jumpHeight =25f;
    int speed = 90;
    int jumpSpeed = 90;
    bool facingRight = true;
    public bool canJump = true;
    public Sprite grave;
    bool alive = true;
    public bool falling = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (alive)
        {
            if (Time.timeScale != 0)
            {

                if (playerNum == 1)
                {

                    if (Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        p = gameObject.transform.position.y;
                    }
                    if (Input.GetKey(KeyCode.LeftArrow))
                    {
                        facingRight = false;
                        transform.localRotation = Quaternion.Euler(0, 0, 0);
                        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
                    }
                    if (Input.GetKey(KeyCode.RightArrow))
                    {
                        facingRight = true;
                        transform.localRotation = Quaternion.Euler(0, 180, 0);
                        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

                    }
                    //if (Input.GetKey(KeyCode.DownArrow))
                    //{

                    //    transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
                    //}
                    if (Input.GetKey(KeyCode.UpArrow))
                    {
                        if (canJump == true)
                        {
                            jump(p);
                        }

                    }
                    if (Input.GetKeyUp(KeyCode.UpArrow))
                    {
                        canJump = false;
                        falling = true;
                        gameObject.GetComponent<Rigidbody2D>().gravityScale = 30;
                    }
                }
                if (playerNum == 2)
                {
                    if (Input.GetKeyDown(KeyCode.W))
                    {
                        p = gameObject.transform.position.y;
                    }
                    if (Input.GetKey(KeyCode.A))
                    {
                        facingRight = false;
                        transform.localRotation = Quaternion.Euler(0, 0, 0);
                        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
                    }
                    if (Input.GetKey(KeyCode.D))
                    {
                        facingRight = true;
                        transform.localRotation = Quaternion.Euler(0, 180, 0);
                        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

                    }
                    //if (Input.GetKey(KeyCode.S))
                    //{

                    //    transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
                    //}
                    if (Input.GetKey(KeyCode.W))
                    {
                        if (canJump == true)
                        {
                            jump(p);
                        }

                    }
                    if (Input.GetKeyUp(KeyCode.W))
                    {
                        canJump = false;
                        falling = true;
                        gameObject.GetComponent<Rigidbody2D>().gravityScale = 30;
                    }
                }
            }
        }
    }

    void jump(float p)
    {
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
        
        if (transform.position.y <= p+jumpHeight)
        {
            transform.position += new Vector3(0, jumpSpeed * Time.deltaTime, 0);
        }
        if (transform.position.y > p+jumpHeight)
        {
            canJump = false;
            falling = false;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 30;

        }
    }

    public void die()
    {
        print("d");
        this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        Destroy(gameObject);
        alive = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        canJump = true;
        
    }
}
