using UnityEngine;
using UnityEngine.UI;

public class scoer : MonoBehaviour
{
    public Transform PlayerTransform;
    public Text score;
    public float coinValue;
    public float scoreInLevel;
    public float total;

    private void Start()
    {
        scoreInLevel = PlayerPrefs.GetFloat("ScoreInLevel");
    }

    // Update is called once per frame
    void Update()
    {
        //score.text = (PlayerTransform.position.x+coinValue).ToString("0");
        scoreInLevel = PlayerTransform.position.x + coinValue + total;
        score.text = scoreInLevel.ToString("0");
    }

}
