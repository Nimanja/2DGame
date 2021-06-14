using UnityEngine;
using UnityEngine.UI;

public class scoer : MonoBehaviour
{
    public Transform PlayerTransform;
    public Text score;
    public float coinValue;

    // Update is called once per frame
    void Update()
    {
        score.text = (PlayerTransform.position.x+coinValue).ToString("0");
    }

}
