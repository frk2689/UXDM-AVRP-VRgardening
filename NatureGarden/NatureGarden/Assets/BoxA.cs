using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxA : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private bool seedinpot = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(seedinpot && other.CompareTag("WaterCollider")){
            anim.Play("FlowerPot");
        
        }
        if(other.CompareTag("Seed")){
            seedinpot = true;
        }
        
        
    }
}
