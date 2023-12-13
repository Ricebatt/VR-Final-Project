using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateScript : MonoBehaviour
{
    public GameObject cube;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(cube, 0f);
        }
    }
}
