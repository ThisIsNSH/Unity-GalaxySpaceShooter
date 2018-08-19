using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    private float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y >= 6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
