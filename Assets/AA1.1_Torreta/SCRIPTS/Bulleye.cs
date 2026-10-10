using UnityEngine;

public class Bulleye : MonoBehaviour
{

    public GameObject _BrokenBulleye;

    public bool IsActive = true;
    public float Timer = 3;

    private void Update()
    {
        if (!IsActive) {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                IsActive = true;
                gameObject.SetActive(false);

            }
        }

    }

    private void OnTriggerEnter(Collider collided)
    {
        if (collided.CompareTag("Bullet"))
        {
            IsActive = false;
            gameObject.SetActive(false);
            Instantiate(_BrokenBulleye, gameObject.transform.position, Quaternion.identity);
        }


    }

}
