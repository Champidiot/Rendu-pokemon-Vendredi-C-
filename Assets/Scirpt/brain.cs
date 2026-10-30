using UnityEngine;
using UnityEngine.InputSystem;

public class brain : MonoBehaviour
{
    [SerializeField] private InputActionReference moveInp;

    [SerializeField] playerMove _movement;

    private Vector2 moveDire;

    [SerializeField] private eventMarche walkingEvent;

    float timer = 0f;



    void Start()
    {
        moveInp.action.started += OnMoveUpdate;
        moveInp.action.performed += OnMoveUpdate;
        moveInp.action.canceled += OnMoveStop;

        walkingEvent.enabled = true;
    }

    private void OnDestroy()
    {
        moveInp.action.started -= OnMoveUpdate;
        moveInp.action.performed -= OnMoveUpdate;
        moveInp.action.canceled -= OnMoveStop;

        walkingEvent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveDire = moveInp.action.ReadValue<Vector2>();

        timer += Time.deltaTime;
        if (timer > 0.5f && moveInp.action.ReadValue<Vector2>()!= Vector2.zero)
        {
            walkingEvent.TriggerMyEvent();
            timer = 0f;
        }

    }

    public Vector2 GetDirection()
    {
        return moveDire;
    }

    void OnMoveUpdate(InputAction.CallbackContext obj)
    {
        var dir = obj.ReadValue<Vector2>();
        Vector3 pos = new Vector3(dir.x, 0, dir.x);

        _movement.UpdateDirection(pos);
    }
    void OnMoveStop(InputAction.CallbackContext obj)
    {
        _movement.UpdateDirection(Vector3.zero);
    }



}
