using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public float delay;
	bool EndFlag =false;
	public GameObject obj;
	public void WinGame()
	{
		Debug.Log ("Game Won");

		obj.SetActive (true);

	
	}
	public void EndGame ()
	{
		if (EndFlag == false)
		{
			EndFlag = true;
			Debug.Log ("Game Lost");
			Invoke("reset", delay);
			
			}
	}
	void reset()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
