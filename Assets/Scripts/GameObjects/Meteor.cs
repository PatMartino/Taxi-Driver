using System;
using Controllers;
using UnityEngine;
using Enums;
using Random = UnityEngine.Random;

namespace GameObjects
{
    public class Meteor : MonoBehaviour
    {
        private void OnEnable()
        {
            SetTransform();
        }

        void Update()
        {
            transform.Translate(0,-2f*Time.deltaTime,0);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.GetComponent<TaxiHealthController>().ChangeHealth(HealthStates.Lose,50);
                SetTransform();
            }

            if (other.gameObject.CompareTag("Reset"))
            {
                SetTransform();
            }
        }

        private void SetTransform()
        {
            int randomX = Random.Range(-7, 7);
            int randomY = Random.Range(11, 17);
            transform.position = new Vector3(randomX, randomY, 0);
        }
    }
}
