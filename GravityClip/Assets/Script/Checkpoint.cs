
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
     GameObject respawn1;
     GameObject respawn2;

    public Vector3 respawnpoint1;

     public Vector3 respawnpoint2;
     
    void Start()
    {
        // je récupère les deux points de réaparition
        respawn1 =  GameObject.Find("Respawnpoint haut");
        respawn2 =  GameObject.Find("Respawnpoint bas");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // quand le joueur touche le checkpoint, je modifie la position des points de réaparition
           respawn1.transform.position = respawnpoint1;
           respawn2.transform.position = respawnpoint2;
        }
    }
}
