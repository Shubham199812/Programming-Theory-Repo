using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingCube : Cube
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
        else if (Input.GetKey(KeyCode.DownArrow))
            MoveDown();

        colorChange();
    }

    private void colorChange()
    {
        GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    protected override void MoveUP()
    {
        gameObject.transform.position += new Vector3(0.3f, 0, 0);
    }

    protected override void MoveDown()
    {
        gameObject.transform.position += new Vector3(-0.3f, 0, 0);
    }
}
