using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 5, 0);
        }        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 5);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(5, 0, 0);
        }
    }
}
