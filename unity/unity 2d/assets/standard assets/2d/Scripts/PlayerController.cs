using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float movspeed;
    public float jumphight;
    public GameObject player;
    private bool facingright;
    public Text gamepoints;
    float currCountdownValue;
    public int playerpoints;
    
    Animator myAnim;
    SpriteRenderer sp;
    Vector3 artScaleCache;

    // Use this for initialization
    void Start () {
        playerpoints = 0;
        facingright = true;
        gamepoints.text = playerpoints.ToString();
        myAnim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        myAnim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumphight);
            myAnim.SetBool("isGrounded", false);


        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movspeed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().transform.localScale = new Vector3(10f, 10f, 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-movspeed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().transform.localScale = new Vector3(-10f, 10f, 1);


        }
        gamepoints.text =playerpoints.ToString();

    }
    
    private void Flip(float horizontal) {
        if(horizontal>0 && !facingright || horizontal<0 && facingright)
        {
            facingright = !facingright;
            Vector3 theScale = transform.localScale;

            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
    private void OnTriggerEnter2D(Collider2D col) { 
        if (col.gameObject.tag == "Coin") { 
        
            Destroy(col.gameObject);
            
            playerpoints++;
        }
        if (col.gameObject.tag == "Teleport")
        {
            this.transform.position = new Vector3(-407.2f, -198.5f, -5);
        }
        if (col.gameObject.tag == "Terrain")
        {
            myAnim.SetBool("isGrounded", true);
        }
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }

}
