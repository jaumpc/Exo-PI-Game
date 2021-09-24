using System.Collections;
using UnityEngine;

namespace SimplePlatform
{
    public class TwoPointMove : MonoBehaviour
    {
        [SerializeField] Transform pivot;
        [SerializeField] Transform pointA, pointB;
        [SerializeField] float speed = 1;
        [SerializeField] float restTime = 2;
        Transform target;
        public void Start()
        {
            target = pointA;
            StartCoroutine(MoveRoutine());
        }
        IEnumerator MoveRoutine()
        {
            var stepTime = new WaitForSeconds(.02f);
            while (true)
            {
                while (!IsAtTarget())
                {
                    StepTowardsTarget();
                    yield return stepTime;
                }
                SwapTarget();
                yield return new WaitForSeconds(restTime);
            }
        }
        bool IsAtTarget() => pivot.position == target.position;
        void StepTowardsTarget()
        {
            float step = speed * Time.deltaTime;
            pivot.position = Vector3.MoveTowards(pivot.position, target.position, step);
        }
        void SwapTarget() => target = target == pointA ? pointB : pointA;
    }
}