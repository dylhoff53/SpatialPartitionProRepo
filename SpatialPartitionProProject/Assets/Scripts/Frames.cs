using SpatialPartitionPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frames : MonoBehaviour
{
    public Text frames;
    public GameObject gameController;

    public void Update()
    {
        frames.text = gameController.GetComponent<GameController>().elapsedTime.ToString("");
    }
}
