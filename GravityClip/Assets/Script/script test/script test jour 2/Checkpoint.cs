using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    GameController gameController;
    public Transform respawnPoint;

    SpriteRenderer sprtiteRenderer;
    public Sprite passive, active;
    Collider2D coll;


    private void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
        sprtiteRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameController.UpdateCheckpoint(respawnPoint.position);
            sprtiteRenderer.sprite = active;
            coll.enabled = false;
        }
    }


}
