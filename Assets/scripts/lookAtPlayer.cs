using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 Speed = new Vector3(0.0f, 0.0f,2.0f);
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(player);
        if ((transform.position - player.position).magnitude > 0.0000001f) 
        {
            transform.Translate(Speed * Time.deltaTime);
        }
	}
}
