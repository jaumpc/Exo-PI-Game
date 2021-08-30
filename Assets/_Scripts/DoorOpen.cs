using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    
    public Animator DoorAnimator;



 
    private void OnTriggerEnter(Collider other)
    {
       DoorAnimator.SetBool("open", true);
       Destroy(gameObject);
    }
    
}
