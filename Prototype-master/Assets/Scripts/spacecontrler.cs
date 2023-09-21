using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Transform blackHole; // Assign the black hole transform here
    public Transform[] waypoints; // Assign the waypoint transforms here in sequence
    public float attractionSpeed = 2.0f; // You can adjust the speed of attraction

    private int currentWaypointIndex = 0;

    void Update()
    {
        if (currentWaypointIndex < waypoints.Length)
        {
            Transform targetWaypoint = waypoints[currentWaypointIndex];
            Vector3 direction = targetWaypoint.position - transform.position;
            transform.position += direction.normalized * attractionSpeed * Time.deltaTime;

            // Check if we reached the waypoint
            if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
            {
                currentWaypointIndex++;
            }
        }
    }
}
