using DG.Tweening;
using UnityEditor.Search;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    [SerializeField] private Transform cubeTransform;
    [SerializeField] private Transform objectiveTransform;
    [SerializeField,Range(0,5f)] private float durationTime;
    [SerializeField] private AnimationCurve easeFunction;

    public void StartAnimation()
    {
        cubeTransform.DOMove(objectiveTransform.position, durationTime).SetEase(easeFunction);
        cubeTransform.DOScale(objectiveTransform.localScale, durationTime).SetEase(easeFunction);
        cubeTransform.DORotateQuaternion(objectiveTransform.rotation, durationTime).SetEase(easeFunction);
    }
}