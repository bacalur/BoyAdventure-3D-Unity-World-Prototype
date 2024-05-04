using UnityEngine;

public class BackgroundAudioManager : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Получаем компонент AudioSource
        audioSource = GetComponent<AudioSource>();

        // Проверяем, есть ли компонент AudioSource. Если нет, добавляем его.
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Запускаем проигрывание фонового звука в цикле
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.Play();
    }
}