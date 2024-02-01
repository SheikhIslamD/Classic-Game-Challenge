using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallScript : MonoBehaviour
{
    public float minY = -5.5f;
    public float maxVelocity = 15f;

    public int lives = 3;

    public Image[] livesImage = new Image[4];
    public GameObject endScreen;
    public TextMeshProUGUI endText;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < minY)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;
            LifeUpdate();
        }

        if(rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
        }
    }

    void LifeUpdate()
    {
        lives--;
        int i = lives;
        foreach(Image image in livesImage)
        {
            if (i >= 0)
            {
                image.fillAmount = 1;
                i--;
            }
            else image.fillAmount = 0;
        }
        if (lives == 0)
        {
            //game over
            endScreen.SetActive(true);
            string text = "You Lose!";
            endText.text = text.ToString();
            Time.timeScale = 0;
        }
    }
}
