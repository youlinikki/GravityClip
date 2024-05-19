
using UnityEngine;

public class AttraperPiece : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip PlayCoinSound;

    private void Start(){

        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            audioSource.PlayOneShot(PlayCoinSound, 1);
            Destroy(gameObject,  0.1f);
        }
    }
}
