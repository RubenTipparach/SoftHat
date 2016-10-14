using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelScaler : MonoBehaviour {

    float scaleTransform = 1;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Equals))
        {
            scaleTransform += .1f;
            transform.localScale = (new Vector3(scaleTransform, scaleTransform, scaleTransform));
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            scaleTransform -= .1f;
            transform.localScale = (new Vector3(scaleTransform, scaleTransform, scaleTransform));
        }

    }
}
