using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{
    [SerializeField] float thrusterForce = 1000f;
    [SerializeField] float tiltAngle = 100f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;

        if (Input.GetKey(KeyCode.Space))
        {

            rb.AddRelativeForce(transform.up * (thrusterForce * Time.deltaTime));
        }

        if (!Mathf.Approximately(tiltAroundZ, 0f))
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 0f, tiltAroundZ * Time.deltaTime));
        }
    }
}
