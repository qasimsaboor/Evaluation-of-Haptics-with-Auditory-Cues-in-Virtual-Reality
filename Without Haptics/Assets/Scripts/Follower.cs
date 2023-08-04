using UnityEngine;

public class Follower : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints for the cat to follow
    public float moveSpeed = 3f; // Speed at which the cat moves

    private int currentWaypointIndex = 0; // Index of the current waypoint

    private void Start()
    {
        // Initialize the cat's position to the first waypoint
        transform.position = waypoints[currentWaypointIndex].position;
        FaceWaypoint();
    }

    private void Update()
    {
        // Check if the cat has reached the current waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            // Generate a random index for the next waypoint
            int nextWaypointIndex = Random.Range(0, waypoints.Length);

            // Make sure the next waypoint is different from the current one
            while (nextWaypointIndex == currentWaypointIndex)
            {
                nextWaypointIndex = Random.Range(0, waypoints.Length);
            }

            // Set the new waypoint index
            currentWaypointIndex = nextWaypointIndex;

            // Update the cat's rotation to face the new waypoint
            FaceWaypoint();
        }

        // Move the cat towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
    }

    private void FaceWaypoint()
    {
        Vector3 direction = waypoints[currentWaypointIndex].position - transform.position;
        direction.y = 0f; // Optional, to keep the cat aligned with the ground
        if (direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 360f);
        }
    }
}