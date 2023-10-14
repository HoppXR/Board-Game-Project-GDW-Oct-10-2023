using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barracks : MonoBehaviour
{

    public int value;
    public AudioClip scoreSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            AudioSource.PlayClipAtPoint(scoreSound, transform.position);
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            AudioSource.PlayClipAtPoint(scoreSound, transform.position);
        }
    }

}
