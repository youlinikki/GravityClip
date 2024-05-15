using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class Pressure : MonoBehaviour
{
    public bool IsPressure;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsPressure = true;

        }

        else
        {
            IsPressure = false;
        }
    }


  
}
