using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] // Assurez-vous qu'un Rigidbody2D est attaché au GameObject
public class DeplacementPersonnage : MonoBehaviour
{
    public float vitesseDeplacement = 5f; // Vitesse de déplacement du personnage
    public float forceSaut = 10f; // Force du saut
    private Rigidbody2D rb; // Référence au composant Rigidbody2D
    private bool vaADroite = true; // Variable pour suivre la direction du personnage

    // Méthode appelée lorsque le script est initialisé
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtenez le Rigidbody2D attaché au GameObject
        rb.freezeRotation = true; // Empêcher la rotation du Rigidbody2D
    }

    // Méthode appelée à chaque frame
    void Update()
    {
        // Déplacement horizontal du personnage
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

    // Méthode pour retourner le personnage
    void RetournerPersonnage()
    {
        vaADroite = !vaADroite;
        Vector3 nouvelleEchelle = transform.localScale;
        nouvelleEchelle.x *= -1;
        transform.localScale = nouvelleEchelle;
    }

    // Méthode pour gérer le saut
    void Sauter()
    {
        rb.AddForce(Vector2.up * forceSaut, ForceMode2D.Impulse); // Appliquer une force de saut
    }
}
