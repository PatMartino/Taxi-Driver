using Controllers;
using UnityEngine;
using Enums;

namespace GameObjects
{
    public class TaxiStations : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                float carpismaHizi = collision.relativeVelocity.magnitude;
                float carpismaHiziSiniri = 1.5f; 
                Debug.Log(collision.relativeVelocity.magnitude);
    
                if (carpismaHizi > carpismaHiziSiniri)
                {
                    int azalacakCan = Mathf.RoundToInt(carpismaHizi);
                    azalacakCan *= 5;
                    collision.gameObject.GetComponent<TaxiHealthController>().ChangeHealth(HealthStates.Lose,(short)azalacakCan);
                }
                }
            }
        }
    }

