using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private float movespeed;
    private float dirX, dirY, dirZ;
    
    public bool isgrounded = true;

    public GameManager theGameManager;
    public int jump = 7;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movespeed;
        dirZ= Input.GetAxis("Vertical") * movespeed;

       
            if ((Input.GetKeyDown(KeyCode.Space)) && isgrounded == true)
            {
                rb.velocity += jump * Vector3.up;
            }
       
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        

        
        if (collision.gameObject.tag == "Lava")
        {
            theGameManager.Reset();
           
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isgrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isgrounded = false;
    }


}
