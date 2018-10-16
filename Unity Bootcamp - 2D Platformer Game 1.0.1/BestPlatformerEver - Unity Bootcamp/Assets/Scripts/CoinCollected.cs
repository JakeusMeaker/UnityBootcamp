using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollected : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.name == "Player")
        {
            GameManager.Instance.coinsCollected += 1;

        Destroy(this.gameObject);
        }
    }



}
