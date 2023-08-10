using UnityEngine;

public class BasketController : MonoBehaviour
{
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)&& obj.transform.position.x < 2.2)
        {
            obj.transform.position=new Vector3(obj.transform.position.x+Time.deltaTime*5,obj.transform.position.y,0) ;
        }
        if (Input.GetKey(KeyCode.LeftArrow)&& obj.transform.position.x > -2.2)
        {
            obj.transform.position = new Vector3(obj.transform.position.x - Time.deltaTime*5, obj.transform.position.y, 0);
        }
    }
}
