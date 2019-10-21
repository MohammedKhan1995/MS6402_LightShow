using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  CameraFollow : MonoBehaviour {

    public GameObject GO_Target;

 
	void Update () 
    {
        
        if (GO_Target)
            transform.position = new Vector3(GO_Target.transform.position.x, GO_Target.transform.position.y,transform.position.z);       
	}

    
}
