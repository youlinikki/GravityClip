using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;



public class PressurePlate : MonoBehaviour
{
    public bool Pressure;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pressure = true;
            
        }
        
        else
        {
            Pressure = false;
        }
    }


  
}
