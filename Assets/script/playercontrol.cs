using UnityEngine;

public class playercontrol : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent <Rigidbody >();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float moveX =  0f;
       float moveZ = 0f;

    if(Input.GetKey(KeyCode.LeftArrow))
    moveX = 1f;
     if(Input.GetKey(KeyCode.UpArrow))
    moveZ = 1f;

    else if(Input.GetKey(KeyCode.DownArrow))
    moveZ = 1f;
     
    }
}
