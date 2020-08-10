using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{


    private void OnTriggerEnter(Collider other) 
    {

        Debug.Log("Der Trigger wurde ausgelöst");

    }

    void OnCollisionEnter(Collision collision) 
    {

        
        Debug.Log("Eine Kollision hat stattgefunden");
    }


    // Called each frame due the collision
    private void OnCollisionStay(Collision collision) 
    {
            Debug.Log("Die Kollision findet immernoch statt");
    } 


    private void OnCollisionExit(Collision collision) 
    {
        Debug.Log("Die Kollision ist vorbei");

    }



}
