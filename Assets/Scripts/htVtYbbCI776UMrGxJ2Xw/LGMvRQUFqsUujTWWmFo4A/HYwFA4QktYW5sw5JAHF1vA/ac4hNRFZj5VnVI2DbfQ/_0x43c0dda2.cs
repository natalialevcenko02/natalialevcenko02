using UnityEngine;
using UnityEngine.UI;

public class _0x43c0dda2 : MonoBehaviour
{
    private int _0x47264ab8;
    private void Awake()
    {
        if (this._0x0ed8e4d0 == null)
            if (!this.TryGetComponent(out this._0x0ed8e4d0))
                this._0x0ed8e4d0 = this.GetComponentInChildren<Button>();
    }

    private bool _0x9390d982;
    private void Start()
    {
        if (this._0x9390d982)
            this._0x0ed8e4d0.onClick.AddListener(() => _0xb01be533.Instance._0x6f80a203());
        else
            this._0x0ed8e4d0.onClick.AddListener(() => _0xb01be533.Instance._0x00a24a4a(this._0x47264ab8));
    }

    private Button _0x0ed8e4d0;
}