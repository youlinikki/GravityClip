using System.Collections;
using UnityEditor.ShortcutManagement;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] // Assurez-vous qu'un Rigidbody2D est attach� au GameObject
public class DeplacementPersonnage : MonoBehaviour
{
    public float vitesseDeplacement = 5f; // Vitesse de d�placement du personnage
    public float forceSaut = 10f; // Force du saut
    private Rigidbody2D rb; // R�f�rence au composant Rigidbody2D
    public bool vaADroite = true; // Variable pour suivre la direction du personnage

    public bool IsJumping = false;

    // M�thode appel�e lorsque le script est initialis�
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtenez le Rigidbody2D attach� au GameObject
        rb.freezeRotation = true; // Emp�cher la rotation du Rigidbody2D
    }

    // M�thode appel�e � chaque frame
    void Update()
    {
        Debug.Log(IsJumping);

        // D�placement horizontal du personnage
        float deplacementHorizontal = Input.GetAxis("Horizontal") * vitesseDeplacement * Time.deltaTime;
        Vector2 deplacement = new Vector2(deplacementHorizontal, 0);
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

        // Gestion du saut
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Sauter();
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

    // M�thode pour g�rer le saut
    void Sauter()
    {

        
        if (!IsJumping)
        { 
        
            rb.AddForce(Vector2.up * forceSaut, ForceMode2D.Impulse); // Appliquer une force de saut
            StartCoroutine(sauterCD());
        }

    }


    private IEnumerator sauterCD()
    {
        IsJumping = true;
        yield return new WaitForSeconds(1f);
        IsJumping = false;
    }

}
