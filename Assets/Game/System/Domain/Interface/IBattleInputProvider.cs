using UnityEngine;

public interface IBattleInputProvider
{
    /// <summary>
    /// �ړ������̓��͏���
    /// </summary>
    /// <returns>�ړ��̕���</returns>
    Vector2 GetMoveDir();

    /// <summary>
    /// �U���̓��͏���
    /// </summary>
    /// <returns>�U���̓��͔���</returns>
    bool GetFire();
}