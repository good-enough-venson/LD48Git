using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public int lives = 0, gems = 0;
    public GameObject effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerStats.gems += gems;
            PlayerStats.lives += lives;

            if (effect) Instantiate(effect, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
