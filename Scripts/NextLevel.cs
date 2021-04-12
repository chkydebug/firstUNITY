using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour {

	public void nextlvl()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

}
