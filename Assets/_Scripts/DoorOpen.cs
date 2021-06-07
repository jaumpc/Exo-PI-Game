using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public CanvasGroup openUI;
    public Animator DoorAnimator;


    public void OnButtonClick1()
    {
        openUI.alpha = 0;
        DoorAnimator.SetBool("open", true);
    }
 
    private void OnTriggerEnter(Collider other)
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "battery"){
           openUI.alpha = 1f;
           openUI.blocksRaycasts = true; 
        }
     
    }
    private void OnTriggerExit(Collider other)
    {
        openUI.alpha = 0;
        
    }
}
