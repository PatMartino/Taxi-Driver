using Signals;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class TaxiHealthBar : MonoBehaviour
    {
        [SerializeField] private Image playerHealthBar;
        private float _target=1;
        private void OnEnable()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            CoreGameSignals.Instance.OnUpdatingHealthBar += OnUpdatingHealthBar;
        }

        private void OnUpdatingHealthBar(float maxHealth, float currentHealth)
        {
            _target = currentHealth / maxHealth;
            playerHealthBar.fillAmount = _target;
        }
    
    }
}
