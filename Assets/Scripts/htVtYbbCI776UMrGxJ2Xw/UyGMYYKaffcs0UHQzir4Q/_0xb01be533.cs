using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x68897f3a;

public class _0xb01be533 : MonoBehaviour
{
    private void _0xdc3e2b53()
    {
        this._0xca181478(_0x215fc08c.SPLASH);
        if (_0x6da5105f.Instance._0x3d1ed677 == _0x35276d64.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x912c6d1c.Instance.DefaultAnimationTime);
        }
    }

    public float StaticBlurMaterialInitialValue;
    public float ScaleDuration = 0.4f;
    public bool IsShowSplashOnStart = true;
    private void SwitchSplash()
    {
        if (_0x9d9ccbbe.Instance.IsTutorialEnabled && !_0x6da5105f._0x0a396108._0x61bf0f96)
            this._0x00a24a4a(_0x215fc08c.TUTORIAL0);
        else
            this._0x00a24a4a(_0x215fc08c.DEFAULT);
    }

    public int CurrentPanelIndex;
    private void Start()
    {
        this._0xdc3e2b53();
    }

    public List<_0x9db1d5cc> Panels;
    private _0x9db1d5cc _0x3cdfe809(int _0x3bc2fbd3)
    {
        return this.Panels[_0x3bc2fbd3];
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xb01be533>();
    }

    public void _0xac68db00(int _0x3e3853d2)
    {
        if (_0x3e3853d2 == _0x215fc08c.SPLASH && _0x6da5105f.Instance._0x3d1ed677 != _0x35276d64.SCENE_0)
            _0x912c6d1c.Instance._0x5c408f5b();
        if (_0x6da5105f.Instance._0x3d1ed677 != _0x35276d64.SCENE_0)
        {
            if (_0x3e3853d2 == _0x215fc08c.SPLASH || _0x3e3853d2 == _0x215fc08c.TUTORIAL0)
                _0x6da5105f.Instance._0x1d3787ef(false);
            else if (_0x3e3853d2 == _0x215fc08c.DEFAULT)
                _0x6da5105f.Instance._0x1d3787ef(true);
        }
    }

    private void _0x41cd6bbb(int _0x49abfd5a)
    {
        this.LastPanelIndexes.Add(_0x49abfd5a);
        this.CurrentPanelIndex = _0x49abfd5a;
        for (int _0x8c493256 = 0; _0x8c493256 < this.Panels.Count; _0x8c493256++)
            if (_0x8c493256 != _0x49abfd5a && this.Panels[_0x8c493256] != null)
                this.Panels[_0x8c493256]._0x3f68c767();
    }

    public void _0x00a24a4a(int _0x8bd88e1f)
    {
        this._0x41cd6bbb(_0x8bd88e1f);
        this._0x47201470(_0x8bd88e1f);
        this.CurrentPanelIndex = _0x8bd88e1f;
        this.Panels[_0x8bd88e1f].Show();
    }

    private void _0xe7e90a2d(int _0x1ebb715c)
    {
        this.LastPanelIndexes.Add(_0x1ebb715c);
        this.CurrentPanelIndex = _0x1ebb715c;
        for (int _0xe9058e8b = 0; _0xe9058e8b < this.Panels.Count; _0xe9058e8b++)
            if (_0xe9058e8b != _0x1ebb715c && this.Panels[_0xe9058e8b] != null)
                this.Panels[_0xe9058e8b]._0x3f68c767();
    }

    private void _0xca181478(int _0xef76381c)
    {
        this._0x41cd6bbb(_0xef76381c);
        this._0x47201470(_0xef76381c);
        this.CurrentPanelIndex = _0xef76381c;
        this.Panels[_0xef76381c]._0xbe5036b0();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x47201470(int _0xeebdb8b8)
    {
        if (_0xeebdb8b8 == _0x215fc08c.SPLASH)
            _0x912c6d1c.Instance._0x0fd3d3de();
        if (_0x6da5105f.Instance._0x3d1ed677 == _0x35276d64.SCENE_0)
        {
        }
    }

    public void _0x6f80a203()
    {
        this.LastPanelIndexes.RemoveAll(_0xfacea7c4 => _0xfacea7c4 == this.CurrentPanelIndex);
        int _0x4d73a7f5 = this.LastPanelIndexes.Last();
        this._0x47201470(_0x4d73a7f5);
        this._0xe7e90a2d(_0x4d73a7f5);
        this.CurrentPanelIndex = _0x4d73a7f5;
        this.Panels[_0x4d73a7f5].Show();
    }

    public static _0xb01be533 Instance;
}