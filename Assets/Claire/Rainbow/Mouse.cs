using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private float mouseDistance = 10f;
    private Vector3 lastMouseCoordinate = Vector3.zero;
    private void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mouseDistance;
        Vector3 mouseDelta = mousePos - lastMouseCoordinate;
        if ((mouseDelta.x != 0) || (mouseDelta.y != 0))
        {
            //particles.Play();
            particles.transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        }
        //else particles.Stop();
        lastMouseCoordinate = Input.mousePosition;
    }
}
