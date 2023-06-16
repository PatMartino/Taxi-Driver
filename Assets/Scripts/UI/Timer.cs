using Signals;
using TMPro;
using UnityEngine;
using Enums;

namespace UI
{
    public class Timer : MonoBehaviour
    {
        
        [SerializeField]
        private TMP_Text textCooldown;

        private bool _isCooldown = true;
        private readonly float _cooldownTime = 100.0f;
        private float _cooldownTimer = 0.0f;
    
        void Start()
        {
            _cooldownTimer = _cooldownTime;
        }
        void Update()
        {
            SpecialAbilityCooldown();
        }
        void SpecialAbilityCooldown()
        {
            _cooldownTimer -= Time.deltaTime;
        
            if (_cooldownTimer < 0.0f)
            {
                if (_isCooldown)
                {
                    _isCooldown = false;
                    CoreGameSignals.Instance.OnGameStates.Invoke(GameStates.Dead);
                }
            }
            else
            {
                textCooldown.text = Mathf.RoundToInt(_cooldownTimer).ToString();
            }
        }

    }
}
