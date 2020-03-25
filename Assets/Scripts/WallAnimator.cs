using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAnimator : MonoBehaviour
{
    [SerializeField] public NumberWizard gameplay;
    [SerializeField] public GameObject wallLeftObject;
    [SerializeField] public GameObject wallRightObject;
    private List<Vector3> leftWallPositions;
    private List<Vector3> rightWallPositions;

    // Start is called before the first frame update
    void Start()
    {
        leftWallPositions = new List<Vector3>
        {
            wallLeftObject.transform.position,
            wallLeftObject.transform.position + new Vector3(0.85f, 0f, 0f),
            wallLeftObject.transform.position + new Vector3(1.7f, 0f, 0f),
            wallLeftObject.transform.position + new Vector3(2.55f, 0f, 0f),
            wallLeftObject.transform.position + new Vector3(3.4f, 0f, 0f),
            wallLeftObject.transform.position + new Vector3(4.25f, 0f, 0f)
        };

        rightWallPositions = new List<Vector3>
        {
            wallRightObject.transform.position,
            wallRightObject.transform.position + new Vector3(-0.85f, 0f, 0f),
            wallRightObject.transform.position + new Vector3(-1.7f, 0f, 0f),
            wallRightObject.transform.position + new Vector3(-2.55f, 0f, 0f),
            wallRightObject.transform.position + new Vector3(-3.4f, 0f, 0f),
            wallRightObject.transform.position + new Vector3(-4.25f, 0f, 0f)
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (gameplay.numGuesses == 0)
        {
            wallLeftObject.transform.position = leftWallPositions[0];
            wallRightObject.transform.position = rightWallPositions[0];
        }
        else if (gameplay.numGuesses == 1)
        {
            wallLeftObject.transform.position = leftWallPositions[1];
            wallRightObject.transform.position = rightWallPositions[1];
        }
        else if (gameplay.numGuesses == 2)
        {
            wallLeftObject.transform.position = leftWallPositions[2];
            wallRightObject.transform.position = rightWallPositions[2];
        }
        else if (gameplay.numGuesses == 3)
        {
            wallLeftObject.transform.position = leftWallPositions[3];
            wallRightObject.transform.position = rightWallPositions[3];
        }
        else if (gameplay.numGuesses == 4)
        {
            wallLeftObject.transform.position = leftWallPositions[4];
            wallRightObject.transform.position = rightWallPositions[4];
        }
        else if (gameplay.numGuesses == 5)
        {
            wallLeftObject.transform.position = leftWallPositions[5];
            wallRightObject.transform.position = rightWallPositions[5];
        }
    }
}
