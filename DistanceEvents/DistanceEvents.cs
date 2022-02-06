using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DistanceEvents : MonoBehaviour
{
    //Settings
    public float distanceThreshold;

    //Events
    public UnityEvent WhenOutOfDistance;
    public UnityEvent WhenInDistance;

    //If left empty, default will be the main camera
    public Transform target;

    private void Update()
    {
        //If there is no target reference
        if(target == null)
        {
            if (Vector3.Distance(Camera.main.transform.position, gameObject.transform.position) > distanceThreshold)
            {
                WhenOutOfDistance.Invoke();
            }
            else
            {
                WhenInDistance.Invoke();
            }
        }
        //If there is a target reference
        else
        {
            if (Vector3.Distance(target.position, gameObject.transform.position) > distanceThreshold)
            {
                WhenOutOfDistance.Invoke();
            }
            else
            {
                WhenInDistance.Invoke();
            }
        }
    }
}
