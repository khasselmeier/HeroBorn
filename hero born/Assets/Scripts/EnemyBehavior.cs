using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name =="player")
        {
            Debug.Log("player detected - attack!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "player")
        {
            Debug.Log("player out of range, resume patrol");
        }
    }
}
