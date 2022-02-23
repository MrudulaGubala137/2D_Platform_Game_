using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenLog : MonoBehaviour
{
    // Start is called before the first frame update
    public BuoyancyEffector2D buoyancyEffector;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        buoyancyEffector.flowMagnitude = 10f;   
    }
}

