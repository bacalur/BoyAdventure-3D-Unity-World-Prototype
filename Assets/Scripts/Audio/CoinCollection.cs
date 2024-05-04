using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int collectedCoins = 0;
    private int totalCoins = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // ”ничтожаем монету
            Destroy(other.gameObject);

            // ”величиваем количество собранных монет
            collectedCoins++;

            // ѕровер€ем, собраны ли все монеты
            if (collectedCoins == totalCoins)
            {
                Debug.Log("All coins collected!");
                // «десь можно добавить дополнительные действи€, когда все монеты собраны
            }
        }
    }
}
