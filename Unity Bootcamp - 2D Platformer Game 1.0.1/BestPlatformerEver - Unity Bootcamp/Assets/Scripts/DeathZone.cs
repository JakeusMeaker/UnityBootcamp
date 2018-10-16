using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour 
{
    bool dead = false;

	void OnTriggerEnter2D(Collider2D col)
	{
        if (dead)
        { 
            return;
        }

        dead = true;

        if (col.gameObject.CompareTag("Player"))
        {
	        Debug.Log("Player hit the death zone!");
            GameManager.Instance.Death();
		}
	}
}
