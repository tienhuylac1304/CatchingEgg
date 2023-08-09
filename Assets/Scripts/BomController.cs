using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BomController : MonoBehaviour
{
    GameObject obj;
    public GameObject basket;
    public GameObject gameController;
    public Sprite imgBoom;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        obj.GetComponent<Rigidbody2D>().isKinematic = true;
        RefresBom();
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag.Equals("break_line")) {
            RefresBom();
        }
    }
    private void RefresBom()
    {
        obj.transform.position = new Vector3(Random.Range(-2, 2), (float)5.5, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        basket.GetComponent<SpriteRenderer>().sprite = imgBoom;
        //Audio here
        gameController.GetComponent<GameController>().EndGame();
    }
}
