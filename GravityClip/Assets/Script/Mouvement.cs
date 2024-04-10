using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // Assurez-vous qu'un Rigidbody est attach� au GameObject
public class DeplacementPersonnage : MonoBehaviour
{
    public float vitesseDeplacement = 5f; // Vitesse de d�placement du personnage
    private Rigidbody rb; // R�f�rence au composant Rigidbody
    private bool vaADroite = true; // Variable pour suivre la direction du personnage

    // M�thode appel�e lorsque le script est initialis�
    void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Obtenez le Rigidbody attach� au GameObject
        rb.freezeRotation = true; // Emp�cher la rotation du Rigidbody
    }

    // M�thode appel�e � chaque frame
    void Update()
    {
        // D�placement horizontal du personnage
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

    // M�thode pour retourner le personnage
    void RetournerPersonnage()
    {
        vaADroite = !vaADroite;
        Vector3 nouvelleEchelle = transform.localScale;
        nouvelleEchelle.x *= -1;
        transform.localScale = nouvelleEchelle;
    }

    // M�thode pour g�rer la gravit�
    void FixedUpdate()
    {
        rb.AddForce(Vector3.down * 9.81f); // Appliquer une force de gravit� constante
    }
}

