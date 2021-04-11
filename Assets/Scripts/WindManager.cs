using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindManager : MonoBehaviour
{
    public int windHeading;
    public int randNum;
    public int ticker;
    // Start is called before the first frame update
    void Start()
    {
        windHeading = 0;
        randNum = 0;
        ticker = 0;
    }

    // Update is called once per frame
    void Update()
    {

        randNum = Random.Range(1, 5);
        if(randNum == 1)
        {
            windHeading -= 1;
            windHeading = (windHeading + 360) % 360;
            this.transform.Rotate(new Vector3(0f, 0f, 1f));
        }
        if (randNum == 2)
        {
            windHeading += 1;
            windHeading = (windHeading + 360) % 360;
            this.transform.Rotate(new Vector3(0f, 0f, -1f));
        }

    }
}
