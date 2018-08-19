using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    public float speed = 5.0f;
    [SerializeField]
    private GameObject Laser;

    void Start () {
		
	}
	
	void Update () {
        Movement();
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(Laser, transform.position + new Vector3(0, 0.88f, 0), Quaternion.identity);
        }
    }

    private void Movement()
    {

        float input = Input.GetAxis("Horizontal");
        float input1 = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * input * Time.deltaTime);
        transform.Translate(Vector3.up * speed * input1 * Time.deltaTime);

        if (transform.position.y >=0.1f)
        {
            transform.position = new Vector3(transform.position.x, 0.1f, 0);
        }
        else if (transform.position.y <= -3.5f)
        {
            transform.position = new Vector3(transform.position.x, -3.5f, 0);
        }

        if (transform.position.x >= 11.5f)
        {
            transform.position = new Vector3(-11.5f, transform.position.y, 0);
        }
        else if (transform.position.x <= -11.5f)
        {
            transform.position = new Vector3(11.5f, transform.position.y, 0);
        }

    }
}
