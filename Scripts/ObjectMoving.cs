using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoving : MonoBehaviour
{

    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;

    private float StartTime;
    private float journey;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;

        journey = Vector2.Distance(startMarker.position, endMarker.position);

        target = GameObject.FindWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - StartTime) * speed;
        float fracJourney = distCovered / journey;

        transform.position = Vector2.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(fracJourney, 1));
        
    }
}