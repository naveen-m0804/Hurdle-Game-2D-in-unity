using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runraja : MonoBehaviour
{
    public float speed;
    public float jumpforce;
    private Rigidbody2D rb;
    public Score cc;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveinp=Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveinp,0,0)*speed*Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)&&Mathf.Abs(rb.velocity.y)<0.001f)
        {
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag( "destory"))   //if(other.gameObject.tag=="destory")
        {
            cc.coincount++;
            Destroy(other.gameObject); 
        }  
    }
}   
