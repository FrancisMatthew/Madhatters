using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public ScoreTrackerScript scoreTracker;
    public Camera mainCamera;

    //I wrote this script on exactly 0 hours of sleep so dont yell if its bad

    public Transform minPoint;
    public Transform maxPoint;
    public Transform t1Win;
    public Transform t2Win;

    public float[] distancePoints = new float[3];
    private int pointIndex = 0;

    private Vector3 currentCameraPosition;
    private Vector3 targetCameraPosition;

    public int interpolationFrameCount = 60;

    private float interpolationRatio = 0f;

    void Start()
    {
        mainCamera.transform.position = minPoint.position;
    }

    void Update()
    {
        StartCoroutine(AdjustCamera());

    }

    public IEnumerator AdjustCamera()
    {
        yield return new WaitForSeconds(0);
        switch(scoreTracker.team1Members)
        {
            case 0:
                targetCameraPosition = t2Win.position;
                currentCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[pointIndex]);
                pointIndex = 2;

                for (int elapsedFrames = 0; elapsedFrames < interpolationFrameCount; elapsedFrames++)
                {
                    interpolationRatio = (float)elapsedFrames / interpolationFrameCount;
                    Vector3 interpolatedPosition = Vector3.Lerp(currentCameraPosition, targetCameraPosition, interpolationRatio);
                    mainCamera.transform.position = interpolatedPosition;
                    Debug.Log(elapsedFrames.ToString());
                    Debug.Log(interpolationRatio.ToString());
                }

                yield break;
            case 1:
                targetCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[2]);
                currentCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[pointIndex]);
                pointIndex = 2;

                for (int elapsedFrames = 0; elapsedFrames < interpolationFrameCount; elapsedFrames++)
                {
                    interpolationRatio = (float)elapsedFrames / interpolationFrameCount;
                    Vector3 interpolatedPosition = Vector3.Lerp(currentCameraPosition, targetCameraPosition, interpolationRatio);
                    mainCamera.transform.position = interpolatedPosition;
                    Debug.Log(elapsedFrames.ToString());
                    Debug.Log(interpolationRatio.ToString());
                }

                yield break;
            case 2:
                targetCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[1]);
                currentCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[pointIndex]);
                pointIndex = 1;

                for (int elapsedFrames = 0; elapsedFrames < interpolationFrameCount; elapsedFrames++)
                {
                    interpolationRatio = (float)elapsedFrames / interpolationFrameCount;
                    Vector3 interpolatedPosition = Vector3.Lerp(currentCameraPosition, targetCameraPosition, interpolationRatio);
                    mainCamera.transform.position = interpolatedPosition;
                    Debug.Log(elapsedFrames.ToString());
                    Debug.Log(interpolationRatio.ToString());
                }

                yield break;
            case 3:
                targetCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[0]);
                currentCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[pointIndex]);
                pointIndex = 0;

                for (int elapsedFrames = 0; elapsedFrames < interpolationFrameCount; elapsedFrames++)
                {
                    interpolationRatio = (float)elapsedFrames / interpolationFrameCount;
                    Vector3 interpolatedPosition = Vector3.Lerp(currentCameraPosition, targetCameraPosition, interpolationRatio);
                    mainCamera.transform.position = interpolatedPosition;
                    Debug.Log(elapsedFrames.ToString());
                    Debug.Log(interpolationRatio.ToString());
                }

                yield break;
            case 4:
                targetCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[1]);
                currentCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[pointIndex]);
                pointIndex = 1;

                for (int elapsedFrames = 0; elapsedFrames < interpolationFrameCount; elapsedFrames++)
                {
                    interpolationRatio = (float)elapsedFrames / interpolationFrameCount;
                    Vector3 interpolatedPosition = Vector3.Lerp(currentCameraPosition, targetCameraPosition, interpolationRatio);
                    mainCamera.transform.position = interpolatedPosition;
                    Debug.Log(elapsedFrames.ToString());
                    Debug.Log(interpolationRatio.ToString());
                }

                yield break;
            case 5:
                targetCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[2]);
                currentCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[pointIndex]);
                pointIndex = 2;

                for (int elapsedFrames = 0; elapsedFrames < interpolationFrameCount; elapsedFrames++)
                {
                    interpolationRatio = (float)elapsedFrames / interpolationFrameCount;
                    Vector3 interpolatedPosition = Vector3.Lerp(currentCameraPosition, targetCameraPosition, interpolationRatio);
                    mainCamera.transform.position = interpolatedPosition;
                    Debug.Log(elapsedFrames.ToString());
                    Debug.Log(interpolationRatio.ToString());
                    Debug.Log(targetCameraPosition.ToString());
                    Debug.Log(currentCameraPosition.ToString());
                }

                yield break;
            case 6:
                targetCameraPosition = t1Win.position;
                currentCameraPosition = Vector3.Lerp(minPoint.position, maxPoint.position, distancePoints[pointIndex]);
                pointIndex = 2;

                for (int elapsedFrames = 0; elapsedFrames < interpolationFrameCount; elapsedFrames++)
                {
                    interpolationRatio = (float)elapsedFrames / interpolationFrameCount;
                    Vector3 interpolatedPosition = Vector3.Lerp(currentCameraPosition, targetCameraPosition, interpolationRatio);
                    mainCamera.transform.position = interpolatedPosition;
                    Debug.Log(elapsedFrames.ToString());
                    Debug.Log(interpolationRatio.ToString());
                }

                yield break;
            default:
                mainCamera.transform.position = Vector3.zero;
                yield break;
        }
    }
    
}
