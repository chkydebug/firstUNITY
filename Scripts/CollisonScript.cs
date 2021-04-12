
using UnityEngine;
using UnityEngine.UI;
public class CollisonScript : MonoBehaviour {
	public InputBehaviour mov;
	public GameManager man;
	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle" ) {
			mov.enabled = false;
			FindObjectOfType<GameManager> ().EndGame ();
	
		}

	}

}
