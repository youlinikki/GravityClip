using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform joueur1; // R�f�rence au transform du joueur 1
    public Transform joueur2; // R�f�rence au transform du joueur 2
    public float zoomSpeed = 2.0f; // Vitesse de zoom
    public float minZoom = 5.0f; // Zoom minimal
    public float maxZoom = 15.0f; // Zoom maximal
    public float smoothSpeed = 0.125f; // Vitesse de d�placement de la cam�ra

    void LateUpdate()
    {
        if (joueur1 != null && joueur2 != null)
        {
            Vector3 milieu = (joueur1.position + joueur2.position) / 2f;
            float distance = Vector3.Distance(joueur1.position, joueur2.position);
            float newZoom = Mathf.Lerp(maxZoom, minZoom, distance / maxZoom);

            transform.position = Vector3.Lerp(transform.position, new Vector3(milieu.x, transform.position.y, -newZoom), smoothSpeed * Time.deltaTime);
        }
    }
}