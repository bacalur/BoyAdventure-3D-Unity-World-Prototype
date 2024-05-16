using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0f, 2f, -5f);

    void Update()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
