






using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton : MonoBehaviour
{
    [SerializeField] private DoorSetActive door;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            door.OpenDoor(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            door.CloseDoor(gameObject);
        }
    }

}
