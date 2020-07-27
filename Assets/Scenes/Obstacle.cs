using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner2D
{
    public class Obstacle : MonoBehaviour
    {
        public int damage = 1;
        public int speed = 5;

        private void Update()
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<PlayerController>().health -= damage;
                Debug.Log(collision.GetComponent<PlayerController>().health + " = Player health");
                Destroy(this.gameObject);

            }
        }
    }
}

