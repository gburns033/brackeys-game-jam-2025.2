using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public GameObject endScreen;
    public TMP_Text scoreText;
    public BiscuitCounter biscuitCounter;
    private int time;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time++;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Exit"))
        {
            endScreen.SetActive(true);
            scoreText.text = "Score: " + (biscuitCounter.biscuits * time);
        }
    }
}
