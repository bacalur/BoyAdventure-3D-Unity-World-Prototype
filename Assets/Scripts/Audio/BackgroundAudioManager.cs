using UnityEngine;

public class BackgroundAudioManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Check if the AudioSource component exists. If not, add it.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Start playing the background sound in a loop
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.Play();
    }
}
