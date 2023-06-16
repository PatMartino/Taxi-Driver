using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        public int randomNumber;
        public GameObject[] stations;
        public GameObject[] arrows;
        public bool passenger = true;
        public LevelManager Instance;
        public int score = 0;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void OnEnable()
        {
            NewPassenger();
        }

        public void NewPassenger()
        {
            arrows[randomNumber].SetActive(false);
            passenger = true;
            var num = Random.Range(0, 7);
            if (num == randomNumber)
            {
                while (num == randomNumber)
                {
                    num = Random.Range(0, 7);
                }
                randomNumber = num;
            }
            else
            {
                randomNumber = num;
            }
            stations[randomNumber].SetActive(true);
        }

        public void Target()
        {
            stations[randomNumber].SetActive(false);
            passenger = false;
            var num = Random.Range(0, 7);
            if (num == randomNumber)
            {
                while (num == randomNumber)
                {
                    num = Random.Range(0, 7);
                }
                randomNumber = num;
            }
            else
            {
                randomNumber = num;
            }

            arrows[randomNumber].SetActive(true);
        }

    }
}
