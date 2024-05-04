using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip footstepSound; // Звуковой файл для шагов
    public AudioClip jumpSound; // Звуковой файл для прыжка
    public float stepInterval = 0.5f; // Интервал между шагами
    private float nextStepTime = 0f;

    private AudioSource audioSource; // Ссылка на компонент AudioSource

    void Start()
    {
        // Получаем компонент AudioSource
        audioSource = GetComponent<AudioSource>();

        // Проверяем, есть ли компонент AudioSource. Если нет, добавляем его.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Проверяем, нажата ли клавиша движения и прошло ли достаточно времени для следующего шага
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Time.time > nextStepTime)
        {
            // Проигрываем звук шага
            audioSource.PlayOneShot(footstepSound);

            // Обновляем время следующего шага
            nextStepTime = Time.time + stepInterval;
        }

        // Проверяем, была ли нажата клавиша пробела для прыжка
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Проигрываем звук прыжка
            audioSource.PlayOneShot(jumpSound);
        }
    }
}