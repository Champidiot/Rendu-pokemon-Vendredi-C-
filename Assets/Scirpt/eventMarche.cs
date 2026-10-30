using UnityEngine;
using UnityEngine.Events;

public class eventMarche : MonoBehaviour
{

    [SerializeField] private UnityEvent myEvent;



    public void TriggerMyEvent()
    {
        myEvent.Invoke();
        return;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
