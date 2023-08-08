using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    GameObject obj;
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        RefreshEgg();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag.Equals("break_line")) {
            RefreshEgg();
            gameController.GetComponent<GameController>().BrokeEgg();
        }
    }
    private void RefreshEgg()
    {
        obj.transform.position = new Vector3(Random.Range(-2, 2), (float)5.5, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameController.GetComponent<GameController>().AddScore();
        RefreshEgg();
    }
}
