using UnityEngine;
using UnityEngine.UI;
public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 30f;
    public legsMove _legMove;
    public float torque;
    public Text score;
    private int count;
    
    private void Start()
    {
        count = 0;
        score.text = "score: " + count.ToString();
        Debug.Log(count.ToString());
    }
    void FixedUpdate ()
    {

        if (Input.GetKey("w"))
        {
            _legMove.legMove();
            transform.Translate(0,0,forward * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            _legMove.legMove();
            transform.Translate(0, 0, -forward * Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
            rb.AddTorque(0,- torque, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddTorque(0, torque,0);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            forward = 6;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            forward = 3 ;
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("quit");
            Application.Quit();
        }
    }
    
	void OnCollisionEnter(Collision other)
	{
        
		if (other.gameObject.name == "flower")

        {
            count=count + 1;
			other.gameObject.SetActive (false);
            score.text = "score: " + count.ToString();
            Debug.Log(count.ToString());
        }
        if(count>=10)
        {
            GameManager gm = gameObject.GetComponent<GameManager>();
            gm.setLevelCompleteActive();
        }
        if (other.collider.name == "Water")
        {
            Debug.Log("you Drowned!");
            GameManager gm = gameObject.GetComponent<GameManager>();
            gm.youDrowned();
        }
    }
    
}
