using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Ссылка на трансформ персонажа
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Расстояние и высота от персонажа

    void Update()
    {
        if (player != null)
        {
            // Устанавливаем позицию камеры на позицию персонажа с учетом смещения
            transform.position = player.position + offset;
        }
    }
}