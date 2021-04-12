using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public void start()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
}
}
