using Signals;
using UnityEngine;
using UnityEngine.UI;
using Enums;

namespace Controllers
{
    public class TaxiMovementController : MonoBehaviour
    {
        public float speed = 5f; 
        private Rigidbody2D _rigidbody;
        private bool _fuelConsuption;
        private float _fuel = 100;
        [SerializeField] private Image fuelBar;

        [SerializeField]
        private int fuelLoss;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            
            FuelConsumption();
        }

        private void FixedUpdate()
        {
            Movement();
        }

        private void FuelConsumption()
        {
            if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)||
                Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow) )
            {
                _fuel -= fuelLoss*Time.deltaTime;
                fuelBar.fillAmount = _fuel/100;
                if (_fuel <= 0)
                {
                    CoreGameSignals.Instance.OnGameStates?.Invoke(GameStates.Dead);
                }
            }
        }

        public void FuelIncrease(int value)
        {
            _fuel += value;
            if (_fuel > 100)
            {
                _fuel = 100;
            }
        }

        private void Movement()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            _rigidbody.AddForce(transform.up * (verticalInput * speed));
            _rigidbody.AddForce(transform.right * (horizontalInput * speed));
        }
        
        
    }
}
