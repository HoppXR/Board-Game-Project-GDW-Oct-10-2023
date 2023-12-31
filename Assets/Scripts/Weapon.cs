using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public int value;
    public AudioClip scoreSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            AudioSource.PlayClipAtPoint(scoreSound, transform.position);
            Destroy(gameObject);
            WeaponCounter.instance.IncreaseWeapons(value);        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            AudioSource.PlayClipAtPoint(scoreSound, transform.position);
            Destroy(gameObject);
            WeaponCounter.instance.IncreaseWeapons2(value);        }
    }

}
