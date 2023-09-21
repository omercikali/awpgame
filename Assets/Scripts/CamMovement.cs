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
        // Dokunma baþlangýç pozisyonunu kaydet
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = Input.mousePosition;
        }

        // Dokunma hareket ediyor mu kontrol et
        if (Input.GetMouseButton(0))
        {
            Vector2 touchEndPos = Input.mousePosition;
            touchDelta = touchEndPos - touchStartPos;

            // Kameranýn yeni rotasyon deðerlerini hesapla
            float rotationX = touchDelta.y * rotationSpeed;
            float rotationY = touchDelta.x * rotationSpeed;

            // Kamerayý döndür
            transform.Rotate(Vector3.up, -rotationY, Space.World);
            transform.Rotate(Vector3.right, rotationX, Space.Self);

            // Baþlangýç pozisyonunu güncelle
            touchStartPos = touchEndPos;
        }
    }

}
