using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteCheck : MonoBehaviour
{
    //public variables for next checkpoint, for whether point is active or not, for model of the checkpoint consequentionally
    public RouteCheck nextPoint;
    public bool isActiveForPlayer;
    public GameObject point;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isActiveForPlayer)
            {
                //this checkpoint no longer active for player nor visible
                isActiveForPlayer = false;
                point.SetActive(false);
                if(nextPoint != null)
                {


                    //enable next xheckpoint for player and make it visible
                    nextPoint.isActiveForPlayer = true;
                    nextPoint.point.SetActive(true);
                }

            }
            
        }
    }

}
