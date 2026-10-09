using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x04fe9665 : MonoBehaviour
{
    public Ease ease = Ease.OutSine;
    public bool IsScaledDownOnAwake = true;
    public bool IsOnlyYScale;
    public TMP_Text ContentHeaderText;
    public GameObject Content;
    public static void HideAllPops()
    {
        _0xad9ed8e9.Instance._0xad2ed0f3();
    }

    public TMP_Text ContentAdditionalText;
    public void _0xb6f850fa()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xeec0669c();
    }

    private bool _0x880b0121 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0xeec0669c()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public TMP_Text ContentMainText;
    public Image ContentImage;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public float scaleDuration = 0.4f;
}