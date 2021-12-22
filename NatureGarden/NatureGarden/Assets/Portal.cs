using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    
    private Vector3 teleportDestination2 = new Vector3(13f, 3f, 11f);
    private Vector3 teleportDestination1 = new Vector3(-22f, 3f, 15f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Portal1")){
            transform.position = teleportDestination2;
        
        }
        if(other.CompareTag("Portal2")){
            transform.position = teleportDestination1;
        
        }
        
        
    }
}
