
using UnityEngine;
using UnityEngine.InputSystem;





public class TorretMovement : MonoBehaviour
{
    public InputSystem_Actions _input;


    [Header("TRANSFORMS FOR ROTATION")]
    public Transform _PivotCanon;

    public Vector3 MousePos;

    [Header("AMMO n SHOOT")]

    public Transform _ShootExit;

    public GameObject _Ammo;

    public float ammoSpeed;



    void Start()
    {
        if(_PivotCanon == null) Debug.LogError("Insert Pivot of Canon Transform ");

        _input = new InputSystem_Actions();
        _input.Enable();
    }


    void Update()
    {
        MousePos = Mouse.current.delta.ReadValue();
        
        // DIRECCIÓN DEL CAÑÖN
        _PivotCanon.localEulerAngles -= new Vector3(MousePos.y,0,0);

        // DIRECCIÓN DEL CUERPO
        transform.localEulerAngles += new Vector3(0, MousePos.x, 0);


        // DIRECCIÓN DEL CAÑÓN        +      // DIRECCIÓN DEL CUERPO
        Quaternion BulletRotation = Quaternion.Euler(-_PivotCanon.localEulerAngles.x + 90, transform.localEulerAngles.y, 0);


        if (_input.Player.Shoot.WasPressedThisFrame())
        {
            GameObject AMMO = Instantiate(_Ammo, _ShootExit.position, BulletRotation);
            AMMO.GetComponent<Rigidbody>().linearVelocity = _ShootExit.forward * ammoSpeed;
        }

    }


}
