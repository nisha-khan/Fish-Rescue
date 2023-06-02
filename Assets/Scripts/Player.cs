using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine("IncreaseGameSpeed");
    }

    // Update is called once per frame
    void Update()
    {
       
            float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    
        
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    IEnumerator IncreaseGameSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);

            if(playerSpeed < 8)
            {
                playerSpeed += 0.9f;
            }

            GameObject.Find("Spawn Point").GetComponent<SpawnObstacles>().timeBetweenSpawn -= 0.1f;
        }
    }
}
