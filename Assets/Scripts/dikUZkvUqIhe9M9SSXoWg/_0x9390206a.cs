using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// Owns the world-space board: frame, sockets, stones, emitters and facets.
///
/// EVERY size here is derived from the camera (rule C.0). The cell is sized so the
/// board PLUS the one-cell ring of emitters and facets fits inside the viewport on
/// both axes, which is why the divisor is Cols+2 and not Cols.
/// </summary>
public sealed class _0x9390206a : MonoBehaviour
{
    [SerializeField]
    private float _centreY = 0.25f;
    [SerializeField]
    private GameObject _blankPrefab;
    public void _0xe2290f15(float _0xefad92c5)
    {
        for (int _0x65f2711d = 0; _0x65f2711d < this._0x94ec2ef0.Count; _0x65f2711d++)
            if (this._0x94ec2ef0[_0x65f2711d] != null)
                this._0x94ec2ef0[_0x65f2711d]._0xf3e678d9(_0xefad92c5);
    }

    public void _0xd375a74d()
    {
        if (this._boardRoot == null)
            return;
        DOTween.Kill(this._boardRoot);
        this._boardRoot.localPosition = Vector3.zero;
        this._boardRoot.DOShakePosition(0.35f, this._0xd63bb090 * 0.26f, 18, 90f).SetEase(Ease.OutQuad);
    }

    /// <summary>Lights the facets of every beam that is on target, one after the other.</summary>
    public void _0x673e80ce(_0xdfdf0b34 _0x097644bf, _0xfa8fa6c6 _0x16566e74)
    {
        for (int _0x0f603b9d = 0; _0x0f603b9d < this._0x1600434b.Count && _0x0f603b9d < _0x097644bf._0xf9ecab52; _0x0f603b9d++)
        {
            SpriteRenderer _0x882fa227 = this._0x1600434b[_0x0f603b9d];
            if (_0x882fa227 == null)
                continue;
            _0x16566e74._0x859c0a79(_0x097644bf, _0x0f603b9d);
            if (!_0x16566e74._0xa82f55f0(_0x097644bf, _0x0f603b9d))
                continue;
            Color _0x77721db4 = _0x61e0b808.BeamColours[_0x0f603b9d % _0x61e0b808.BeamColours.Length];
            if (this._facetLitSprite != null)
                _0x882fa227.sprite = this._facetLitSprite;
            _0x882fa227.color = _0x61e0b808.WithAlpha(_0x77721db4, 0.55f);
            _0x882fa227.DOFade(1f, 0.22f).SetDelay(0.22f * _0x0f603b9d);
            Transform _0x11dec713 = _0x882fa227.transform;
            DOTween.Kill(_0x11dec713);
            _0x11dec713.localScale = Vector3.one;
            _0x11dec713.DOPunchScale(Vector3.one * 0.18f, 0.3f, 1, 0.5f).SetDelay(0.22f * _0x0f603b9d);
        }
    }

    /// <summary>Puts every facet back to its dull state before a fresh check.</summary>
    public void _0xa972463f(_0xdfdf0b34 _0x9275c6d8)
    {
        for (int _0xe7890dcb = 0; _0xe7890dcb < this._0x1600434b.Count; _0xe7890dcb++)
        {
            SpriteRenderer _0xec8b75ca = this._0x1600434b[_0xe7890dcb];
            if (_0xec8b75ca == null)
                continue;
            DOTween.Kill(_0xec8b75ca);
            if (_0xe7890dcb < this._0x60928c94.Count && this._0x60928c94[_0xe7890dcb] != null)
                _0xec8b75ca.sprite = this._0x60928c94[_0xe7890dcb];
            Color _0x08fb59eb = _0x61e0b808.BeamColours[_0xe7890dcb % _0x61e0b808.BeamColours.Length];
            _0xec8b75ca.color = _0x61e0b808.WithAlpha(_0x08fb59eb, 0.55f);
        }
    }

    public void _0x2362a394()
    {
        if (this._0xa56e6b27 == null)
            return;
        DOTween.Kill(this._0xa56e6b27.transform);
        this._0xa56e6b27.transform.localScale = Vector3.one;
        this._0xa56e6b27.gameObject.SetActive(false);
    }

