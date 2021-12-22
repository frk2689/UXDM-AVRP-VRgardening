using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxA : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private bool blueseedinpot = false;
    [SerializeField] private bool redseedinpot = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(blueseedinpot && other.CompareTag("WaterCollider")){
            anim.Play("FlowerPot");
        
        }
        if(redseedinpot && other.CompareTag("WaterCollider")){
            anim.Play("FlowerPotRed");
        
        }
        if(other.CompareTag("seed blue")){
            blueseedinpot = true;
        }
        if(other.CompareTag("seed red")){
            redseedinpot = true;
        }
        
        
    }
}
