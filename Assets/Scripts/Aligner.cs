using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aligner : MonoBehaviour
{
    Vector3 objectOrientation, targetOrientation;
    public float maxRotRate;
    public GameObject target;
    private float timeCount = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
   void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.transform.rotation, timeCount);
        timeCount +=  maxRotRate * Time.deltaTime;
    }
}
