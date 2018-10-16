﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPortal : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag("Player"))
		{
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	}
}
