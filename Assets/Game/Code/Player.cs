using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Creatures.Player
{
    public int MaxHP = 100;


    public PointBar HealthBar;

    private int _currentHP;
    public int CurrentHP
    {
        get => _currentHP;
        private set
        {
            if (_currentHP != value)
            {
                _currentHP = value;
                HealthBar.SetValue(_currentHP);
            }
        }
    }

    void Start()
    {
        CurrentHP = MaxHP;
        //HealthBar = new PointBar();
        HealthBar.InitBar(MaxHP);
        IsDead = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }

    }
    void TakeDamage(int damage)
    {
        CurrentHP -= damage;
    }
}
