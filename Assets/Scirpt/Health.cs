using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{


    [MinValue(0)] [SerializeField] private int _maxHealth;
    [MinValue(0)][SerializeField] private int _currentHp;

    [SerializeField] UnityEvent _onDamage;

    



    private void Reset()
    {
        _currentHp = 0;
        _maxHealth = 100;
    }

    private void OnValidate()
    {
        if(_currentHp > _maxHealth)
        {
            Debug.LogWarning("<color=red> Current Hp can't be higher than the max hp you stupid</color> <color=purple> motherfucker");
            _currentHp = _maxHealth;
        }
    }


    public void Damage(int degat)
    {
        _currentHp -= degat;

        _onDamage?.Invoke();

        if(_currentHp <= 0)
        {
            Die();
        }
        return;
    }

    private void Die()
    {
        return;
    }


    [Button] void test()
    {
        Damage(10);
    }
}
