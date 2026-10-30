using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Events;

namespace TU_Challenge.Heritage
{
    public abstract class Animal
    {
        public string Name;

        public int Pattes;

        public event Action OnDie;

        public bool IsAlive = true;

        public int feedTime = 0;




        public Animal(string name)
        {
            this.Name = name;
        }

        public void Die()
        {
            IsAlive = false;
            OnDie?.Invoke();
        }

        public abstract String Crier();

    }
}
