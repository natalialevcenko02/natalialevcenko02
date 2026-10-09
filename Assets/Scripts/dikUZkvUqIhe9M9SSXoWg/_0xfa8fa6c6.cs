using System.Collections.Generic;

/// <summary>
/// Walks one beam through the grid and records a segment per cell it crosses, so the
/// renderer can lay one tile per cell. A beam either leaves the grid (and may land on
/// its facet) or dies inside an onyx block.
/// </summary>
public sealed class _0xfa8fa6c6
{
    private readonly List<Segment> _0xeeb42ce7 = new List<Segment>(64);
    /// <summary>Did this beam leave the grid exactly through its own facet?</summary>
    public bool _0xa82f55f0(_0xdfdf0b34 _0xb397033d, int _0x68f96cfb)
    {
        return this._0xcb15d710 && this._0xa0cd9b14 == _0xb397033d._0x6c353e1c(_0x68f96cfb) && this._0x4adb8274 == _0xb397033d._0x0cdf50a9(_0x68f96cfb);
    }

    /// <summary>True when the beam left the grid instead of dying in a blocker.</summary>
    public bool _0xe43774d4
    {
        get
        {
            return this._0xcb15d710;
        }
    }

    private bool _0xcb15d710;
    public void _0x859c0a79(_0xdfdf0b34 _0x5aafede1, int _0x533e49e4)
    {
        this._0xeeb42ce7.Clear();
        this._0xcb15d710 = false;
        this._0xa0cd9b14 = 0;
        this._0x4adb8274 = 0;
        int _0x1c9f60c2 = _0x5aafede1._0x7bd5aef9(_0x533e49e4);
        int _0xfe31ec74 = _0x5aafede1._0x8911045b(_0x533e49e4);
        int _0x68ee16bb = _0x5aafede1._0x6a35a8be(_0x533e49e4);
        // A beam can only re-enter a cell on a different heading, and there are four
        // headings per cell, so this bound can never cut a legal path short.
        int _0x7141e9c9 = _0xdfdf0b34.Cols * _0xdfdf0b34.Rows * 4 + 4;
        while (_0x7141e9c9-- > 0)
        {
            if (!_0xdfdf0b34.Inside(_0x1c9f60c2, _0xfe31ec74))
            {
                this._0xcb15d710 = true;
                this._0xa0cd9b14 = _0x1c9f60c2;
                this._0x4adb8274 = _0xfe31ec74;
                return;
            }

            int _0x1f5db2cf = _0x5aafede1._0x1b82a742(_0x1c9f60c2, _0xfe31ec74);
            if (_0x1f5db2cf == _0xdfdf0b34.CellOnyx)
                return;
            int _0x819955d3 = _0xdfdf0b34.Deflect(_0x1f5db2cf, _0x68ee16bb);
            Segment _0x58055ac5;
            _0x58055ac5.X = _0x1c9f60c2;
            _0x58055ac5.Y = _0xfe31ec74;
            _0x58055ac5.DirIn = _0x68ee16bb;
            _0x58055ac5.DirOut = _0x819955d3;
            this._0xeeb42ce7.Add(_0x58055ac5);
            _0x68ee16bb = _0x819955d3;
            _0x1c9f60c2 += _0xdfdf0b34.DeltaX(_0x68ee16bb);
            _0xfe31ec74 += _0xdfdf0b34.DeltaY(_0x68ee16bb);
        }
    }

    private int _0xa0cd9b14;
    public IList<Segment> _0x51799421
    {
        get
        {
            return this._0xeeb42ce7;
        }
    }

    private int _0x4adb8274;
    public int _0x41d7b123
    {
        get
        {
            return this._0x4adb8274;
        }
    }

    /// <summary>Flat segment record: cell x, cell y, incoming dir, outgoing dir.</summary>
    public struct Segment
    {
        public int X;
        public int Y;
        public int DirIn;
        public int DirOut;
    }

    /// <summary>How many beams currently reach their own facet.</summary>
    public static int LitCount(_0xdfdf0b34 _0xdb975c87, _0xfa8fa6c6 _0x20c49b84)
    {
        int _0x0141f1d8 = 0;
        for (int _0xdb7efef6 = 0; _0xdb7efef6 < _0xdb975c87._0xf9ecab52; _0xdb7efef6++)
        {
            _0x20c49b84._0x859c0a79(_0xdb975c87, _0xdb7efef6);
            if (_0x20c49b84._0xa82f55f0(_0xdb975c87, _0xdb7efef6))
                _0x0141f1d8++;
        }

        return _0x0141f1d8;
    }

    /// <summary>Convenience: are all beams on target right now?</summary>
    public static bool AllBeamsLit(_0xdfdf0b34 _0xeb5d21e1, _0xfa8fa6c6 _0xc9ec973e)
    {
        for (int _0xc37b60cc = 0; _0xc37b60cc < _0xeb5d21e1._0xf9ecab52; _0xc37b60cc++)
        {
            _0xc9ec973e._0x859c0a79(_0xeb5d21e1, _0xc37b60cc);
            if (!_0xc9ec973e._0xa82f55f0(_0xeb5d21e1, _0xc37b60cc))
                return false;
        }

        return true;
    }

    public int _0x983097d0
    {
        get
        {
            return this._0xa0cd9b14;
        }
    }
}