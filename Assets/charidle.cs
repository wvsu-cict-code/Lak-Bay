using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charidle : MonoBehaviour
{
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,5f); //destroy character intsantly

        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //code for getting keys and destroy box by clicking space
        {
            //Destroy(gameObject);

            rb2D.AddForce(Vector3.up * 300);//jump
        }

    }

    //private void OnMouseDown()
    //{
        //Destroy(gameObject); //destroy by clicking mouse
    //}
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if (collision.gameObject.CompareTag("objectex"))
        //{
            //Destroy(gameObject); //destroy object with the tag
       //}
    //}
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("objectex"))
        {
            Destroy(other.gameObject);
        }
    }
}
