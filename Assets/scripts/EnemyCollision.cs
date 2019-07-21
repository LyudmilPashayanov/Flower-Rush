using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            Debug.Log("You hit an enemy :( .");
            GameManager gm = gameObject.GetComponent<GameManager>();
            gm.endGame();
        }
        

    }
}
