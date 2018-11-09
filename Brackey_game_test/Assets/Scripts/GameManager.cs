using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
		Debug.Log("Level Won!");
	}

	public void EndGame()
	{
		if (!gameHasEnded)
		{
			gameHasEnded = true;
			
			Debug.Log("Game over");
			Invoke("Restart", restartDelay);
		}
		
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}