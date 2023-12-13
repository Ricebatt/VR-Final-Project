using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockAndKey : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "rust_key")
        {
            if(openTrigger)
            {
                Debug.Log ("Key entered");
                myDoor.Play("CageOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
        
        
    }
}
