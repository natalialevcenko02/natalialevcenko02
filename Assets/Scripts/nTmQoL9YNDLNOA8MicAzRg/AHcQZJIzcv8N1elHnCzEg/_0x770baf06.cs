using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x770baf06 : MonoBehaviour
{
    private Vector3 _0x0ca78a4c { get; set; }

    private void _0xf32e213f()
    {
        float _0x001d22f6, _0x6d42cf85, _0x2ece260e, _0x62ae3738;
        if (this._0x46d5a120 == _0xf1770876.Landscape)
            this._0x4acf02c4.orthographicSize = 1f / this._0x4acf02c4.aspect * this._0xd62748ba / 2f;
        else
            this._0x4acf02c4.orthographicSize = this._0xd62748ba / 2f;
        this._0x28a07760 = 2f * this._0x4acf02c4.orthographicSize;
        this._0xf5400637 = this._0x28a07760 * this._0x4acf02c4.aspect;
        float _0x8841c5bc = this._0x4acf02c4.transform.position.x;
        float _0x74dbae3a = this._0x4acf02c4.transform.position.y;
        _0x001d22f6 = _0x8841c5bc - this._0xf5400637 / 2;
        _0x6d42cf85 = _0x8841c5bc + this._0xf5400637 / 2;
        _0x2ece260e = _0x74dbae3a + this._0x28a07760 / 2;
        _0x62ae3738 = _0x74dbae3a - this._0x28a07760 / 2;
        this._0x74f61ef2 = new Vector3(_0x001d22f6, _0x62ae3738, 0);
        this._0xf382c0f1 = new Vector3(_0x8841c5bc, _0x62ae3738, 0);
        this._0x7be0e349 = new Vector3(_0x6d42cf85, _0x62ae3738, 0);
        this._0x694d743a = new Vector3(_0x001d22f6, _0x74dbae3a, 0);
        this._0xb9e5c59b = new Vector3(_0x8841c5bc, _0x74dbae3a, 0);
        this._0x0ca78a4c = new Vector3(_0x6d42cf85, _0x74dbae3a, 0);
        this._0x33363fcd = new Vector3(_0x001d22f6, _0x2ece260e, 0);
        this._0xa0a13a55 = new Vector3(_0x8841c5bc, _0x2ece260e, 0);
        this._0x971cc3db = new Vector3(_0x6d42cf85, _0x2ece260e, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xae33a911;
        Matrix4x4 _0x82d06bbc = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x4acf02c4.orthographic)
        {
            float _0x02ea7493 = this._0x4acf02c4.farClipPlane - this._0x4acf02c4.nearClipPlane;
            float _0x5e0bf455 = (this._0x4acf02c4.farClipPlane + this._0x4acf02c4.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0x5e0bf455), new Vector3(this._0x4acf02c4.orthographicSize * 2 * this._0x4acf02c4.aspect, this._0x4acf02c4.orthographicSize * 2, _0x02ea7493));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x4acf02c4.fieldOfView, this._0x4acf02c4.farClipPlane, this._0x4acf02c4.nearClipPlane, this._0x4acf02c4.aspect);
        }

        Gizmos.matrix = _0x82d06bbc;
    }

    private Color _0xae33a911 = Color.white;
    //public bool executeInUpdate;
    private float _0xf5400637 { get; set; }
    private Vector3 _0x694d743a { get; set; }

    public enum _0xf1770876
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xf382c0f1 { get; set; }

    private _0xf1770876 _0x46d5a120 = _0xf1770876.Portrait;
    private Vector3 _0x971cc3db { get; set; }
    private Vector3 _0xa0a13a55 { get; set; }

    private static _0x770baf06 _0xd930f568;
    private new Camera _0x4acf02c4;
    private Vector3 _0x74f61ef2 { get; set; }

    private void Awake()
    {
        this._0x4acf02c4 = this.GetComponent<Camera>();
        _0xd930f568 = this;
        this._0xf32e213f();
    }

    private Vector3 _0x7be0e349 { get; set; }
    private Vector3 _0x33363fcd { get; set; }

    private float _0xd62748ba = 1;
    private Vector3 _0xb9e5c59b { get; set; }
    private float _0x28a07760 { get; set; }
}