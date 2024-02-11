using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arriver : MonoBehaviour
{
    Vector3 objectPos, targetPos;
    public GameObject target;
    float currentDistance;
    public float maxVel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //get the object position
        objectPos = transform.position;
        //get the target position
        targetPos = target.transform.position;
        //update the motion to go to the target
        Vector3 newDir = targetPos - objectPos;//also can get this from a ray cast
        //check the current distance to target
        //adjust max speed based on the distance
        currentDistance = newDir.magnitude;
        if (currentDistance < 1.5) //more generally get the threshold distance from a collider
        {
            maxVel = 0.0f;
        }
        else if (currentDistance < 5) //generalize to a function to continuously vary - can Lerp 
        {
            maxVel = 1.0f;
        }

    }
}
