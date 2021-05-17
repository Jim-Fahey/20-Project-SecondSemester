using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Shoot : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    private Vector2 m_Direction;

    void Start()
    {
        // save direction by offsetting the target position and the initial object's position.
        m_Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shooting();
        }
        m_Direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position;
        float x;
        float y;
        bool doubleNeg = false;
        bool xNeg = false;
        bool yNeg = false;
        if(m_Direction.x < 0 && m_Direction.y < 0)
        {
            doubleNeg = true;
        }
        if(m_Direction.x < 0 && doubleNeg == false)
        {
            xNeg = true;
        }
        if(m_Direction.y < 0 && doubleNeg == false)
        {
            yNeg = true;
        }
        if(Math.Abs(m_Direction.x) > Math.Abs(m_Direction.y)) {
            if (xNeg)
            {
                x = -1;
            }
            else
            {
                x = 1;
            }
            y = (1 / m_Direction.x) * m_Direction.y;
            if(doubleNeg)
            {
                x = x * -1;
                y = y * -1;
            }
            m_Direction.x = x;
            m_Direction.y = y;
        }
        else {
            if (yNeg)
            {
                y = -1;
            }
            else
            {
                y = 1;
            }
            x = (1 / m_Direction.y) * m_Direction.x;
            if(doubleNeg)
            {
                y = y * -1;
                x = x * -1;
            }
            m_Direction.x = x;
            m_Direction.y = y;
        }
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(m_Direction * bulletForce, ForceMode2D.Impulse);
    }

}