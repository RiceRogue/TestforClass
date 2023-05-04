using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public int x;
    

    // Start is called before the first frame update
    // this is the way
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            gameObject.transform.Translate(speed, 0, 0f); //Rotate to the right, can replace the rotation speed with a hard-coded value like 5f
            
        } else if (Input.GetKey(KeyCode.RightArrow))
             
        {
            gameObject.transform.Translate(-speed, 0, 0f); //rotate to the left

        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            
            gameObject.transform.Translate(0f, 0f, speed); //move forward

        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0f, 0f, -speed); //move backward
        }

        if (Input.GetKeyDown(KeyCode.Space)) //Add Jump code here!
        {


        } else if (Input.GetKeyUp(KeyCode.Space)){



        }



    }

   
}
