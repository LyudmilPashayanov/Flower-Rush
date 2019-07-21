using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class legsMove : MonoBehaviour
{
    public void legMove()
    {
        GetComponent<Animation>().Play();
    }
}
