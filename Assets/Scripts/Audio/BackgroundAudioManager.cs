using UnityEngine;

public class BackgroundAudioManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // �������� ��������� AudioSource
        audioSource = GetComponent<AudioSource>();

        // ���������, ���� �� ��������� AudioSource. ���� ���, ��������� ���.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // ��������� ������������ �������� ����� � �����
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.Play();
    }
}