using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;
    public Vector3 offsetRotation;
	void Update ()
    {
        
        transform.position = player.position + offSet;
       // transform.eulerAngles = player.eulerAngles+offsetRotation;
	}
}
