using System;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    int coinsCount = 0;
    [SerializeField] TMPro.TextMeshProUGUI coinsText;
    [SerializeField] AudioSource collectionSound;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coinsCount++;
            Destroy(other.gameObject);
            coinsText.text = "Coins: " + coinsCount;
            collectionSound.Play();
        }
    }
}
