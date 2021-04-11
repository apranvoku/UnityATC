using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour 
{


    public int flightNumber, departTime, arrivalTime, duration;


    public Flight(int _flightNumber, int _departTime, int _arrivalTime,int _duration)
    {

        flightNumber = _flightNumber;
        departTime = _departTime;
        arrivalTime = _arrivalTime;
        duration = _duration;

    }

}
