using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform; // Transform del jugador.

    private Vector3 offset; // Diferencia inicial en X, Y y Z entre el objeto y el jugador.

    void Start()
    {
        if (playerTransform == null)
        {
            Debug.LogError("Player Transform no está asignado en el script ChasePlayer.");
            return;
        }

        // Calcula la diferencia inicial en X, Y y Z.
        offset = transform.position - playerTransform.position;

        Cursor.visible = false;
    }

    void Update()
    {
        if (playerTransform == null)
            return;

        // Calcula la nueva posición manteniendo el offset en X, Y y Z.
        transform.position = playerTransform.position + offset;
    }
}
