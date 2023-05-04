using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    int x = 5;
    string s = "love";
    public float jumpForce = 2.5f;
    public Rigidbody rb;
    public Transform t;

    public GameObject ground;
    float offset;

    public bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        //offset = (transform.position.y - ground.transform.position.y) + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //if (transform.position.y - ground.transform.position.y < offset)
        //{
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                //Vector3.up = (0,1,0)
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        //}
    }


    private void OnCollisionStay(Collision collision)
    {
        string s = collision.gameObject.tag;
        if (s == "Ground")
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        string s = collision.gameObject.name;
        if (s == "Ground")
        {
            canJump = false;
        }
    }
}
