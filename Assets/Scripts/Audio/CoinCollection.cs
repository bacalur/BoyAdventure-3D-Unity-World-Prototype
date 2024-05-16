using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int collectedCoins = 0;
    private int totalCoins = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);

            collectedCoins++;

            if (collectedCoins == totalCoins)
            {
                Debug.Log("All coins collected!");
            }
        }
    }
}
