using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public GameObject endScreen;
    public TMP_Text scoreText;
    public BiscuitCounter biscuitCounter;
    private float startTime;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Exit"))
        {
            endScreen.SetActive(true);
            scoreText.text = "Score: " + ((biscuitCounter.biscuits + 1) * ((int)(Time.time - startTime) * 100)) * 10;
        }
    }
}
