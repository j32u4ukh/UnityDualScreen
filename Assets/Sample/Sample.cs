using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public GameObject obj;

    private GUIStyle gui_style = new GUIStyle();

    // Start is called before the first frame update
    void Start()
    {
        float z = 10.0f;
        Debug.Log($"Screen.width: {Screen.width}, Screen.height: {Screen.height}");

        Vector3 left1 = camera1.ScreenToWorldPoint(new Vector3(0, 0, z));
        Vector3 right1 = camera1.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, z));
        Debug.Log($"left1: {vectorToString(left1)}, right1: {vectorToString(right1)}");

        Vector3 left2 = camera2.ScreenToWorldPoint(new Vector3(0, 0, z));
        Vector3 right2 = camera2.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, z));
        Debug.Log($"left2: {vectorToString(left2)}, right2: {vectorToString(right2)}");
    }

    // Update is called once per frame
    void Update()
    {
        float x_move = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        float y_move = Input.GetAxis("Vertical") * Time.deltaTime * 5;
        obj.transform.position = new Vector3(obj.transform.position.x + x_move, 
                                             obj.transform.position.y + y_move, 
                                             obj.transform.position.z);
    }

    private void OnGUI()
    {
        gui_style.fontSize = 50;
        GUI.Label(new Rect(10, 10, 100, 20), vectorToString(obj.transform.position), gui_style);
    }

    string vectorToString(Vector3 v)
    {
        return string.Format("({0:F4}, {1:F4}, {2:F4})", v.x, v.y, v.z);
    }
}
