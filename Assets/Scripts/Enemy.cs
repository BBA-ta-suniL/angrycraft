using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public AudioSource dieSound;
    public float health = 4f;

    void Start ()
    {
        dieSound = GetComponent<AudioSource> ();
    }

    void OnCollisionEnter2D (Collision2D colInfo) 
    {
        if (colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }        
    }

    void Die ()
    {
        dieSound.Play();
        Destroy(gameObject);
    }

}
