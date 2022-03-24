using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualScreenSetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i, width = 0, height = 0, n_display = Display.displays.Length;

        for (i = 0; i < n_display; i++)
        {
            Display.displays[i].Activate();
            width += Display.displays[i].renderingWidth;
            height = Mathf.Max(height, Display.displays[0].renderingHeight);
        }

        Screen.SetResolution(width, height, true);
    }
}
