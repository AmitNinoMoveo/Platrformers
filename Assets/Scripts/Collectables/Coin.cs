using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Entity
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if (player == null) Debug.Break();
            player.ChangeCoinsByAmount();
            DestroyCoin();
        }
    }
    void DestroyCoin()
    {
        Destroy(gameObject);
    }
}
