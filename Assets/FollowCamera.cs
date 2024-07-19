using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Kamera ile arabayı aynı anda yürütmesini sağlıyorum.
    [SerializeField] GameObject thingToFollow;
    
    //Late kameranın biraz geç gelmesini sağlıyorum titreme olmasın diye.
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
    }
}
