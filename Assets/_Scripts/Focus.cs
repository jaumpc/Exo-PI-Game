using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus : MonoBehaviour
{
    public GameObject focus01;
    public GameObject BatCell;
    

    void Start() {

       focus01.SetActive(false);
       BatCell.SetActive(false);

    }
    public void ActiveAfterAudio()
    {
       
        StartCoroutine(WaitForSound());
    }

    public IEnumerator WaitForSound()
    {
       yield return new WaitForSeconds(90);
       focus01.SetActive(true);
       BatCell.SetActive(true);
    }
}
