using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   	public float horizonatlInput;
	public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	// hav eplayer move right and left with the speed put
        horizonatlInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizonatlInput * Time.deltaTime * speed);
    }
}
