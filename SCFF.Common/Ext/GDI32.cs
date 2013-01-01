﻿// Copyright 2012 Alalf <alalf.iQLc_at_gmail.com>
//
// This file is part of SCFF-DirectShow-Filter(SCFF DSF).
//
// SCFF DSF is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// SCFF DSF is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with SCFF DSF.  If not, see <http://www.gnu.org/licenses/>.

/// @file SCFF.Common/ExternalAPI.cs
/// SCFF.*モジュールで利用するGDI32.dllのAPIをまとめたクラス

namespace SCFF.Common.Ext {

using System;
using System.Runtime.InteropServices;

/// SCFF.*モジュールで利用するGDI32.dllのAPIをまとめたクラス
/// HWNDは特例としてUIntPtr、それ以外はIntPtrで取り扱うこと
public class GDI32 {
  // Constants
  public const int SRCCOPY    = 0x00CC0020;
  public const int CAPTUREBLT = 0x40000000;

  // public const int PS_SOLID    = 0x00000000;
  public const int PS_NULL        = 0x00000005;
  public const int R2_XORPEN      = 7;

  // API
  [DllImport("gdi32.dll")]
  public static extern int BitBlt(IntPtr hDestDC,
      int x, int y,
      int nWidth, int nHeight,
      IntPtr hSrcDC,
      int xSrc, int ySrc,
      int dwRop);

  [DllImport("gdi32.dll")]
  public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

  [DllImport("gdi32.dll")]
	public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

  [DllImport("gdi32.dll")]
  public static extern IntPtr CreatePen(int fnPenStyle, int nWidth, uint crColor);

  [DllImport("gdi32.dll")]
  public static extern int SetROP2(IntPtr hdc, int fnDrawMode);

  [DllImport("gdi32.dll")]
  public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

  [DllImport("gdi32.dll")]
  public static extern bool DeleteObject(IntPtr hObject);

  [DllImport("gdi32.dll")]
  public static extern int DeleteDC(IntPtr hDC);

  [DllImport("gdi32.dll")]
  public static extern bool Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);
}
}