    private const float StoneShare = 0.90f;
    private Camera _0xd7644d77;
    [SerializeField]
    private GameObject _onyxPrefab;
    [SerializeField]
    private GameObject _framePrefab;
    private float _0xd63bb090;
    private SpriteRenderer _0xa56e6b27;
    private void _0x07de0ece()
    {
        this._0x94ec2ef0.Clear();
        this._0x15d0b751.Clear();
        this._0x1600434b.Clear();
        this._0x60928c94.Clear();
        this._0xa56e6b27 = null;
        if (this._boardRoot == null)
            return;
        for (int _0x47686e57 = this._boardRoot.childCount - 1; _0x47686e57 >= 0; _0x47686e57--)
            Destroy(this._boardRoot.GetChild(_0x47686e57).gameObject);
    }

    [SerializeField]
    private GameObject _slotPrefab;
    private GameObject _0x4e8158b8(int _0x63da44d5)
    {
        if (_0x63da44d5 == _0xdfdf0b34.CellOnyx)
            return this._onyxPrefab;
        if (_0xdfdf0b34.IsMirror(_0x63da44d5))
            return this._mirrorPrefab;
        return this._blankPrefab;
    }

    public Camera _0xcc133bc4
    {
        get
        {
            return this._0xd7644d77;
        }
    }

    /// <summary>Centre of a grid cell in world space. Works for ring cells too.</summary>
    public Vector3 _0xd13a84c2(int _0xaac2c7ca, int _0x6fb62999)
    {
        if (!this._0x54bdab7c)
            this._0x7a23f52f();
        return new Vector3(this._0x9cfce72d.x + _0xaac2c7ca * this._0xd63bb090, this._0x9cfce72d.y + _0x6fb62999 * this._0xd63bb090, 0f);
    }

    public float _0xfa16ca94
    {
        get
        {
            return this._0xd63bb090;
        }
    }

    /// <summary>
    /// The mirror sprite is drawn as '/'. A '\' is the same art turned a quarter turn,
    /// so there is exactly one rotation constant and no flipX anywhere (rule C.8).
    /// </summary>
    private static float SpinFor(int _0xad23bed9)
    {
        return _0xad23bed9 == _0xdfdf0b34.CellBack ? 90f : 0f;
    }

    [SerializeField]
    private Transform _boardRoot;
    private bool _0x54bdab7c;
    [SerializeField]
    private Sprite _facetLitSprite;
    /// <summary>The scene camera is the tagged main camera; the director hands it over.</summary>
    public void _0xaf3358eb(Camera _0x4e5d5467)
    {
        this._0xd7644d77 = _0x4e5d5467;
    }

    private const float FrameBleed = 1.18f;
    /// <summary>Moves the two stone views to match a model swap that already happened.</summary>
    public void _0x16b501ef(_0x38484061 _0x2d879e70, _0x38484061 _0xbdc24a1b, float _0x4c99d69d)
    {
        if (_0x2d879e70 == null || _0xbdc24a1b == null)
            return;
        int _0x9eea571f = _0x2d879e70._0xbab8d297;
        int _0x81ba906a = _0x2d879e70._0xd63ba7bd;
        int _0xb2cde461 = _0xbdc24a1b._0xbab8d297;
        int _0xd9ae1da6 = _0xbdc24a1b._0xd63ba7bd;
        _0x2d879e70._0x98df786e(_0xb2cde461, _0xd9ae1da6, this._0xd13a84c2(_0xb2cde461, _0xd9ae1da6), _0x4c99d69d);
        _0xbdc24a1b._0x98df786e(_0x9eea571f, _0x81ba906a, this._0xd13a84c2(_0x9eea571f, _0x81ba906a), _0x4c99d69d);
    }

