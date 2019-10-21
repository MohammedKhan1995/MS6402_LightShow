//---------------------------------------------------------------------------------------
//  2D Spawn objects when this object is hit
// David Dorrington, UEL Games, 2017 
//---------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAfterHit : MonoBehaviour {

   

    public GameObject[] GO_Spawnees;

 
    void OnCollisionEnter2D(Collision2D _cl_detected)
    {
       
        {
            foreach (GameObject _GO in GO_Spawnees)
            {
                Instantiate(_GO, transform.position, transform.rotation);
            }
        }
    }

}
