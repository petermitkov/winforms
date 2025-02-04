﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

///  ***************** FxCop Suppressions for System.Windows.Forms & System.Drawing ********************
///  
///  WARNING:  When adding suppressions, make sure you add them to the right macro definition block,
///            this is because the different set of GDI library files compile into different assemblies.
///            
///  ***************************************************************************************************

using System.Diagnostics.CodeAnalysis;

#if DRAWING_DESIGN_NAMESPACE ////////////////////////////////// FxCop suppressions for System.Windows.Forms.dll //////////////////////////////////

[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.CreateDC(System.String,System.String,System.String,System.Runtime.InteropServices.HandleRef):System.Windows.Forms.Internal.DeviceContext")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.CreateIC(System.String,System.String,System.String,System.Runtime.InteropServices.HandleRef):System.Windows.Forms.Internal.DeviceContext")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.get_DeviceContextType():System.Windows.Forms.Internal.DeviceContextType")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.get_DpiX():System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.TranslateTransform(System.Single,System.Single):System.Void")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsFont.ToString():System.String")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.DrawText(System.String,System.Drawing.Point):System.Void")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.DrawText(System.String,System.Drawing.Point,System.Drawing.Color):System.Void")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.get_Font():System.Windows.Forms.Internal.WindowsFont")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsFont.FromHdc(System.IntPtr):System.Windows.Forms.Internal.WindowsFont")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsFont.FromHfont(System.IntPtr):System.Windows.Forms.Internal.WindowsFont")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsFont.FromHfont(System.IntPtr,System.Boolean):System.Windows.Forms.Internal.WindowsFont")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsFont.get_Italic():System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.FromHwnd(System.IntPtr):System.Windows.Forms.Internal.WindowsGraphics")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.get_GraphicsMode():System.Windows.Forms.Internal.DeviceContextGraphicsMode")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Internal.DeviceContext.SetGraphicsMode(System.Windows.Forms.Internal.DeviceContextGraphicsMode):System.Windows.Forms.Internal.DeviceContextGraphicsMode")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "System.Windows.Forms.Control+ImeModeConversion.get_ChineseTable():System.Windows.Forms.ImeMode[]")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphicsCacheManager..cctor()")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.FillRectangle(System.Windows.Forms.Internal.WindowsBrush,System.Int32,System.Int32,System.Int32,System.Int32):System.Void")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsBrush.FromBrush(System.Drawing.Brush):System.Windows.Forms.Internal.WindowsBrush")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1803:AvoidCostlyCallsWherePossible", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.get_TextPadding():System.Windows.Forms.Internal.TextPaddingOptions")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1803:AvoidCostlyCallsWherePossible", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.set_TextPadding(System.Windows.Forms.Internal.TextPaddingOptions):System.Void")]

[assembly: SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.Dispose():System.Void")]

[assembly: SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.GetOverhangPadding(System.Windows.Forms.Internal.WindowsFont,System.Boolean):System.Int32")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsFont.ToString():System.String")]

[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphics.Dispose(System.Boolean):System.Void")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphicsCacheManager.OnApplicationExit(System.Object,System.EventArgs):System.Void")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsGraphicsCacheManager.OnThreadExit(System.Object,System.EventArgs):System.Void")]

[assembly: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsBrush.nativeHandle")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsFont.hFont")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsPen.nativeHandle")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2006:UseSafeHandleToEncapsulateNativeResources", Scope = "member", Target = "System.Windows.Forms.Internal.WindowsBitmap.nativeHandle")]

