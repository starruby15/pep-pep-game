using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happycloud : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<pepper>() != null)
        {
            GameControl.instance.PepScored();
        }
        Debug.Log("On Trigger Entered"); 
    }
}
