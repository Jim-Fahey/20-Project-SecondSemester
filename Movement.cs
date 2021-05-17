using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;
    Vector3 characterScale;
    float characterScaleX;

    void Start()
    {
        characterScale = transform.localScale;
        characterScaleX = characterScale.x;
    }

    public void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);

        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = characterScaleX;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = -characterScaleX;
        }
        transform.localScale = characterScale;

    }

}
