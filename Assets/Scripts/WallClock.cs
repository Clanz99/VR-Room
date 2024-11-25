using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClock : MonoBehaviour
{
    [SerializeField] public Transform hourHand;
    [SerializeField] public Transform minuteHand;
    [SerializeField] public Transform secondHand;

    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;

        // 30 degrees per hour, 6 degrees per minute e 6 degrees per second (360/12 = 30, 360/60 = 6)
        float hourRotation = (currentTime.Hour % 12) * 30f + (currentTime.Minute / 2f);
        float minuteRotation = currentTime.Minute * 6f;
        float secondRotation = currentTime.Second * 6f;

        if (hourHand != null)
            hourHand.localRotation = Quaternion.Euler(hourRotation, 0f, 0f);
        if (minuteHand != null)
            minuteHand.localRotation = Quaternion.Euler(minuteRotation, 0f, 0f);
        if (secondHand != null)
            secondHand.localRotation = Quaternion.Euler(secondRotation, 0f, 0f);
    }
}
