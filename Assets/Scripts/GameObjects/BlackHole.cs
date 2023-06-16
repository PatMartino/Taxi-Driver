using UnityEngine;
using Controllers;
using Signals;
using Enums;
namespace GameObjects
{
    public class BlackHole : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Bum");
                other.gameObject.GetComponent<TaxiHealthController>().ChangeHealth(HealthStates.Lose,100);
            }
        }

    }
}
