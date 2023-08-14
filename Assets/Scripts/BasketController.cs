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
        if (Input.GetMouseButton(0)/*&& obj.transform.position.x < 2.2&& obj.transform.position.x>-2.2*/)
        {
            Vector3 mousePos = (Input.mousePosition);
            Vector2 targetPos = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x, Camera.main.ScreenToWorldPoint(mousePos).y);

            targetPos.x = Mathf.Clamp(targetPos.x,(float) -1.8,(float) 1.8);
            transform.position = targetPos;

        }
    }
}
