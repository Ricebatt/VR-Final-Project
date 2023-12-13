using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHeli : MonoBehaviour
{
    [SerializeField] private Animator myHeli = null;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            myHeli.Play("heli", 0, 0.0f);
            
        }
    }
}
