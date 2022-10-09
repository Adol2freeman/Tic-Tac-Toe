using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public Transform BBB;
    public GameObject Prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            A();
        }
    }

    void A()
    {
        Instantiate(Prefab, BBB.position, BBB.rotation);
    }
}
