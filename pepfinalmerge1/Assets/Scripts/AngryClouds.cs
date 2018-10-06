using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryClouds : MonoBehaviour {

    private void OnTrigger2D(Collider2D other)
    {
        if(other.GetComponent<pepper> () != null)
        {
            GameControl.instance.PepDied();
        }
    }
}
