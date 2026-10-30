using JetBrains.Annotations;
using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class balle : MonoBehaviour
{
    [SerializeField] private UnityEvent unityEvent;

    [SerializeField] int Hp = 100;

    [SerializeField] private Slider slider;

    [SerializeField] private MeshRenderer mesh;

    [SerializeField] private SphereCollider sphereCollider;

    

    private void OnCollisionEnter(Collision collision)
    {
        
            Hp -= 10;
            slider.value = Hp;
            if (Hp <= 0)
            {
                unityEvent?.Invoke();
                mesh.enabled = false;
                sphereCollider.material.bounciness = 0;
            
            }
        
    }

    
}
