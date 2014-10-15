using UnityEngine;
using System.Collections;

public class rotation : MonoBehaviour {

    public float rotationSpeed = 100.0f;
    public float moveSpeed = 14.0f;
    public float acceleration = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //transform.position = transform.position + (moveSpeed * Vector3.right) * Time.deltaTime;
        //gameObject.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);

        transform.Translate(acceleration * Time.deltaTime, 0, 0);
        if (acceleration < moveSpeed)
        {
            acceleration += 0.5f;
        }
	}
}   
