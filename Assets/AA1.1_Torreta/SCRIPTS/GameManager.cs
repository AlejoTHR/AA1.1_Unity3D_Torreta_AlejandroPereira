using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public TextMeshProUGUI Score;

    public int POINTS;


    private void Update()
    {
        Score.text = POINTS.ToString();

    }


}
