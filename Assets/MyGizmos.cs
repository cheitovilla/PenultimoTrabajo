using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmos : MonoBehaviour {


    void OnDrawGizmos()
    {
     //   Gizmos.DrawCube(new Vector3(0, 0, 0), new Vector3(1, 2, 3));
      //  Gizmos.DrawRay(new Ray(new Vector3(0, 0, 0), new Vector3(0, 1, 0)));
        Ray r = new Ray();
        r.origin = new Vector3(0, 0, 0);
        r.direction = new Vector3(0, 1, 0);
        Gizmos.DrawRay(r);
        //Gizmos.DrawLine(transform.position, new Vector3(0, 0, 0));
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
