using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, с чем столкнулся персонаж
        if (other.CompareTag("Skull"))
        {
            // Переходим в сцену "project_01"
            SceneManager.LoadScene("project_01");
        }
    }
}