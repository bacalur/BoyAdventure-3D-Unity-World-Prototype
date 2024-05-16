using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int collectedCoins = 0;
    private int totalCoins = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // Destroy the coin
            Destroy(other.gameObject);

            // Increase the number of collected coins
            collectedCoins++;

            // Check if all coins are collected
            if (collectedCoins == totalCoins)
            {
                Debug.Log("All coins collected!");
                // Additional actions can be added here when all coins are collected
            }
        }
    }
}
