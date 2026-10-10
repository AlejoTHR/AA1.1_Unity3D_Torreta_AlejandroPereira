using UnityEngine;

public class Bulleye : MonoBehaviour
{

    public GameObject _BrokenBulleye;

    private MeshRenderer _render;
    private Collider _clldr;

    public bool IsActive = true;
    public float SpawnTimer = 3;
    public float TimerMax = 3;


    private void Start()
    {
        _render = GetComponent<MeshRenderer>();
        _clldr = GetComponent<Collider>();
    }

    private void Update()
    {
        if (!IsActive) {
            SpawnTimer -= Time.deltaTime;
            if (SpawnTimer <= 0)
            {
                IsActive = true;
                _render.enabled = IsActive;
                _clldr.enabled = IsActive;
                SpawnTimer = TimerMax;

            }
        }

    }

    private void OnTriggerEnter(Collider collided)
    {
        if (collided.CompareTag("Bullet"))
        {
            IsActive = false;
            
            _render.enabled = IsActive;
            _clldr.enabled = IsActive;

            Instantiate(_BrokenBulleye, gameObject.transform.position, Quaternion.identity);
        }


    }

}
