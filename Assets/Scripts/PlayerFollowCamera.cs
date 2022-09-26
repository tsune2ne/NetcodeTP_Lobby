using Cinemachine;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    public static PlayerFollowCamera Singleton { get; private set; }

    CinemachineVirtualCamera cinemachineVirtualCamera;

    void Start()
    {
        Singleton = this;
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void SetTarget(Transform target)
    {
        cinemachineVirtualCamera.Follow = target;
    }
}
