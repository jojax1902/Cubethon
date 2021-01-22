
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.z > 0)
        {
            scoreText.text = (player.position.z.ToString("0"));
        }
        else
        {
            scoreText.text = "Space to Start";
        }
        
    }
}
