using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : MonoBehaviour
{
    Vector3 objectPos, targetPos;
    public float maxVel;
    public GameObject target;

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
        Vector3 newDir = targetPos - objectPos;
        transform.position += newDir.normalized * maxVel * Time.deltaTime;
    }
}
