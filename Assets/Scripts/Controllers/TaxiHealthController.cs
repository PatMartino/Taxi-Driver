using UnityEngine;
using Enums;
using Signals;

namespace Controllers
{
    public class TaxiHealthController : MonoBehaviour
    {
        [SerializeField] private short health = 100;
        private const byte MaxHealth = 100;

        public void ChangeHealth(HealthStates states, short value)
        {
            switch (states)
            {
                case HealthStates.Lose:
                    health -= value;
                    IsDead();
                    break;
                case HealthStates.Earn:
                    health += value;
                    IsReachedMaxHealth();
                    break;
            }
            CoreGameSignals.Instance.OnUpdatingHealthBar?.Invoke(MaxHealth,health);
        }

        private void IsReachedMaxHealth()
        {
            if ((byte)health > MaxHealth)
            {
                health = MaxHealth;
            }
        }

        private void IsDead()
        {
            if (health <= 0)
            {
                Debug.Log("Dead");
                CoreGameSignals.Instance.OnGameStates.Invoke(GameStates.Dead);
            }
        }
    }
}
