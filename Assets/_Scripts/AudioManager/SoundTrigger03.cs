using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger03 : MonoBehaviour
{
    public AudioManager Audio;
    //public Collider m_collider;
    public Animator holoAnim;
    public GameObject holo;
  

    
    
    
 
    private void OnTriggerEnter(Collider other)
    {


        Audio.Play(gameObject.name);
        holo.SetActive(true);
        holoAnim.SetTrigger("Talk");
        gameObject.SetActive(false);
        //m_collider.enabled = false;
        //Audio.numFaixaAudio++;
        
            
    }
}
