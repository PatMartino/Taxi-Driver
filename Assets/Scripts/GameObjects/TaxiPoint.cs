using Managers;
using TMPro;
using UnityEngine;

namespace GameObjects
{
    public class TaxiPoint : MonoBehaviour
    {
        [SerializeField]
        private int num;

        private int score = 0;

        [SerializeField] private TextMeshProUGUI scoreText;

        public GameObject levelManager; 

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                if (levelManager.GetComponent<LevelManager>().randomNumber == num)
                {
                    if (levelManager.GetComponent<LevelManager>().passenger)
                    {
                        levelManager.GetComponent<LevelManager>().Target();
                    }
                    else
                    {
                        levelManager.GetComponent<LevelManager>().NewPassenger();
                        levelManager.GetComponent<LevelManager>().score += 100;
                        scoreText.text = "Score: " + levelManager.GetComponent<LevelManager>().score.ToString();
                        //other.GetComponent<TaxiMovementController>().FuelIncrease(10);
                    }
                }
            }
            
        }
    }
}
