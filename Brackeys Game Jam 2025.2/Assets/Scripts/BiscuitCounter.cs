using UnityEngine;
using TMPro;

public class BiscuitCounter : MonoBehaviour
{
    public int biscuits;
    public TMP_Text biscuitText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        biscuits = 0;
    }

    // Update is called once per frame
    void Update()
    {
        biscuitText.text = "Biscuits: " + biscuits;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        biscuits++;
    }
}
