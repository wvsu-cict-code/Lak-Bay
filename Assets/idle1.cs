using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idle1 : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,5f); //destroy character intsantly

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //code for getting keys and destroy box by clicking space
        {
            //Destroy(gameObject);

            rb.AddForce(Vector3.up * 500);
        }

    }

    private void OnMouseDown()
    {
        Destroy(gameObject); //destroy by clicking mouse
    }

}
