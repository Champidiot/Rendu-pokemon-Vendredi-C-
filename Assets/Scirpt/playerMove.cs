using Unity.VisualScripting;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    [SerializeField] private Rigidbody rigi;

    [SerializeField] private float _speed;

    private Vector3 direction;

    private void Reset()
    {
        rigi = GetComponent<Rigidbody>();
        _speed = 5f;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rigi.linearVelocity = new Vector3(
            direction.x * _speed * Time.fixedDeltaTime, 
            rigi.linearVelocity.y, 
            direction.z * _speed * Time.fixedDeltaTime);

        


    }

    public void UpdateDirection(Vector3 newDir)
    {
        direction = newDir;
    }
}
