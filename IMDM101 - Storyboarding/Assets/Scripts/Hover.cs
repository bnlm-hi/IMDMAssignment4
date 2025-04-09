using UnityEngine;

public class Hover : MonoBehaviour
{
    //adjust this to change speed
    [SerializeField]
    float speed = 4f;
    //adjust this to change how high it goes
    [SerializeField]
    float width = 1.5f;

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    void Update()
    {

        //calculate what the new Y position will be
        float newX = Mathf.Sin(Time.time * speed) * width + pos.x;
        //set the object’s Y to the new calculated Y
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
