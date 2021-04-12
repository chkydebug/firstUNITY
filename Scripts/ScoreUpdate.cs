
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour {
    public Transform p;
	public InputBehaviour mov;
	public Text sc;
	void Update () {
		
		sc.text = p.position.z.ToString("0");
		if (mov.enabled == false||FindObjectOfType<InputBehaviour>().rb.position.y<0.98f) {
			sc.text = "OOPS\n "+sc.text;
		}
	}
}
