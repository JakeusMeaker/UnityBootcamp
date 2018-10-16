using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
			Debug.Log("Player hit the death zone!");
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
