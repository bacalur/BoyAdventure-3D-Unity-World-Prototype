using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Distance and height from the player

    void Update()
    {
        if (player != null)
        {
            // Set the camera's position to the player's position with the offset
            transform.position = player.position + offset;
        }
    }
}
