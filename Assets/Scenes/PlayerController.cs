using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner2D{
    
public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;

    public float yIncrement;
    public float speed;
    public float maxHeight, minHeight;

    public int health = 3;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime); ;

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
        }
    }
}

}

