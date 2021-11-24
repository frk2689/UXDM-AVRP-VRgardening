using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHittingPlant : MonoBehaviour
{
    public Transform plantAnimation;
    //public GameObject stream;
    //public GameObject target;

    //private float wPos;
    //private float tPos;


    public LineRenderer lineRenderer = null;
    public Vector3 targetPosition = Vector3.zero;
    public GameObject plant;
    
    
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }


    void OnCollisionEnter (Collision collision) {
       
        //if (CanIsPouring & PositionIsInCollider) {
        //    WaitForEndOfFrame 3 seconds;
        //    Start animation;
        //}
        if(collision.gameObject == plant){
            print("I am touching plant.");
        }
       

    }

   /* void ComparePosition(){
        wPos = wateringCan.transform.position.x;
        tPos = target.transform.position.x;

        if(wPos == tPos){
            print ("it's hitting");
        }*/


    


}
