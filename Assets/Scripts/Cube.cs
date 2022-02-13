using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveUP();
        }
        else if(Input.GetKey(KeyCode.DownArrow))
            MoveDown();
    }

    protected virtual void MoveUP()
    {
        gameObject.transform.position += new Vector3(0, 0, 0.3f);
    }

    protected virtual void MoveDown()
    {
        gameObject.transform.position += new Vector3(0, 0, -0.3f);
    }
}
