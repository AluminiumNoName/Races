using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public RouteCheck finishPoint;
    

    private void OnTriggerEnter(Collider other)
    {
       
        if (finishPoint.isActiveForPlayer)
        { 
            Timer timer = other.GetComponent<Timer>();
               if (timer != null)
               {
                  timer.hasFinished = true;
               }
        }

       
    }
}
