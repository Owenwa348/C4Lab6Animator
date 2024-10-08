using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    GameController gameController; // อ้างอิงถึง GameController
    // Start is called before the first frame update
    void Start()
    {
        if (gameController == null)
        {
            gameController = GameObject.Find("GameController").GetComponent<GameController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the player get the item
        if (gameController.getItem)
        {
            Debug.Log("Get Item");
            StartCoroutine(WaitforTaking(4.7f));
            Destroy(this.gameObject);
            gameController.getItem = false;
        }
    }//end Update

    IEnumerator WaitforTaking(float time)
    {
        yield return new WaitForSeconds(time);
    }
}