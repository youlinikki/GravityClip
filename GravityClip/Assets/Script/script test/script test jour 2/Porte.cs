using UnityEngine;

public class Porte : MonoBehaviour
{
    public GameObject pressurePlate1;
    public GameObject pressurePlate2;
    public GameObject door;

    private bool plate1Pressed = false;
    private bool plate2Pressed = false;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == pressurePlate1)
        {
            plate1Pressed = true;
        }
        else if (other.gameObject == pressurePlate2)
        {
            plate2Pressed = true;
        }

        TryOpenDoor();
    }



    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == pressurePlate1)
        {
            plate1Pressed = false;
        }
        else if (other.gameObject == pressurePlate2)
        {
            plate2Pressed = false;
        }

        TryOpenDoor();
    }

    private void TryOpenDoor()
    {
        if (plate1Pressed && plate2Pressed)
        {
            door.SetActive(false); // Ouvre la porte
        }
        else
        {
            door.SetActive(true); // Ferme la porte
        }
    }
}
