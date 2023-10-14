using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSprite : MonoBehaviour
{
    public Sprite spU, spD, spL, spR;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Up")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spU;
        }
        else if (other.gameObject.tag == "Down")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spD;
        }
        else if (other.gameObject.tag == "Left")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spL;
        }
        else if (other.gameObject.tag == "Right")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = spR;
        }
    }
}
