using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateAround : MonoBehaviour {

    [SerializeField]
    private Transform _objectToRotate;

    [SerializeField]
    private float _speed = 1f;
	
	// Update is called once per frame
	private void FixedUpdate () {
        transform.LookAt(_objectToRotate);
        transform.Translate(Vector3.right * Time.deltaTime * _speed);

        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time), transform.position.z);
	}
}
