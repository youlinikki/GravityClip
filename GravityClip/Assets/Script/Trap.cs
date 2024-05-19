
using UnityEngine;

public class Trap : MonoBehaviour
{
    GameObject Joueur1;
    GameObject Joueur2;

    GameObject respawnpoint1;
    GameObject respawnpoint2;

    GameObject fusionControl;

    private AudioSource audioSource;
    public AudioClip PlayDeathSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // je récupère les deux points de réaparition et les joueurs

        Joueur1 =  GameObject.Find("Joueur");
        Joueur2 =  GameObject.Find("Joueur2");
        respawnpoint1 =  GameObject.Find("Respawnpoint bas");
        respawnpoint2 =  GameObject.Find("Respawnpoint haut");
        fusionControl =  GameObject.Find("FusionControl");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //si joueur touché, je modifie leur position pour les mettre a celles des points de réaparition
            fusionControl.GetComponent<fusion>().etat=0;
            Joueur1.SetActive(true);
            Joueur2.SetActive(true);
            Joueur1.transform.position = respawnpoint1.transform.position;
            Joueur2.transform.position = respawnpoint2.transform.position;
            audioSource.PlayOneShot(PlayDeathSound, 1);
        }
    }
}
