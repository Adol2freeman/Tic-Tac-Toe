using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFN : MonoBehaviour
{

    float x = 0;
    float y = 0;
    [Header("Speed")]
    //public float x_speeed;
    //public float y_speeed;

    public float speed;
    public float angle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        this.transform.Translate(x + Time.deltaTime, y + Time.deltaTime * 10, 0);
    }
}