// These are debug calls
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Control.get_CanEnableIme():System.Boolean")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Control.ImeModeRestricted(System.Boolean,System.Boolean):System.Void")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Control.WmImeNotify(System.Windows.Forms.Message&):System.Void")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Control+ImeContext.SetOpenStatus(System.Boolean,System.IntPtr):System.Void")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Control+ImeContext.SetImeStatus(System.Windows.Forms.ImeMode,System.IntPtr):System.Void")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Control+ImeContext.TraceImeStatus(System.IntPtr):System.Void")]
[assembly: SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", Scope = "member", Target = "System.Windows.Forms.Control+ImeContext.TraceImeStatus(System.IntPtr):System.Void")]

namespace System.Windows.Forms.Internal


#elif DRAWING_NAMESPACE ////////////////////////////////// FxCop suppressions for System.Drawing.dll //////////////////////////////////

//// SECURITY

// FxCop...
//
// Unfortunate that we have to suppress this, but this class is shared between assemblies and trying to split it up in multiple classes
// takes more time than we have right now (12/14/2004). It's quite spaghetti...
//
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.WindowsRegion.get_HRegion():System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.DeviceContext.SetClip(System.Drawing.Internal.WindowsRegion):System.Void")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSelectClipRgn(System.Runtime.InteropServices.HandleRef,System.Runtime.InteropServices.HandleRef):System.Drawing.Internal.IntNativeMethods+RegionFlags")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SelectClipRgn(System.Runtime.InteropServices.HandleRef,System.Runtime.InteropServices.HandleRef):System.Drawing.Internal.IntNativeMethods+RegionFlags")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntNativeMethods+RECT.FromXYWH(System.Int32,System.Int32,System.Int32,System.Int32):System.Drawing.Internal.IntNativeMethods+RECT")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntNativeMethods+RECT.ToRectangle():System.Drawing.Rectangle")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.CreateBitmap(System.Int32,System.Int32,System.Int32,System.Int32,System.Byte[]):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.CreateHatchBrush(System.Int32,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.CreatePen(System.Int32,System.Int32,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.CreateSolidBrush(System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.ExtCreatePen(System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+LOGBRUSH,System.Int32,System.Int32[]):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.GdiFlush():System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.GetUserDefaultLCID():System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.IntCreateBitmap(System.Int32,System.Int32,System.Int32,System.Int32,System.Byte[]):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.IntCreateHatchBrush(System.Int32,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.IntCreatePen(System.Int32,System.Int32,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.IntCreateSolidBrush(System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.IntExtCreatePen(System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+LOGBRUSH,System.Int32,System.Int32[]):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntAngleArc(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Single,System.Single):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntArc(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntBeginPath(System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntBitBlt(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32,System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntCreateCompatibleBitmap(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntCreateCompatibleDC(System.Runtime.InteropServices.HandleRef):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntCreateDIBSection(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+BITMAPINFO&,System.Int32,System.IntPtr&,System.IntPtr,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntCreateDIBSection(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+BITMAPINFO_FLAT&,System.Int32,System.IntPtr&,System.IntPtr,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntCreateFontIndirect(System.Object):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntCreatePatternBrush(System.Runtime.InteropServices.HandleRef):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntDPtoLP(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+POINT,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.DrawTextA(System.Runtime.InteropServices.HandleRef,System.Byte[],System.Int32,System.Drawing.Internal.IntNativeMethods+RECT&,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.DrawText(System.Runtime.InteropServices.HandleRef,System.String,System.Drawing.Internal.IntNativeMethods+RECT&,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.DrawTextW(System.Runtime.InteropServices.HandleRef,System.String,System.Int32,System.Drawing.Internal.IntNativeMethods+RECT&,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.DrawTextExA(System.Runtime.InteropServices.HandleRef,System.Byte[],System.Int32,System.Drawing.Internal.IntNativeMethods+RECT&,System.Int32,System.Drawing.Internal.IntNativeMethods+DRAWTEXTPARAMS):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.DrawTextEx(System.Runtime.InteropServices.HandleRef,System.String,System.Drawing.Internal.IntNativeMethods+RECT&,System.Int32,System.Drawing.Internal.IntNativeMethods+DRAWTEXTPARAMS):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.DrawTextExW(System.Runtime.InteropServices.HandleRef,System.String,System.Int32,System.Drawing.Internal.IntNativeMethods+RECT&,System.Int32,System.Drawing.Internal.IntNativeMethods+DRAWTEXTPARAMS):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntEllipse(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntEndPath(System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.ExtTextOut(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+RECT&,System.String,System.Int32,System.Int32[]):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntFillRect(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+RECT&,System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetBkColor(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetBkMode(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetCurrentObject(System.Runtime.InteropServices.HandleRef,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetDeviceCaps(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetMapMode(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetNearestColor(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetObject(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+BITMAP):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetObject(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+LOGBRUSH):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetObject(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+LOGFONT):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetObject(System.Runtime.InteropServices.HandleRef,System.Int32,System.Drawing.Internal.IntNativeMethods+BITMAP):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetObject(System.Runtime.InteropServices.HandleRef,System.Int32,System.Drawing.Internal.IntNativeMethods+LOGBRUSH):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetObject(System.Runtime.InteropServices.HandleRef,System.Int32,System.Drawing.Internal.IntNativeMethods+LOGFONT):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetROP2(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetStockObject(System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextAlign(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextColor(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextExtentPoint32A(System.Runtime.InteropServices.HandleRef,System.Byte[],System.Int32,System.Drawing.Internal.IntNativeMethods+SIZE):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextExtentPoint32(System.Runtime.InteropServices.HandleRef,System.String,System.Drawing.Internal.IntNativeMethods+SIZE):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextExtentPoint32W(System.Runtime.InteropServices.HandleRef,System.String,System.Int32,System.Drawing.Internal.IntNativeMethods+SIZE):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextMetrics(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+TEXTMETRIC&):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextMetricsA(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+TEXTMETRICA&):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetTextMetricsW(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+TEXTMETRIC&):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntLineTo(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntMoveToEx(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+POINT):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntRectangle(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSelectObject(System.Runtime.InteropServices.HandleRef,System.Runtime.InteropServices.HandleRef):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetBkColor(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSetBkMode(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSetMapMode(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSetROP2(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetTextAlign(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetTextColor(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntStrokePath(System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.WideCharToMultiByte(System.Int32,System.Int32,System.String,System.Int32,System.Byte[],System.Int32,System.IntPtr,System.IntPtr):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.WindowsGraphics.CreateMeasurementWindowsGraphics():System.Drawing.Internal.WindowsGraphics")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.WindowsGraphics.FromGraphics(System.Drawing.Graphics):System.Drawing.Internal.WindowsGraphics")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.WindowsGraphics.FromHdc(System.IntPtr):System.Drawing.Internal.WindowsGraphics")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.WindowsGraphics.FromHwnd(System.IntPtr):System.Drawing.Internal.WindowsGraphics")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.WindowsGraphics.get_DeviceContext():System.Drawing.Internal.DeviceContext")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.DeviceContext.FromCompatibleDC(System.IntPtr):System.Drawing.Internal.DeviceContext")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.DeviceContext.get_DeviceContextType():System.Drawing.Internal.DeviceContextType")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.StrokePath(System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetROP2(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetMapMode(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetGraphicsMode(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetBkMode(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SelectObject(System.Runtime.InteropServices.HandleRef,System.Runtime.InteropServices.HandleRef):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.Rectangle(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.MoveToEx(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+POINT):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.LineTo(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSetGraphicsMode(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntFillRect(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+RECT&,System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntBitBlt(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32,System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetStockObject(System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetROP2(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetObject(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+LOGFONT):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetObject(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+LOGBRUSH):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetMapMode(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetGraphicsMode(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetDeviceCaps(System.Runtime.InteropServices.HandleRef,System.Int32):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetCurrentObject(System.Runtime.InteropServices.HandleRef,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetBkMode(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetBkColor(System.Runtime.InteropServices.HandleRef):System.Int32")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.FillRect(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+RECT&,System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.EndPath(System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.Ellipse(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.DPtoLP(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+POINT,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.CreatePatternBrush(System.Runtime.InteropServices.HandleRef):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.CreateFontIndirect(System.Object):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.CreateCompatibleDC(System.Runtime.InteropServices.HandleRef):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.CreateCompatibleBitmap(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32):System.IntPtr")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.BitBlt(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32,System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.BeginPath(System.Runtime.InteropServices.HandleRef):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.Arc(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.AngleArc(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Int32,System.Single,System.Single):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntNativeMethods+POINT.ToPoint():System.Drawing.Point")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.GPRECT.ToRectangle():System.Drawing.Rectangle")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.GPPOINT.ToPoint():System.Drawing.PointF")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.DeviceContext.SetGraphicsMode(System.Drawing.Internal.DeviceContextGraphicsMode):System.Drawing.Internal.DeviceContextGraphicsMode")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.DeviceContext.get_GraphicsMode():System.Drawing.Internal.DeviceContextGraphicsMode")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetViewportOrgEx(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+POINT):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.GetViewportExtEx(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+SIZE):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSetViewportExtEx(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+SIZE):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntSetViewportOrgEx(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+POINT):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetViewportOrgEx(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+POINT):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetViewportExtEx(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+SIZE):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.SetViewportExtEx(System.Runtime.InteropServices.HandleRef,System.Int32,System.Int32,System.Drawing.Internal.IntNativeMethods+SIZE):System.Boolean")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope="member", Target="System.Drawing.Internal.IntUnsafeNativeMethods.IntGetViewportOrgEx(System.Runtime.InteropServices.HandleRef,System.Drawing.Internal.IntNativeMethods+POINT):System.Boolean")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope="type", Target="System.Drawing.Internal.IntSafeNativeMethods+CommonHandles")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope="type", Target="System.Drawing.Internal.IntNativeMethods+SIZE")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope="type", Target="System.Drawing.Internal.IntNativeMethods+POINT")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods+CommonHandles..cctor()")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1801:AvoidUnusedParameters", Scope="member", Target="System.Drawing.Internal.DbgUtil.AssertFinalization(System.Object,System.Boolean):System.Void")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1801:AvoidUnusedParameters", Scope="member", Target="System.Drawing.Internal.DbgUtil.AssertFinalization(System.Object,System.Boolean):System.Void")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1818:DoNotConcatenateStringsInsideLoops", Scope="member", Target="System.Drawing.Internal.DbgUtil.StackFramesToStr(System.Int32):System.String")]

[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope="member", Target="System.Drawing.Internal.DbgUtil.GetLastErrorStr():System.String")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope="member", Target="System.Drawing.Internal.DbgUtil.StackFramesToStr(System.Int32):System.String")]
[assembly: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope="member", Target="System.Drawing.Internal.WindowsGraphics.Dispose(System.Boolean):System.Void")]

[assembly: SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke", Scope="member", Target="System.Drawing.Internal.DbgUtil.GetLastErrorStr():System.String")]

[assembly: SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", Scope="member", Target="System.Drawing.Internal.WindowsGraphics.Dispose():System.Void")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2205:UseManagedEquivalentsOfWin32Api", Scope="member", Target="System.Drawing.Internal.IntSafeNativeMethods.GetUserDefaultLCID():System.Int32")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2205:UseManagedEquivalentsOfWin32Api", Scope="member", Target="System.Drawing.Internal.DbgUtil.GetUserDefaultLCID():System.Int32")]



namespace System.Drawing.Internal

#else
namespace System.Experimental.Gdi
#endif
{
}

