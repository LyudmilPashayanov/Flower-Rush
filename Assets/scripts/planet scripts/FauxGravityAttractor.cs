using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{
    public float gravity = -10f;
    public Rigidbody rb;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }
    public void Attract(Transform Player)
    {
        Vector3 GravityUp = (Player.position - transform.position).normalized; // dokolkoto razbiram tova durji geroq ni izpraven
        Vector3 BodyUp = Player.up;
        Player.GetComponent<Rigidbody>().AddForce(GravityUp * gravity); // tova durpa geroq ni dokato e izpraven nadolu s gravitaciq -10
        Quaternion targetRotation = Quaternion.FromToRotation(BodyUp, GravityUp) * Player.rotation;
        Player.rotation = Quaternion.Slerp(Player.rotation, targetRotation, 50 * Time.deltaTime);

            
    }
}
