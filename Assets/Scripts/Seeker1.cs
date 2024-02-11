using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker1 : MonoBehaviour
{
    Vector3 objectPos, targetPos;
    private float amaxVel;
    public GameObject target;
    private Arriver arriver;

    void Awake()
    {
        arriver = GetComponent<Arriver>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        amaxVel = arriver.maxVel;
        //get the object position
        objectPos = transform.position;
        //get the target position
        targetPos = target.transform.position;
        //update the motion to go to the target
        Vector3 newDir = targetPos - objectPos;
        transform.position += newDir.normalized * amaxVel * Time.deltaTime;
    }
}
