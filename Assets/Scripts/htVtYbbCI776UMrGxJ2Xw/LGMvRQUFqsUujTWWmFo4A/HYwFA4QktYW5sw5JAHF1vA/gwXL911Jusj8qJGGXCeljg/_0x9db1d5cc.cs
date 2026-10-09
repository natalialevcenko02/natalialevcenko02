using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x9db1d5cc : MonoBehaviour
{
    public bool IsScaledDownOnAwake = true;
    private void _0xe6e95775()
    {
        if (this.OuterBackground != null)
        {
            Image _0xdfe07aa8 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xdfe07aa8, true);
            _0xdfe07aa8.DOFade(1f, 0f);
        }
    }

    private void _0xda976e62()
    {
        if (this.OuterBackground != null)
        {
            Image _0x161be5d3 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x161be5d3, true);
            _0x161be5d3.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0xcd31a051()
    {
        if (this.OuterBackground != null)
        {
            Image _0x53afb185 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x53afb185, true);
            _0x53afb185.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public void _0x3f68c767()
    {
        this._0xa7364165();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public TMP_Text MainText;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0xcd31a051();
    }

    private bool _0x507ee7b1 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public void _0xbe5036b0()
    {
        this._0xe6e95775();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xb01be533.Instance._0xac68db00(_0xb01be533.Instance.CurrentPanelIndex);
    }

    public float ScaleDuration = 0.4f;
    private void _0xa7364165()
    {
        if (this.OuterBackground != null)
        {
            Image _0x13a2eb98 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x13a2eb98, true);
            _0x13a2eb98.DOFade(0f, this.ScaleDuration);
        }
    }

    public GameObject Content;
    public void Show()
    {
        this._0xda976e62();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xb01be533.Instance._0xac68db00(_0xb01be533.Instance.CurrentPanelIndex);
            });
        }
    }

    public Ease Ease = Ease.OutSine;
    public TMP_Text HeaderText;
    public GameObject OuterBackground;
}