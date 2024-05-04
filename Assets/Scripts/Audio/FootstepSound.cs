using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip footstepSound; // �������� ���� ��� �����
    public AudioClip jumpSound; // �������� ���� ��� ������
    public float stepInterval = 0.5f; // �������� ����� ������
    private float nextStepTime = 0f;

    private AudioSource audioSource; // ������ �� ��������� AudioSource

    void Start()
    {
        // �������� ��������� AudioSource
        audioSource = GetComponent<AudioSource>();

        // ���������, ���� �� ��������� AudioSource. ���� ���, ��������� ���.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // ���������, ������ �� ������� �������� � ������ �� ���������� ������� ��� ���������� ����
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Time.time > nextStepTime)
        {
            // ����������� ���� ����
            audioSource.PlayOneShot(footstepSound);

            // ��������� ����� ���������� ����
            nextStepTime = Time.time + stepInterval;
        }

        // ���������, ���� �� ������ ������� ������� ��� ������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ����������� ���� ������
            audioSource.PlayOneShot(jumpSound);
        }
    }
}