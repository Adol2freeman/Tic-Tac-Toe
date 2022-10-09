using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_0 : MonoBehaviour
{
    public float speed = -20f;
    public Rigidbody2D rd;

    private void Start()
    {
        rd.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfrom)
    {
        
        Destroy(gameObject);
    }
}
