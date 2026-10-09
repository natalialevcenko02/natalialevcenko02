using DG.Tweening;
using UnityEngine;

/// <summary>
/// One stone on the grid. Size is driven through SpriteRenderer.size (the renderer is
/// Sliced) so the drawn width is authoritative and a 1024px source can never render
/// ten world units wide; transform scale stays at 1 and is only ever borrowed by the
/// selection pulse, which restores it.
/// </summary>
public sealed class _0x38484061 : MonoBehaviour
{
    public int _0xa36d37d0
    {
        get
        {
            return this._0xc9e15af2;
        }
    }

    public SpriteRenderer _0x6e31100f
    {
        get
        {
            return this._renderer;
        }
    }

    [SerializeField]
    private SpriteRenderer _renderer;
    public int _0xbab8d297
    {
        get
        {
            return this._0xfb9b6581;
        }
    }

    public void _0x8c62502d(Color _0xaf1c8121)
    {
        if (this._renderer != null)
            this._renderer.color = _0xaf1c8121;
    }

    public void _0x8d33fc1f(int _0x0064ebf1, int _0x60c63001, int _0x770b6bf0, Vector3 _0xcbc88f0e, float _0x2e324411, float _0x2ebdea81)
    {
        this._0xfb9b6581 = _0x0064ebf1;
        this._0x2b8ada2e = _0x60c63001;
        this._0xc9e15af2 = _0x770b6bf0;
        this.transform.position = _0xcbc88f0e;
        this.transform.localRotation = Quaternion.Euler(0f, 0f, _0x2ebdea81);
        this.transform.localScale = Vector3.one;
        if (this._renderer != null)
            this._renderer.size = new Vector2(_0x2e324411, _0x2e324411);
    }

    public void _0xf3e678d9(float _0xcd9d057c)
    {
        if (this._renderer == null)
            return;
        this._renderer.DOFade(0f, _0xcd9d057c);
    }

    private int _0x2b8ada2e;
    public int _0xd63ba7bd
    {
        get
        {
            return this._0x2b8ada2e;
        }
    }

    private int _0xfb9b6581;
    /// <summary>Slides to a new home; the caller has already updated the model.</summary>
    public void _0x98df786e(int _0xf923abec, int _0xc4a6372b, Vector3 _0x5d1fcf2b, float _0x44ff6249)
    {
        this._0xfb9b6581 = _0xf923abec;
        this._0x2b8ada2e = _0xc4a6372b;
        DOTween.Kill(this.transform);
        this.transform.DOMove(_0x5d1fcf2b, _0x44ff6249).SetEase(Ease.OutCubic);
    }

    private int _0xc9e15af2;
}