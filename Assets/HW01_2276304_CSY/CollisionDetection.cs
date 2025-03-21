using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(collision.gameObject); 
            print($"{gameObject.name} has detected CollisionEnter: {collision.gameObject.name} and destroyed the Cube.");
        }
    }
}

