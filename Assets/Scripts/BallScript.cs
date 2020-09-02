using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class BallScript : MonoBehaviour
{
    public float speed = 10f;
    Vector3 initialPosition;
    
    float halfwight;
    float halfHeght;
    float diametrBall;
    Rigidbody2D ballRigidbody;
    Vector2 velocity;
    void Start()
    {
        initialPosition = transform.position;
        halfHeght = Camera.main.orthographicSize;
        halfwight = Camera.main.aspect * Camera.main.orthographicSize;
        diametrBall = transform.localScale.x;
        ballRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         
              velocity = Vector2.up * speed;
        
      
    }
      void FixedUpdate()
    {
        ballRigidbody.position += velocity * Time.deltaTime;
    }
}
