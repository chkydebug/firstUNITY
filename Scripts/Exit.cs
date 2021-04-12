
using UnityEngine;

public class Exit : MonoBehaviour {

	 public void quit()
	{
		Debug.Log ("exited");
		Application.Quit ();
	}
}
