using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class Health : MonoBehaviour, IHealth
    {
        [SerializeField]
        private int _startingHealth = 100;
        [SerializeField]
        private int _minimumHealth = 0;
        [SerializeField]
        private int _maximumHealth = 100;

        [SerializeField]
        private int _currentHealth;

        public int CurrentHealth
        {
            get
            {
                return _currentHealth;
            }
        }

        public void DecreaseHealth(int amount)
        {
           if(_currentHealth - amount < _minimumHealth)
            {
                _currentHealth = _minimumHealth;
            }
            else
            {
                _currentHealth -= amount;
            }
        }

        public void IncreaseHealth(int amount)
        {
            if(amount + _currentHealth > _maximumHealth)
            {
                _currentHealth = _maximumHealth;
            }
            else
            {
                _currentHealth += amount;
            }
        }
    }
}