    private readonly List<Sprite> _0x60928c94 = new List<Sprite>(3);
    [SerializeField]
    private GameObject _facetPrefab;
    private static Color TintFor(int _0xc63b6e83)
    {
        if (_0xc63b6e83 == _0xdfdf0b34.CellOnyx)
            return _0x61e0b808.WithAlpha(_0x61e0b808.InkDeep, 1f);
        if (_0xdfdf0b34.IsMirror(_0xc63b6e83))
            return _0x61e0b808.Cream;
        return _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.92f);
    }

    private const float HeightShare = 0.52f;
    private readonly List<_0x38484061> _0x94ec2ef0 = new List<_0x38484061>(36);
    /// <summary>
    /// Builds the whole board. The FRAME is created FIRST so later content draws on
    /// top of it rather than under it (rule C.13); its centre is transparent art.
    /// </summary>
    public void _0x2656d0a0(_0xdfdf0b34 _0xc5d5a70a)
    {
        this._0x7a23f52f();
        this._0x07de0ece();
        float _0x9c0800b3 = this._0xd63bb090 * _0xdfdf0b34.Cols;
        Vector3 _0x98546916 = new Vector3(0f, this._centreY, 0f);
        if (this._framePrefab != null)
        {
            GameObject _0xdf8e6d41 = Instantiate(this._framePrefab, this._boardRoot);
            _0xdf8e6d41.transform.position = _0x98546916;
            _0xdf8e6d41.transform.localScale = Vector3.one;
            SpriteRenderer _0x540bca7e = _0xdf8e6d41.GetComponent<SpriteRenderer>();
            if (_0x540bca7e != null)
            {
                _0x540bca7e.size = new Vector2(_0x9c0800b3 * FrameBleed, _0x9c0800b3 * FrameBleed);
                _0x540bca7e.color = _0x61e0b808.WithAlpha(_0x61e0b808.Violet, 0.95f);
            }
        }

        // sockets
        for (int _0xde25d1ec = 0; _0xde25d1ec < _0xdfdf0b34.Rows; _0xde25d1ec++)
        {
            for (int _0x4b6f404e = 0; _0x4b6f404e < _0xdfdf0b34.Cols; _0x4b6f404e++)
            {
                if (this._slotPrefab == null)
                    continue;
                GameObject _0xe1149ce5 = Instantiate(this._slotPrefab, this._boardRoot);
                _0xe1149ce5.transform.position = this._0xd13a84c2(_0x4b6f404e, _0xde25d1ec);
                _0xe1149ce5.transform.localScale = Vector3.one;
                SpriteRenderer _0x19e59a09 = _0xe1149ce5.GetComponent<SpriteRenderer>();
                if (_0x19e59a09 == null)
                    continue;
                _0x19e59a09.size = new Vector2(this._0xd63bb090 * 0.98f, this._0xd63bb090 * 0.98f);
                float _0xa2f21526 = ((_0x4b6f404e + _0xde25d1ec) % 2 == 0) ? 0.71f : 0.59f;
                _0x19e59a09.color = _0x61e0b808.WithAlpha(_0x61e0b808.VioletDeep, _0xa2f21526);
            }
        }

        this._0xc5351d7d(_0xc5d5a70a);
        this._0xb65322e1(_0xc5d5a70a);
        this._0xa94e2978();
    }

    private void _0xc5351d7d(_0xdfdf0b34 _0xae753eeb)
    {
        float _0xa6efe1e3 = this._0xd63bb090 * StoneShare;
        for (int _0x57dcac51 = 0; _0x57dcac51 < _0xdfdf0b34.Rows; _0x57dcac51++)
        {
            for (int _0x941d32ee = 0; _0x941d32ee < _0xdfdf0b34.Cols; _0x941d32ee++)
            {
                int _0xc855c507 = _0xae753eeb._0x1b82a742(_0x941d32ee, _0x57dcac51);
                GameObject _0xdd142c35 = this._0x4e8158b8(_0xc855c507);
                if (_0xdd142c35 == null)
                    continue;
                GameObject _0x299494d7 = Instantiate(_0xdd142c35, this._boardRoot);
                _0x38484061 _0x1f696921 = _0x299494d7.GetComponent<_0x38484061>();
                if (_0x1f696921 == null)
                    continue;
                _0x1f696921._0x8d33fc1f(_0x941d32ee, _0x57dcac51, _0xc855c507, this._0xd13a84c2(_0x941d32ee, _0x57dcac51), _0xa6efe1e3, SpinFor(_0xc855c507));
                _0x1f696921._0x8c62502d(TintFor(_0xc855c507));
                this._0x94ec2ef0.Add(_0x1f696921);
                // drop-in cascade: 24 ms per cell, read left to right, bottom to top
                Transform _0x3aef6119 = _0x299494d7.transform;
                Vector3 _0x01764b96 = _0x3aef6119.position;
                _0x3aef6119.position = _0x01764b96 + new Vector3(0f, this._0xd63bb090 * 1.2f, 0f);
                _0x3aef6119.DOMove(_0x01764b96, 0.34f).SetDelay(0.024f * (_0x57dcac51 * _0xdfdf0b34.Cols + _0x941d32ee)).SetEase(Ease.OutBack);
            }
        }
    }

    private Vector2 _0x9cfce72d;
    public void _0x7a23f52f()
    {
        Camera _0xaf5fb1ca = this._0xd7644d77;
        if (_0xaf5fb1ca == null)
            return;
        float _0x540975ef = _0xaf5fb1ca.orthographicSize;
        float _0x762b2bad = _0x540975ef * _0xaf5fb1ca.aspect;
        float _0x6b317e4f = 2f * _0x762b2bad * WidthShare / (_0xdfdf0b34.Cols + 2);
        float _0x7d2fe79c = 2f * _0x540975ef * HeightShare / (_0xdfdf0b34.Rows + 2);
        this._0xd63bb090 = Mathf.Min(_0x6b317e4f, _0x7d2fe79c);
        float _0xa52bd6ab = this._0xd63bb090 * _0xdfdf0b34.Cols;
        float _0x6c53c079 = this._0xd63bb090 * _0xdfdf0b34.Rows;
        this._0x9cfce72d = new Vector2(-_0xa52bd6ab * 0.5f + this._0xd63bb090 * 0.5f, this._centreY - _0x6c53c079 * 0.5f + this._0xd63bb090 * 0.5f);
        this._0x54bdab7c = true;
    }

    [SerializeField]
    private GameObject _mirrorPrefab;
    private void _0xb65322e1(_0xdfdf0b34 _0x47e681bf)
    {
        float _0x5aa19e8a = this._0xd63bb090 * 0.86f;
        for (int _0x29d271e0 = 0; _0x29d271e0 < _0x47e681bf._0xf9ecab52; _0x29d271e0++)
        {
            Color _0xf989e89a = _0x61e0b808.BeamColours[_0x29d271e0 % _0x61e0b808.BeamColours.Length];
            if (this._emitterPrefab != null)
            {
                GameObject _0x6658e4b9 = Instantiate(this._emitterPrefab, this._boardRoot);
                _0x6658e4b9.transform.position = this._0xd13a84c2(_0x47e681bf._0xdb21a402(_0x29d271e0), _0x47e681bf._0xd9d14a80(_0x29d271e0));
                _0x6658e4b9.transform.localRotation = Quaternion.Euler(0f, 0f, _0x47e681bf._0x6a35a8be(_0x29d271e0) * 90f);
                _0x6658e4b9.transform.localScale = Vector3.one;
                SpriteRenderer _0x02a4b277 = _0x6658e4b9.GetComponent<SpriteRenderer>();
                if (_0x02a4b277 != null)
                {
                    _0x02a4b277.size = new Vector2(_0x5aa19e8a, _0x5aa19e8a);
                    _0x02a4b277.color = _0xf989e89a;
                }

                this._0x15d0b751.Add(_0x02a4b277);
            }

            if (this._facetPrefab != null)
            {
                GameObject _0x75a2d54c = Instantiate(this._facetPrefab, this._boardRoot);
                _0x75a2d54c.transform.position = this._0xd13a84c2(_0x47e681bf._0x6c353e1c(_0x29d271e0), _0x47e681bf._0x0cdf50a9(_0x29d271e0));
                _0x75a2d54c.transform.localScale = Vector3.one;
                SpriteRenderer _0x47093bc7 = _0x75a2d54c.GetComponent<SpriteRenderer>();
                if (_0x47093bc7 != null)
                {
                    _0x47093bc7.size = new Vector2(_0x5aa19e8a, _0x5aa19e8a);
                    _0x47093bc7.color = _0x61e0b808.WithAlpha(_0xf989e89a, 0.55f);
                }

                // kept in lockstep with _facets so LightFacets can index by beam
                this._0x1600434b.Add(_0x47093bc7);
                this._0x60928c94.Add(_0x47093bc7 == null ? null : _0x47093bc7.sprite);
            }
        }
    }

    /// <summary>World point to grid cell; returns false outside the playable grid.</summary>
    public bool _0xb1541bc0(Vector3 _0x13a5d9d0, out int _0x2abd4198, out int _0x9566fa1f)
    {
        _0x2abd4198 = 0;
        _0x9566fa1f = 0;
        if (!this._0x54bdab7c || this._0xd63bb090 <= 0f)
            return false;
        int _0x139091a8 = Mathf.RoundToInt((_0x13a5d9d0.x - this._0x9cfce72d.x) / this._0xd63bb090);
        int _0x76b36057 = Mathf.RoundToInt((_0x13a5d9d0.y - this._0x9cfce72d.y) / this._0xd63bb090);
        if (!_0xdfdf0b34.Inside(_0x139091a8, _0x76b36057))
            return false;
        Vector3 _0xb5d175f3 = this._0xd13a84c2(_0x139091a8, _0x76b36057);
        if (Mathf.Abs(_0x13a5d9d0.x - _0xb5d175f3.x) > this._0xd63bb090 * 0.5f || Mathf.Abs(_0x13a5d9d0.y - _0xb5d175f3.y) > this._0xd63bb090 * 0.5f)
            return false;
        _0x2abd4198 = _0x139091a8;
        _0x9566fa1f = _0x76b36057;
        return true;
    }

    [SerializeField]
    private GameObject _emitterPrefab;
    private readonly List<SpriteRenderer> _0x15d0b751 = new List<SpriteRenderer>(3);
    public void _0xcab2706b(int _0xc2dfeb0d, int _0x0e3b74f8)
    {
        if (this._0xa56e6b27 == null)
            return;
        Transform _0x7c393d5c = this._0xa56e6b27.transform;
        _0x7c393d5c.position = this._0xd13a84c2(_0xc2dfeb0d, _0x0e3b74f8);
        this._0xa56e6b27.gameObject.SetActive(true);
        DOTween.Kill(_0x7c393d5c);
        _0x7c393d5c.localScale = Vector3.one;
        _0x7c393d5c.DOScale(1.06f, 0.45f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private const float WidthShare = 0.92f;
    private readonly List<SpriteRenderer> _0x1600434b = new List<SpriteRenderer>(3);
    public _0x38484061 _0xe3b95147(int _0x888e8ea2, int _0x4e456627)
    {
        for (int _0x6c64f7e6 = 0; _0x6c64f7e6 < this._0x94ec2ef0.Count; _0x6c64f7e6++)
        {
            _0x38484061 _0xe98e2fe0 = this._0x94ec2ef0[_0x6c64f7e6];
            if (_0xe98e2fe0 != null && _0xe98e2fe0._0xbab8d297 == _0x888e8ea2 && _0xe98e2fe0._0xd63ba7bd == _0x4e456627)
                return _0xe98e2fe0;
        }

        return null;
    }

    private void _0xa94e2978()
    {
        if (this._slotPrefab == null)
            return;
        GameObject _0x8dcf12d7 = Instantiate(this._slotPrefab, this._boardRoot);
        _0x8dcf12d7.transform.localScale = Vector3.one;
        this._0xa56e6b27 = _0x8dcf12d7.GetComponent<SpriteRenderer>();
        if (this._0xa56e6b27 != null)
        {
            this._0xa56e6b27.sortingOrder = _0x61e0b808.SelectOrder;
            this._0xa56e6b27.size = new Vector2(this._0xd63bb090 * 1.04f, this._0xd63bb090 * 1.04f);
            this._0xa56e6b27.color = _0x61e0b808.WithAlpha(_0x61e0b808.Gold, 0.92f);
        }

        _0x8dcf12d7.SetActive(false);
    }
}