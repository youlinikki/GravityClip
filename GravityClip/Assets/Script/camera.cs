using UnityEngine;

public class GestionCamera : MonoBehaviour
{
    public Transform joueur; // Référence au transform du joueur 1
    public Transform joueur2; // Référence au transform du joueur 2
    public Camera cameraJoueur1; // Référence à la caméra du joueur 1
    public Camera cameraJoueur2; // Référence à la caméra du joueur 2
    public float distanceSeperation = 10f; // Distance à partir de laquelle les écrans se sépareront

    void Update()
    {
        if (joueur != null && joueur2 != null && cameraJoueur1 != null && cameraJoueur2 != null)
        {
            // Calculez la distance entre les deux joueurs
            float distance = Vector3.Distance(joueur.position, joueur2.position);

            // Si la distance entre les deux joueurs est supérieure à la distance de séparation
            if (distance > distanceSeperation)
            {
                // Activez les deux caméras et positionnez-les pour qu'elles regardent chacune un joueur
                cameraJoueur1.enabled = true;
                cameraJoueur2.enabled = true;
                Vector3 milieu = (joueur.position + joueur2.position) / 2f;
                cameraJoueur1.transform.position = new Vector3(milieu.x, cameraJoueur1.transform.position.y, cameraJoueur1.transform.position.z);
                cameraJoueur2.transform.position = new Vector3(milieu.x, cameraJoueur2.transform.position.y, cameraJoueur2.transform.position.z);
            }
            else
            {
                // Désactivez la caméra du joueur 2 et positionnez la caméra du joueur 1 pour qu'elle filme les deux joueurs
                cameraJoueur1.enabled = true;
                cameraJoueur2.enabled = false;
                Vector3 milieu = (joueur.position + joueur2.position) / 2f;
                cameraJoueur1.transform.position = new Vector3(milieu.x, cameraJoueur1.transform.position.y, cameraJoueur1.transform.position.z);
            }
        }
    }
}
