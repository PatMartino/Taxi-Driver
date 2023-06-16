using System;
using System.Threading.Tasks;
using Controllers;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameObjects
{
    public class Fuel : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Bum");
            other.gameObject.GetComponent<TaxiMovementController>().FuelIncrease(35);
            transform.position = new Vector3(12, 12, 0);
            SetTransform();
        }

        private async void SetTransform()
        {
            await Task.Delay(7000);
            var randomNumberx = Random.Range(-6, 6);
            var randomNumbery = Random.Range(-3, 3);
            transform.position = new Vector3(randomNumberx, randomNumbery, 0);
        }
    }
}
