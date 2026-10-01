using Unity.VisualScripting;
using UnityEngine;




public class TorretMovement : MonoBehaviour
{

    [Header("TRANSFORMS FOR ROTATION")]
    [SerializeField] Transform _PivotCanon;
    [SerializeField] Transform _Body;

    public Vector3 MousePos;



    void Start()
    {
        if(_PivotCanon == null || _Body == null) Debug.LogError("Insert Pivot of Canon Transform and/or Body Transform");





    }

    private void FixedUpdate()
    {

        Debug.Log(MousePos.x);
        Debug.Log(MousePos.y);


    }


    void Update()
    {
        
    }



}
