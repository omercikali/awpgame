using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    private Vector2 touchStartPos;
    private Vector2 touchDelta;

    public float rotationSpeed = 0.5f;

    void Update()
    {
        // Dokunma ba�lang�� pozisyonunu kaydet
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = Input.mousePosition;
        }

        // Dokunma hareket ediyor mu kontrol et
        if (Input.GetMouseButton(0))
        {
            Vector2 touchEndPos = Input.mousePosition;
            touchDelta = touchEndPos - touchStartPos;

            // Kameran�n yeni rotasyon de�erlerini hesapla
            float rotationX = touchDelta.y * rotationSpeed;
            float rotationY = touchDelta.x * rotationSpeed;

            // Kameray� d�nd�r
            transform.Rotate(Vector3.up, -rotationY, Space.World);
            transform.Rotate(Vector3.right, rotationX, Space.Self);

            // Ba�lang�� pozisyonunu g�ncelle
            touchStartPos = touchEndPos;
        }
    }

}
