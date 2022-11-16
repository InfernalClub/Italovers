using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{

    private int fpsLimit = 60;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = fpsLimit;
    }

}
