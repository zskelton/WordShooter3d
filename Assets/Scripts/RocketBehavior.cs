using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBehavior : MonoBehaviour
{
    public float speed = 10f;

    private bool firing;
    private Vector3 defaultPos;

    void Start()
    {
        defaultPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            firing = true;
        }

        if(firing)
        {
            transform.position = transform.position + new Vector3(0, 0, 1.0f * -speed * Time.deltaTime);
            if(transform.position.y > 25f)
            {
                transform.position = defaultPos;
                firing = false;
            }
        }
    }
}
