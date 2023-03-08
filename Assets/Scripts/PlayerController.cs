using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    bool islive=true;

    public Text scoreView;

    public Transform gameOver;

    [SerializeField]
    int score;

    public float jump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && islive)
        {
            rb.velocity = Vector2.up * jump;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("AddScore") && islive)
        {
            score++;
            string aux = score.ToString();
            scoreView.text = aux;
        }else if (collision.CompareTag("Pipe") || collision.CompareTag("Borda") && islive)
        {
            islive= false;
            gameOver.gameObject.SetActive(true);
            Invoke("Pause",2);
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
    }
}
