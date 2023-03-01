using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(this.transform.parent.gameObject);
            UnityEngine.Debug.Log("Item collected!");

            gameManager.Items += 1;
            gameManager.PrintLootReport();
        }
    }
}