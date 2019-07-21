using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour {

   public Material body;

    Color pink = new Color32(171, 51, 134,255);

    public void Start()
    {
        body.color = pink;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "enemy")
        {
            body.color = Color.red;
            Debug.Log("change color;");
        }
    }

}
