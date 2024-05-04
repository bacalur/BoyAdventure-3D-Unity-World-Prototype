using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ���������, � ��� ���������� ��������
        if (other.CompareTag("Skull"))
        {
            // ��������� � ����� "project_01"
            SceneManager.LoadScene("project_01");
        }
    }
}