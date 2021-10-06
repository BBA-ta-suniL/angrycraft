using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_script : MonoBehaviour
{
    
    public AudioSource villager;
    
    public void PlayVillager () 
    {
        villager.Play();
    }

    void OnTriggerEnter () 
    {
        villager.Play();
    }

}
