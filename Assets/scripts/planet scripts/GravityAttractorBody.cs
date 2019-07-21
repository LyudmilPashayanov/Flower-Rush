using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractorBody : MonoBehaviour {
    public FauxGravityAttractor attractor;
    public Transform myTransform;
    public Rigidbody myRigidbody;
	// Use this for initialization
	void Start () {
        myTransform = transform;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
        myRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update ()
    {
        attractor.Attract(myTransform);
		
	}
}
