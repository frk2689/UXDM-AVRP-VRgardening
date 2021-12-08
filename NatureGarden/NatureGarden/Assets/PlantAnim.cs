using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantAnim : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider col){
        anim.Play("growAnimation2");
        print("is hitting");
    }
}