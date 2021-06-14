using UnityEngine;
using UnityEngine.UI;

public class Meter : MonoBehaviour
{
    public Transform PlayerTransform;
    public Text MeterText;

    // Update is called once per frame
    void Update()
    {
        MeterText.text = PlayerTransform.position.x.ToString("0m");
    }
}
