using UnityEngine;

[System.Serializable]
public class PlayerAnimation
{
    [Tooltip("PlayerのAnimator")]
    [SerializeField]
    private Animator _animator;

    //[Header("IKの設定")]

    //[Tooltip("手の Position に対するウェイト")]
    //[SerializeField, Range(0f, 1f)]
    //private float _handPositionWeight = 0;

    //[Tooltip("手の Rotation に対するウェイト")]
    //[SerializeField, Range(0f, 1f)]
    //private float _handRotationWeight = 0;

    /// <summary>
    /// PlayerController内のUpdateで行う処理
    /// </summary>
    public void Update(Vector3 moveDir, float moveSpeed, float turnSpeed)
    {
        moveDir = moveDir.normalized;

        _animator.SetFloat(
            "SpeedX",
            moveDir.x);

        _animator.SetFloat(
            "SpeedZ",
            moveDir.y);

        _animator.SetFloat(
            "MoveSpeed",
            moveSpeed);

        _animator.SetFloat(
            "TurnSpeed",
            turnSpeed);
    }

    public void SetIK(Transform shootPos)
    {
        //_animator.SetIKPosition(
        //    AvatarIKGoal.RightHand,
        //    shootPos.transform.position);

        //_animator.SetIKRotation(
        //    AvatarIKGoal.RightHand,
        //    shootPos.transform.rotation);

        //_animator.SetIKPositionWeight(
        //    AvatarIKGoal.RightHand,
        //    _handPositionWeight);

        //_animator.SetIKRotationWeight(
        //    AvatarIKGoal.RightHand,
        //    -_handRotationWeight);
    }

    public void ChangeIKWeight(bool isAim)
    {
        //float weight = 0f;

        //if (isAim)
        //{
        //    weight = 1f;
        //}

        //_handPositionWeight = weight;
        //_handRotationWeight = weight;
    }
}
