using UnityEngine;

public class DoorSetActive : MonoBehaviour
{

    public void OpenDoor(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }

    public void CloseDoor(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
}