using UnityEngine;

public class GestionCamera : MonoBehaviour
{
    public Transform joueur; // R�f�rence au transform du joueur 1
    public Transform joueur2; // R�f�rence au transform du joueur 2
    public Camera cameraJoueur1; // R�f�rence � la cam�ra du joueur 1
    public Camera cameraJoueur2; // R�f�rence � la cam�ra du joueur 2
    public float distanceSeperation = 10f; // Distance � partir de laquelle les �crans se s�pareront

    void Update()
    {
        if (joueur != null && joueur2 != null && cameraJoueur1 != null && cameraJoueur2 != null)
        {
            // Calculez la distance entre les deux joueurs
            float distance = Vector3.Distance(joueur.position, joueur2.position);

            // Si la distance entre les deux joueurs est sup�rieure � la distance de s�paration
            if (distance > distanceSeperation)
            {
                // Activez les deux cam�ras et positionnez-les pour qu'elles regardent chacune un joueur
                cameraJoueur1.enabled = true;
                cameraJoueur2.enabled = true;
                Vector3 milieu = (joueur.position + joueur2.position) / 2f;
                cameraJoueur1.transform.position = new Vector3(milieu.x, cameraJoueur1.transform.position.y, cameraJoueur1.transform.position.z);
                cameraJoueur2.transform.position = new Vector3(milieu.x, cameraJoueur2.transform.position.y, cameraJoueur2.transform.position.z);
            }
            else
            {
                // D�sactivez la cam�ra du joueur 2 et positionnez la cam�ra du joueur 1 pour qu'elle filme les deux joueurs
                cameraJoueur1.enabled = true;
                cameraJoueur2.enabled = false;
                Vector3 milieu = (joueur.position + joueur2.position) / 2f;
                cameraJoueur1.transform.position = new Vector3(milieu.x, cameraJoueur1.transform.position.y, cameraJoueur1.transform.position.z);
            }
        }
    }
}
