
using UnityEngine;
using UnityEngine.UI;
public class Right: MonoBehaviour {
	public Rigidbody rb;
	// Use this for initialization
	public void move() 
	{
		rb.AddForce (100f, 0, 0);
	}

	// Update is called once per frame
}
