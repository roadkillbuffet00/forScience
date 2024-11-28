using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    public int coins = 0;

    [SerializeField] TMP_Text coinsText;

    [SerializeField] AudioSource collectionSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
            
            coins++;
            coinsText.text = "coins: " + coins;
            collectionSound.Play();
        }
    }
}
