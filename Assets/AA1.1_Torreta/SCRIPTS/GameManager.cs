using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI Score;

    public int POINTS;


    private void Update()
    {

        Score.text = POINTS.ToString();




    }


}
