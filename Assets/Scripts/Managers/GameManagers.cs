using UnityEngine;
using Signals;
using Enums;

namespace Managers
{
    public class GameManagers : MonoBehaviour
    {
        [SerializeField] private GameObject endPanel;
        public AudioSource Akasya;
        public AudioSource TaxiDriver;
        private void OnEnable()
        {
            SubscribeEvents();
            Time.timeScale = 1;
        }

        private void SubscribeEvents()
        {
            CoreGameSignals.Instance.OnGameStates += OnGameStates;
        }

        private void OnGameStates(GameStates states)
        {
            switch (states)
            {
                case GameStates.Dead:
                    
                    Debug.Log("Stop");
                    Akasya.enabled = false;
                    endPanel.SetActive(true);
                    TaxiDriver.ignoreListenerPause=true;
                    //TaxiDriver.enabled = true;
                    TaxiDriver.Play();
                   Time.timeScale = 0;
                    

                    break;
            }
        }
    }
}
