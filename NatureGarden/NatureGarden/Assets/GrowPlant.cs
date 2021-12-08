using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowPlant : MonoBehaviour
{
public Animator anim;

    void OnCollisionEnter (Collision col){
        if (col.gameObject.name == "PlantEx3"){
            print("is colliding");
            gameObject.GetComponent<Animator>().Play("growAnimation2");
            anim.Play("growAnimation2");
        }
    }
}
