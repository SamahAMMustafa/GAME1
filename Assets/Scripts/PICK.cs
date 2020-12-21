using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PICK : MonoBehaviour
{
   void OnTriggerEnter(Collider collider)
   {
   	if(collider.gameObject.tag == "Player")
	   	{
	   		print ("Collected");
	   		Destroy(gameObject);
	   	}
   }
}
