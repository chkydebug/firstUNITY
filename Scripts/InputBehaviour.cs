
using UnityEngine;

public class InputBehaviour : MonoBehaviour {
public Rigidbody rb1;
public Rigidbody rb2;
	public Rigidbody rb;
	public GameManager m;
	void Start(){

	}

	// Update is called once per frame
	void Update () {
		rb1.AddForce(0,0,-5f);
        rb2.AddForce(0,0,-5f);
		rb.AddForce(0,0,5f);
		if(rb.position.y<0.90f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
