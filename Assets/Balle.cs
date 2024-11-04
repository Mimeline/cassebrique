using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour
{
    public Vector3 deplacement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        deplacement = Vector3.Reflect(deplacement, collision.contacts[0].normal);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = deplacement;
    }
}
