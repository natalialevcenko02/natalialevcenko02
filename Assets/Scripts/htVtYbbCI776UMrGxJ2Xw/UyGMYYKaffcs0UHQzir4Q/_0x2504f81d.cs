using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x2504f81d : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x9bc3ca05 = this.gameObject.GetComponent<_0x2504f81d>();
    }

    private Touch? _0x4cb64a72(Bounds _0x3deeab1d)
    {
        if (!_0x6da5105f.Instance._0x8f648b25)
            return null;
        foreach (Touch _0x50a504b2 in Touch.activeTouches)
            if (_0x50a504b2.ended)
            {
                Vector3 _0xa4ad70f7 = Camera.main.ScreenToWorldPoint(_0x50a504b2.screenPosition);
                Vector3 _0x09927f40 = new(_0xa4ad70f7.x, _0xa4ad70f7.y, _0x3deeab1d.center.z);
                if (_0x3deeab1d.Contains(_0x09927f40) && this._0x567d1054(_0x50a504b2))
                    return _0x50a504b2;
            }

        return null;
    }

    private Touch? _0xc42bb7d6()
    {
        if (!_0x6da5105f.Instance._0x8f648b25)
            return null;
        foreach (Touch _0xfd035213 in Touch.activeTouches)
            if (!_0xfd035213.ended)
                if (this._0x567d1054(_0xfd035213))
                    return _0xfd035213;
        return null;
    }

    private bool _0xad1f35c9(Touch? _0x692d3405, Bounds _0xe15c7248, TouchPhase _0xa17ba592)
    {
        if (!_0x6da5105f.Instance._0x8f648b25)
        {
            _0x692d3405 = null;
            return false;
        }

        if (_0x692d3405 != null)
            if (_0x692d3405.Value.phase == _0xa17ba592)
            {
                Vector3 _0x2d95b02c = Camera.main.ScreenToWorldPoint(_0x692d3405.Value.screenPosition);
                Vector3 _0xe6fc0c5b = new(_0x2d95b02c.x, _0x2d95b02c.y, _0xe15c7248.center.z);
                if (_0xe15c7248.Contains(_0xe6fc0c5b) && this._0x567d1054(_0x692d3405.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0xd9432346(Bounds _0x616351e9)
    {
        if (!_0x6da5105f.Instance._0x8f648b25)
            return null;
        foreach (Touch _0xa259a25c in Touch.activeTouches)
            if (!_0xa259a25c.ended)
            {
                Vector3 _0x8f6bc80f = Camera.main.ScreenToWorldPoint(_0xa259a25c.screenPosition);
                Vector3 _0x5311a2a0 = new(_0x8f6bc80f.x, _0x8f6bc80f.y, _0x616351e9.center.z);
                if (_0x616351e9.Contains(_0x5311a2a0) && this._0x567d1054(_0xa259a25c))
                    return _0xa259a25c;
            }

        return null;
    }

    private static _0x2504f81d _0x9bc3ca05;
    private Touch? _0xd208f6b9()
    {
        if (!_0x6da5105f.Instance._0x8f648b25)
            return null;
        foreach (Touch _0x22c0397f in Touch.activeTouches)
            if (_0x22c0397f.ended)
                if (this._0x567d1054(_0x22c0397f))
                    return _0x22c0397f;
        return null;
    }

    private bool _0x567d1054(Touch? _0x51b2bfdc)
    {
        if (!_0x51b2bfdc.HasValue)
            return false;
        Vector3 _0x7db000f3 = Camera.main.ScreenToWorldPoint(_0x51b2bfdc.Value.screenPosition);
        Vector3 _0xc03d82dc = _0x7db000f3;
        _0xc03d82dc.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xc03d82dc))
            return true;
        _0x51b2bfdc = null;
        return false;
    }

    private void _0xe6e26731(Touch? _0x43dc7b9a)
    {
        if (!_0x6da5105f.Instance._0x8f648b25)
        {
            _0x43dc7b9a = null;
            return;
        }

        int _0xa96f5437 = _0x43dc7b9a.Value.touchId;
        _0x43dc7b9a = Touch.activeTouches.FirstOrDefault(_0x929ae118 => _0x929ae118.touchId == _0xa96f5437);
        if (!this._0x567d1054(_0x43dc7b9a.Value))
            _0x43dc7b9a = null;
    }

    private Touch? _0xb245634c(Bounds _0xc7606889, TouchPhase _0xd7f72280)
    {
        if (!_0x6da5105f.Instance._0x8f648b25)
            return null;
        foreach (Touch _0x233348cf in Touch.activeTouches)
            if (_0x233348cf.phase == _0xd7f72280)
            {
                Vector3 _0x0b1e8564 = Camera.main.ScreenToWorldPoint(_0x233348cf.screenPosition);
                Vector3 _0x7d52a5c3 = new(_0x0b1e8564.x, _0x0b1e8564.y, _0xc7606889.center.z);
                if (_0xc7606889.Contains(_0x7d52a5c3) && this._0x567d1054(_0x233348cf))
                    return _0x233348cf;
            }

        return null;
    }

    public BoxCollider2D CameraTouchBounds;
}