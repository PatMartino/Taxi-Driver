using System.Threading.Tasks;
using Controllers;
using UnityEngine;
using Signals;
using Enums;

namespace GameObjects
{
    public class Mechanic : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Bum");
            other.gameObject.GetComponent<TaxiHealthController>().ChangeHealth(HealthStates.Earn,20);
            transform.position = new Vector3(12, 12, 0);
            SetTransform();
        }
        private async void SetTransform()
        {
            await Task.Delay(10000);
            var randomNumberx = Random.Range(-6, 6);
            var randomNumbery = Random.Range(-3, 3);
            transform.position = new Vector3(randomNumberx, randomNumbery, 0);

        }
    }
}
