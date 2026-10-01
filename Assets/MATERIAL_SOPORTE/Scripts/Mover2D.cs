using UnityEngine;

public class Mover2D : MonoBehaviour
{

    public Rigidbody2D _rb;

    public float Speed = 1;


    InputSystem_Actions _input;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
        _input = new InputSystem_Actions();
        _input.Enable();
        
    }


    private void FixedUpdate()
    {
        Vector3 dir = _input.Player.Move.ReadValue<Vector2>();

        transform.position += dir * Speed * Time.fixedDeltaTime;
    }


    // Update is called once per frame
    void Update()
    {


        
    }




}
