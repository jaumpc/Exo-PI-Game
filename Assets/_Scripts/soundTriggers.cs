using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTriggers : MonoBehaviour
{

    public AudioManager Audio;
    public Collider m_collider;

    
    
    
 
    private void OnTriggerEnter(Collider other)
    {
        Audio.Play("Faixa01");
        m_collider.enabled = false;
            
    }
}
