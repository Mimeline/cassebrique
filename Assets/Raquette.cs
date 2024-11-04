using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour
{
    public float speed = 10f;
    public float clampX = 10f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
        Vector3 pos = transform.position;
        Vector3 monVector;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * (-speed) * Time.deltaTime);

        }

    }
}
