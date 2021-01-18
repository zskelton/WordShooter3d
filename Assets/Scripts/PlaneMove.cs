using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    private float movementSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update the position
        transform.position = transform.position + new Vector3(0, 0, 1.0f * -movementSpeed * Time.deltaTime);
        if(transform.position.z <= -10.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 50f);
        }
    }
}
