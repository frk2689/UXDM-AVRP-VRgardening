using System.Collections;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public int pourTreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;

    private bool isPouring = false;
    private StreamMine currentStream = null;

    private void Update(){
        bool pourCheck = CalculatePourAngle() < pourTreshold;

        if(isPouring != pourCheck){
            isPouring = pourCheck;

            if (isPouring){
                StartPour();
            }
            else{
                EndPour();
            }
        }

    }

    private void StartPour(){
        print("Start");
        currentStream = CreateStream();
        currentStream.Begin();


    }

    private void EndPour(){
        print("End");
        currentStream.End();
        currentStream = null;

    }

    private float CalculatePourAngle(){
        return transform.forward.y *Mathf.Rad2Deg;
    }

    private StreamMine CreateStream(){
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        return streamObject.GetComponent<StreamMine>();
    }
}
