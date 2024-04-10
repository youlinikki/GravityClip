using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // Assurez-vous qu'un Rigidbody est attaché au GameObject
public class DeplacementPersonnage : MonoBehaviour
{
    public float vitesseDeplacement = 5f; // Vitesse de déplacement du personnage
    private Rigidbody rb; // Référence au composant Rigidbody
    private bool vaADroite = true; // Variable pour suivre la direction du personnage

    // Méthode appelée lorsque le script est initialisé
    void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Obtenez le Rigidbody attaché au GameObject
        rb.freezeRotation = true; // Empêcher la rotation du Rigidbody
    }

    // Méthode appelée à chaque frame
    void Update()
    {
        // Déplacement horizontal du personnage
        float deplacementHorizontal = Input.GetAxis("Horizontal") * vitesseDeplacement * Time.deltaTime;
        Vector3 deplacement = new Vector3(deplacementHorizontal, 0, 0);
        transform.Translate(deplacement);

        // Inversion de la direction du personnage
        if (deplacementHorizontal > 0 && !vaADroite)
        {
            RetournerPersonnage();
        }
        else if (deplacementHorizontal < 0 && vaADroite)
        {
            RetournerPersonnage();
        }
    }

    // Méthode pour retourner le personnage
    void RetournerPersonnage()
    {
        vaADroite = !vaADroite;
        Vector3 nouvelleEchelle = transform.localScale;
        nouvelleEchelle.x *= -1;
        transform.localScale = nouvelleEchelle;
    }

    // Méthode pour gérer la gravité
    void FixedUpdate()
    {
        rb.AddForce(Vector3.down * 9.81f); // Appliquer une force de gravité constante
    }
}

