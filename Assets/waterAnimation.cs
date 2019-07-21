using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterAnimation : MonoBehaviour {
     // using Itween for animation.
    public float height;
    public float time; //each cycle time
	void Start ()
    {
        iTween.MoveBy(this.gameObject, iTween.Hash("y", height, "time", time, "looptype", "pingpong","easetype",iTween.EaseType.easeInOutSine));
	}
	
	void Update () {
		
	}
}
