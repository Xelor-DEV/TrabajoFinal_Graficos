using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform; // Transform del jugador.

    private Vector3 offsetXZ; // Diferencia inicial en X y Z entre el objeto y el jugador.
    private float fixedY;     // Altura fija del objeto.

    void Start()
    {
        if (playerTransform == null)
        {
            Debug.LogError("Player Transform no está asignado en el script ChasePlayerWithXZOffset.");
            return;
        }

        // Calcula la diferencia inicial en X y Z.
        offsetXZ = new Vector3(
            transform.position.x - playerTransform.position.x,
            0, // Ignorar la componente Y.
            transform.position.z - playerTransform.position.z
        );

        // Guarda la altura fija del objeto.
        fixedY = transform.position.y;
    }

    void Update()
    {
        if (playerTransform == null)
            return;

        // Calcula la nueva posición manteniendo el offset en X y Z, y fija en Y.
        transform.position = new Vector3(
            playerTransform.position.x + offsetXZ.x,
            fixedY,
            playerTransform.position.z + offsetXZ.z
        );
    }

}
