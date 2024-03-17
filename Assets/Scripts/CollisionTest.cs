using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("work");
        Body b = other.GetComponent<Body>();
        b.AddDamage();
    
    }
}
