using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNotes : MonoBehaviour {

    [SerializeField]
    GameObject spawnanbleNote;

    [SerializeField]
    Camera camera;

    [SerializeField]
    float height;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Plane groundPlane = new Plane(Vector3.up, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            float rayDistance;

            if (groundPlane.Raycast(ray, out rayDistance))
            {
                GameObject.Instantiate(spawnanbleNote, ray.GetPoint(rayDistance) + Vector3.up * height, Quaternion.identity);
               // markerObject.position = ray.GetPoint(rayDistance);
            }
        }

            }
}
