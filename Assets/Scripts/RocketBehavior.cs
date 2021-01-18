using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{
    public float movementSpeed = 0.1f;

    private bool firing = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            firing = true;
        }

        if(firing)
        {
            transform.Translate(0f, movementSpeed*Time.deltaTime, 0f, Space.World);
            if (transform.position.y >= 10 && firing)
            {
                transform.position = new Vector3(0f, 0f, 5f);
                firing = false;
            }
        }
    }
}
