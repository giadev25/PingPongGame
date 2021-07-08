using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.x = transform.position.x; 
        worldPosition.z = 0;
        transform.position = worldPosition;

        Cursor.visible = false;
    }
}
