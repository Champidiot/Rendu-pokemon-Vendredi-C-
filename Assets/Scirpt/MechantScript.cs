using UnityEngine;

public class MechantScript : MonoBehaviour
{

    [SerializeField] playerMove movement;
    [SerializeField] GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 maPos = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        movement.UpdateDirection(player.transform.position - transform.position);
    }
}
