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

        float hourRotation = (currentTime.Hour % 12) * 30f + (currentTime.Minute / 2f);
        float minuteRotation = currentTime.Minute * 6f;
        float secondRotation = currentTime.Second * 6f;

        if (hourHand != null)
            hourHand.localRotation = Quaternion.Euler(0f, 0f, -hourRotation);
        if (minuteHand != null)
            minuteHand.localRotation = Quaternion.Euler(0f, 0f, -minuteRotation);
        if (secondHand != null)
            secondHand.localRotation = Quaternion.Euler(0f, 0f, -secondRotation);
    }
}
