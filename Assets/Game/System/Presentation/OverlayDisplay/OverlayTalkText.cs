using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// オーバーレイ表示のテキストを表示するクラス
/// </summary>
[RequireComponent(typeof(TextMeshProUGUI))]
public class OverlayTalkText : MonoBehaviour, IUIComponent
{
    [SerializeField]
    private TextMeshProUGUI _tmp;

    public void Initialized()
    {
        _tmp.text = string.Empty;
    }

    // 非同期(UniTask)でテキストの表示を行う
    public async UniTask SetTextAsync(string text)
    {
        
    }
}
