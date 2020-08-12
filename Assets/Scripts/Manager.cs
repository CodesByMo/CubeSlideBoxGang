using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
	bool gameEnded = false;
	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame()
	{

		if (gameEnded == false)
		{
			gameEnded = true;
			Debug.Log("GAME OVER");
			//restart game
			Invoke("Restart", restartDelay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
