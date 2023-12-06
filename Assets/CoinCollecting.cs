using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//oriana's code for coin collecting

public class CoinCollecting : MonoBehaviour
{
    public CoinManager cm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] private AudioSource collectionSoundEffect;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            collectionSoundEffect.Play();
            Destroy(other.gameObject);
            cm.coinCount++;
        }
    }
}
