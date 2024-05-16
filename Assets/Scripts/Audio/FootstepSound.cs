using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip footstepSound; // Audio file for footsteps
    public AudioClip jumpSound; // Audio file for jumping
    public float stepInterval = 0.5f; // Interval between steps
    private float nextStepTime = 0f;

    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Check if the AudioSource component exists. If not, add it.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Check if a movement key is pressed and enough time has passed for the next step
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Time.time > nextStepTime)
        {
            // Play the footstep sound
            audioSource.PlayOneShot(footstepSound);

            // Update the time for the next step
            nextStepTime = Time.time + stepInterval;
        }

        // Check if the space key was pressed for jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the jump sound
            audioSource.PlayOneShot(jumpSound);
        }
    }
}
