using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBehavior : MonoBehaviour
{
    public GameObject crashSmoke;
    public GameObject explosion;
    public float speed = 15f;

    private GameObject crashSmokeClone = null;

    private bool crashing;
    private Vector3 defaultPos;
    private Quaternion defaultRot;

    // Start is called before the first frame update
    void Start()
    {
        crashing = false;
        defaultPos = this.transform.position;
        defaultRot = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= -10.0f || transform.position.y <= 0.0f)
        {
            transform.position = defaultPos;
            crashing = false;
            if(crashSmokeClone)
            {
                Destroy(crashSmokeClone, 1);
            }
        }

        //update the position
        if (!crashing)
        {
            transform.position = transform.position + new Vector3(0, 0, 1.0f * -speed * Time.deltaTime);
        } else
        {
            transform.position = transform.position + new Vector3(0, 1.0f * -speed * Time.deltaTime, -0.1f);
        }

        //if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        //{
        //    TestCollision();
        //    crashing = true;
        //}
    }

    // When Hit
    private void OnCollisionEnter(Collision collision)
    {
        if(crashSmokeClone == null)
        {
            Instantiate(crashSmoke, transform.position, transform.rotation);
        } else
        {
            Destroy(crashSmokeClone, 1);
        }
        Instantiate(explosion, transform.position, transform.rotation);
    }

    // Test
    //private void TestCollision()
    //{
    //    crashSmokeClone = Instantiate(crashSmoke, transform.position, transform.rotation);
    //    Instantiate(explosion, transform.position, transform.rotation);
    //}
}
