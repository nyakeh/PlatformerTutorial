using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int coinsCount = 0;
    [SerializeField] TMPro.TextMeshProUGUI coinsText;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coinsCount++;
            Destroy(other.gameObject);
            coinsText.text = "Coins: " + coinsCount;
        }
    }
}
