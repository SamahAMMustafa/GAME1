using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //set the lowerbound to -12
    private float lowerBound = -12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//if the position of object is < lowerbound
        if(transform.position.z < lowerBound)
        {
        	//destroy the object
        	Destroy(gameObject);
        }
    }
}
