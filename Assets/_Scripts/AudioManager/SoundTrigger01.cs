using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger01 : MonoBehaviour
{
    
    public AudioManager Audio;
    //public Collider m_collider;
    public Focus focus;
    public GameObject holo;
  

    
    
    
 
    private void OnTriggerEnter(Collider other)
    {


        focus.ActiveAfterAudio();
        Audio.Play(gameObject.name);
        holo.SetActive(true);
        gameObject.SetActive(false);
        //m_collider.enabled = false;
        //Audio.numFaixaAudio++;
        
            
    }
}
