using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    public class Spawner : MonoBehaviour
    {
        public GameObject obstacle;

        public float timeBtwSpawn;
        public float startTimeBtwSpawn;
        public float decreaseTime;
        public float minTime;

        void Update()
        {
            if(timeBtwSpawn <= 0)
            {
                Instantiate(obstacle, transform.position, Quaternion.identity, this.gameObject.transform);
                timeBtwSpawn = startTimeBtwSpawn;

                if(startTimeBtwSpawn > minTime)
                {
                    startTimeBtwSpawn -= decreaseTime;
                }
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }
    }
}

