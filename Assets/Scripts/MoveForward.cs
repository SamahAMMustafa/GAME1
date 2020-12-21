using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // objects move at the speed of ..
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //object move forward * the time given
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
