using UnityEngine;

public class CameraRotator : MonoBehaviour
{

    public InputSystem_Actions _input;

    public Camera _camera;

    [Header("MOVEMENT")]
    public Transform XRotator;
    [SerializeField] Vector3 InputDirection;

    [Header("Confort")]
    [Range(0.1f, 3f)] public float SensitivityX = 1f;
    [Range(0.1f, 3f)] public float SensitivityY = 1f;
    

    void Start()
    {
        _input = new InputSystem_Actions();
        _input.Enable();

    }

    void Update()
    {
        InputDirection = _input.Player.Move.ReadValue<Vector2>().normalized;

        // ROTATION

        transform.Rotate(new Vector3(InputDirection.y * SensitivityY , 0, 0));
        
        transform.Rotate(new Vector3(0,-InputDirection.x * SensitivityX, 0));

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);

    
    }




}
