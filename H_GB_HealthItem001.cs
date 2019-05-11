//https://hub.packtpub.com/simple-player-health/

using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour
{
    public int healAmount = 10;

    void OnTriggerEnter(Collider other)
    {
       Player player = other.GetComponent<Player>();

       if (player != null)
       {
           player.AlterHealth(healAmount);
           gameObject.SetActive(false);
       }
    }

}