#region license

/* ====================================================================
 * The Apache Software License, Version 1.1
 *
 * Copyright (c) 2005 The Apache Software Foundation.  All rights
 * reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions
 * are met:
 *
 * 1. Redistributions of source code must retain the above copyright
 *    notice, this list of conditions and the following disclaimer.
 *
 * 2. Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in
 *    the documentation and/or other materials provided with the
 *    distribution.
 *
 * 3. The end-user documentation included with the redistribution,
 *    if any, must include the following acknowledgment:
 *       "This product includes software developed by the
 *        Apache Software Foundation (http://www.apache.org/)."
 *    Alternately, this acknowledgment may appear in the software itself,
 *    if and wherever such third-party acknowledgments normally appear.
 *
 * 4. The names "Apache" and "Apache Software Foundation" must
 *    not be used to endorse or promote products derived from this
 *    software without prior written permission. For written
 *    permission, please contact apache@apache.org.
 *
 * 5. Products derived from this software may not be called "Apache",
 *    nor may "Apache" appear in their name, without prior written
 *    permission of the Apache Software Foundation.
 *
 * THIS SOFTWARE IS PROVIDED ``AS IS'' AND ANY EXPRESSED OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED.  IN NO EVENT SHALL THE APACHE SOFTWARE FOUNDATION OR
 * ITS CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
 * LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF
 * USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT
 * OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF
 * SUCH DAMAGE.
 * ====================================================================
 *
 * This software consists of voluntary contributions made by many
 * individuals on behalf of the Apache Software Foundation.  For more
 * information on the Apache Software Foundation, please see
 * <http://www.apache.org/>.
 *
 * Portions of this software are based upon public domain software
 * originally written at the National Center for Supercomputing Applications,
 * University of Illinois, Urbana-Champaign.
 */

#endregion

#define   ALLOW_UNTESTED_STRUCTS
#define   ALLOW_UNTESTED_INTERFACES

using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DirectShowLib
{

	#region Declarations

#if ALLOW_UNTESTED_STRUCTS

	/// <summary>
	/// From VMRPresentationFlags
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRPresentationFlags
	{
		SyncPoint = 0x00000001,
		Preroll = 0x00000002,
		Discontinuity = 0x00000004,
		TimeValid = 0x00000008,
		SrcDstRectsValid = 0x00000010
	}

	/// <summary>
	/// From VMRSurfaceAllocationFlags
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRSurfaceAllocationFlags
	{
		PIXELFORMAT_VALID = 0x01,
		_3D_TARGET = 0x02,
		ALLOW_SYSMEM = 0x04,
		FORCE_SYSMEM = 0x08,
		DIRECTED_FLIP = 0x10,
		DXVA_TARGET = 0x20
	}

	/// <summary>
	/// From VMR_ASPECT_RATIO_MODE
	/// </summary>
	[ComVisible(false)]
	public enum VMRAspectRatioMode
	{
		None,
		LetterBox
	}

	/// <summary>
	/// From VMRMixerPrefs
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRMixerPrefs
	{
		NoDecimation = 0x00000001,
		DecimateOutput = 0x00000002,
		ARAdjustXorY = 0x00000004,
		DecimationReserved = 0x00000008,
		DecimateMask = 0x0000000F,

		BiLinearFiltering = 0x00000010,
		PointFiltering = 0x00000020,
		FilteringMask = 0x000000F0,

		RenderTargetRGB = 0x00000100,
		RenderTargetYUV = 0x00001000,

		RenderTargetYUV420 = 0x00000200,
		RenderTargetYUV422 = 0x00000400,
		RenderTargetYUV444 = 0x00000800,
		RenderTargetReserved = 0x0000E000,
		RenderTargetMask = 0x0000FF00,

		DynamicSwitchToBOB = 0x00010000,
		DynamicDecimateBy2 = 0x00020000,

		DynamicReserved = 0x000C0000,
		DynamicMask = 0x000F0000
	}

	/// <summary>
	/// From VMRMixerPrefs
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRRenderPrefs
	{
		RestrictToInitialMonitor = 0x00000000,
		ForceOffscreen = 0x00000001,
		ForceOverlays = 0x00000002,
		AllowOverlays = 0x00000000,
		AllowOffscreen = 0x00000000,
		DoNotRenderColorKeyAndBorder = 0x00000008,
		Reserved = 0x00000010,
		PreferAGPMemWhenMixing = 0x00000020,

		Mask = 0x0000003f,
	}

	/// <summary>
	/// From VMRMode
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRMode
	{
		Windowed = 0x00000001,
		Windowless = 0x00000002,
		Renderless = 0x00000004,
	}

	/// <summary>
	/// From VMRDeinterlacePrefs
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRDeinterlacePrefs
	{
		NextBest = 0x01,
		BOB = 0x02,
		Weave = 0x04,
		Mask = 0x07
	}

	/// <summary>
	/// From VMRDeinterlaceTech
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRDeinterlaceTech
	{
		Unknown = 0x0000,
		BOBLineReplicate = 0x0001,
		BOBVerticalStretch = 0x0002,
		MedianFiltering = 0x0004,
		EdgeFiltering = 0x0010,
		FieldAdaptive = 0x0020,
		PixelAdaptive = 0x0040,
		MotionVectorSteered = 0x0080
	}

	/// <summary>
	/// From VMRBITMAP_* defines
	/// </summary>
	[ComVisible(false), Flags]
	public enum VMRBitmap
	{
		Disable = 0x00000001,
		Hdc = 0x00000002,
		EntireDDS = 0x00000004,
		SRCColorKey = 0x00000008,
		SRCRect = 0x00000010
	}


	/// <summary>
	/// From VMRPRESENTATIONINFO
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRPresentationInfo
	{
		public int dwFlags;
		[MarshalAs(UnmanagedType.Interface)] public object lpSurf; //LPDIRECTDRAWSURFACE7
		public long rtStart;
		public long rtEnd;
		public Size szAspectRatio;
		public Rectangle rcSrc;
		public Rectangle rcDst;
		public int dwTypeSpecificFlags;
		public int dwInterlaceFlags;
	}

	/// <summary>
	/// From VMRALLOCATIONINFO
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRAllocationInfo
	{
		public int dwFlags;
		public BitmapInfoHeader lpHdr;
		public IntPtr lpPixFmt; //DDPixelFormat
		public Size szAspectRatio;
		public int dwMinBuffers;
		public int dwMaxBuffers;
		public int dwInterlaceFlags;
		public Size szNativeSize;
	}

	/// <summary>
	/// From VMRGUID
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRGuid
	{
		public IntPtr pGUID; // GUID *
		public Guid GUID;
	}

	/// <summary>
	/// From VMRMONITORINFO
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRMonitorInfo
	{
		public VMRGuid guid;
		public Rectangle rcMonitor;
		public IntPtr hMon; // HMONITOR
		public int dwFlags;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=32)] public string szDevice;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=512)] public string szDescription;
		public long liDriverVersion;
		public int dwVendorId;
		public int dwDeviceId;
		public int dwSubSysId;
		public int dwRevision;
	}

	/// <summary>
	/// From VMRFrequency
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRFrequency
	{
		public int dwNumerator;
		public int dwDenominator;
	}

	/// <summary>
	/// From VMRVideoDesc
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRVideoDesc
	{
		public int dwSize;
		public int dwSampleWidth;
		public int dwSampleHeight;
		[MarshalAs(UnmanagedType.Bool)] public bool SingleFieldPerSample;
		public int dwFourCC;
		public VMRFrequency InputSampleFreq;
		public VMRFrequency OutputFrameFreq;
	}

	/// <summary>
	/// From VMRDeinterlaceCaps
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRDeinterlaceCaps
	{
		public int dwSize;
		public int dwNumPreviousOutputFrames;
		public int dwNumForwardRefSamples;
		public int dwNumBackwardRefSamples;
		public VMRDeinterlaceTech DeinterlaceTechnology;
	}

	/// <summary>
	/// From VMRALPHABITMAP
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRAlphaBitmap
	{
		public int dwFlags;
		public IntPtr hdc; // HDC
		[MarshalAs(UnmanagedType.Interface)] public object pDDS; //LPDIRECTDRAWSURFACE7
		public Rectangle rSrc;
		public Rectangle rDest;
		public float fAlpha;
		public int clrSrcKey;
	}

	/// <summary>
	/// From VMRVIDEOSTREAMINFO
	/// </summary>
	[StructLayout(LayoutKind.Sequential), ComVisible(false)]
	public struct VMRVideoStreamInfo
	{
		[MarshalAs(UnmanagedType.Interface)] public object pddsVideoSurface;
		public int dwWidth;
		public int dwHeight;
		public int dwStrmID;
		public float fAlpha;
		public int ddClrKey;
		public Rectangle rNormal;
	}


#endif

	#endregion

	#region Interfaces

#if ALLOW_UNTESTED_INTERFACES

	[ComVisible(true), ComImport,
		Guid("CE704FE7-E71E-41fb-BAA2-C4403E1182F5"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRImagePresenter
	{
		[PreserveSig]
		int StartPresenting([In] int dwUserID);

		[PreserveSig]
		int StopPresenting([In] int dwUserID);

		[PreserveSig]
		int PresentImage(
			[In] int dwUserID,
			[In] ref VMRPresentationInfo lpPresInfo
			);
	}

	[ComVisible(true), ComImport,
		Guid("31ce832e-4484-458b-8cca-f4d7e3db0b52"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRSurfaceAllocator
	{
		[PreserveSig]
		int AllocateSurface(
			[In] int dwUserID,
			[In] VMRAllocationInfo lpAllocInfo,
			[Out] out int lpdwActualBuffers,
			[Out, MarshalAs(UnmanagedType.Interface)] out object lplpSurface // LPDIRECTDRAWSURFACE7
			);

		[PreserveSig]
		int FreeSurface([In] int dwID);

		[PreserveSig]
		int PrepareSurface(
			[In] int dwUserID,
			[In, MarshalAs(UnmanagedType.Interface)] object lplpSurface, // LPDIRECTDRAWSURFACE7
			[In] int dwSurfaceFlags
			);

		[PreserveSig]
		int AdviseNotify([In] IVMRSurfaceAllocatorNotify lpIVMRSurfAllocNotify);
	}

	[ComVisible(true), ComImport,
		Guid("aada05a8-5a4e-4729-af0b-cea27aed51e2"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRSurfaceAllocatorNotify
	{
		[PreserveSig]
		int AdviseSurfaceAllocator(
			[In] int dwUserID,
			[In] IVMRSurfaceAllocator lpIVRMSurfaceAllocator
			);

		[PreserveSig]
		int SetDDrawDevice(
			[In, MarshalAs(UnmanagedType.Interface)] object lpDDrawDevice,
			[In] IntPtr hMonitor // HMONITOR
			);

		[PreserveSig]
		int ChangeDDrawDevice(
			[In, MarshalAs(UnmanagedType.Interface)] object lpDDrawDevice,
			[In] IntPtr hMonitor // HMONITOR
			);

		[PreserveSig]
		int RestoreDDrawSurfaces();

		[PreserveSig]
		int NotifyEvent(
			[In] int EventCode,
			[In] int Param1,
			[In] int Param2
			);

		[PreserveSig]
		int SetBorderColor([In] int clrBorder);
	}

	[ComVisible(true), ComImport,
		Guid("1c1a17b0-bed0-415d-974b-dc6696131599"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRMixerControl
	{
		[PreserveSig]
		int SetAlpha(
			[In] int dwStreamID,
			[In] float Alpha
			);

		[PreserveSig]
		int GetAlpha(
			[In] int dwStreamID,
			[Out] out float Alpha
			);

		[PreserveSig]
		int SetZOrder(
			[In] int dwStreamID,
			[In] int dwZ
			);

		[PreserveSig]
		int GetZOrder(
			[In] int dwStreamID,
			[Out] out int dwZ
			);

		[PreserveSig]
		int SetOutputRect(
			[In] int dwStreamID,
			[In] Rectangle pRect
			);

		[PreserveSig]
		int GetOutputRect(
			[In] int dwStreamID,
			[Out] out Rectangle pRect
			);

		[PreserveSig]
		int SetBackgroundClr([In] int ClrBkg);

		[PreserveSig]
		int GetBackgroundClr([Out] out int ClrBkg);

		[PreserveSig]
		int SetMixingPrefs([In] VMRMixerPrefs dwMixerPrefs);

		[PreserveSig]
		int GetMixingPrefs([Out] out VMRMixerPrefs dwMixerPrefs);
	}

	[ComVisible(true), ComImport,
		Guid("9cf0b1b6-fbaa-4b7f-88cf-cf1f130a0dce"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRMonitorConfig
	{
		[PreserveSig]
		int SetMonitor([In] VMRGuid pGUID);

		[PreserveSig]
		int GetMonitor([Out] out VMRGuid pGUID);

		[PreserveSig]
		int SetDefaultMonitor([In] VMRGuid pGUID);

		[PreserveSig]
		int GetDefaultMonitor([Out] out VMRGuid pGUID);

		[PreserveSig]
		int GetAvailableMonitors(
			[Out] out IntPtr pInfo, // VMRMONITORINFO *
			[In] int dwMaxInfoArraySize,
			[Out] out int pdwNumDevices
			);
	}

	[ComVisible(true), ComImport,
		Guid("ede80b5c-bad6-4623-b537-65586c9f8dfd"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRAspectRatioControl
	{
		[PreserveSig]
		int GetAspectRatioMode([Out] out int lpdwARMode);

		[PreserveSig]
		int SetAspectRatioMode([In] int lpdwARMode);
	}

	[ComVisible(true), ComImport,
		Guid("bb057577-0db8-4e6a-87a7-1a8c9a505a0f"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRDeinterlaceControl
	{
		[PreserveSig]
		int GetNumberOfDeinterlaceModes(
			[In] VMRVideoDesc lpVideoDescription,
			[Out] out int lpdwNumDeinterlaceModes,
			[Out] out Guid lpDeinterlaceModes
			);

		[PreserveSig]
		int GetDeinterlaceModeCaps(
			[In] Guid lpDeinterlaceMode,
			[In] VMRVideoDesc lpVideoDescription,
			[Out] out VMRDeinterlaceCaps lpDeinterlaceCaps
			);

		[PreserveSig]
		int GetDeinterlaceMode(
			[In] int dwStreamID,
			[Out] out Guid lpDeinterlaceMode
			);

		[PreserveSig]
		int SetDeinterlaceMode(
			[In] int dwStreamID,
			[In] Guid lpDeinterlaceMode
			);

		[PreserveSig]
		int GetDeinterlacePrefs([Out] out int lpdwDeinterlacePrefs);

		[PreserveSig]
		int SetDeinterlacePrefs([In] int lpdwDeinterlacePrefs);

		[PreserveSig]
		int GetActualDeinterlaceMode(
			[In] int dwStreamID,
			[Out] out Guid lpDeinterlaceMode
			);
	}

	[ComVisible(true), ComImport,
		Guid("1E673275-0257-40aa-AF20-7C608D4A0428"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRMixerBitmap
	{
		[PreserveSig]
		int SetAlphaBitmap([In] VMRAlphaBitmap pBmpParms);

		[PreserveSig]
		int UpdateAlphaBitmapParameters([In] VMRAlphaBitmap pBmpParms);

		[PreserveSig]
		int GetAlphaBitmapParameters([Out] out VMRAlphaBitmap pBmpParms);
	}

	[ComVisible(true), ComImport,
		Guid("7a4fb5af-479f-4074-bb40-ce6722e43c82"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRImageCompositor
	{
		[PreserveSig]
		int InitCompositionTarget(
			[In, MarshalAs(UnmanagedType.Interface)] object pD3DDevice,
			[In, MarshalAs(UnmanagedType.Interface)] object pddsRenderTarget
			);

		[PreserveSig]
		int TermCompositionTarget(
			[In, MarshalAs(UnmanagedType.Interface)] object pD3DDevice,
			[In, MarshalAs(UnmanagedType.Interface)] object pddsRenderTarget
			);

		[PreserveSig]
		int SetStreamMediaType(
			[In] int dwStrmID,
			[In] AMMediaType pmt,
			[In, MarshalAs(UnmanagedType.Bool)] bool fTexture
			);

		[PreserveSig]
		int CompositeImage(
			[In, MarshalAs(UnmanagedType.Interface)] object pD3DDevice,
			[In, MarshalAs(UnmanagedType.Interface)] object pddsRenderTarget,
			[In] AMMediaType pmtRenderTarget,
			[In] long rtStart,
			[In] long rtEnd,
			[In] int dwClrBkGnd,
			[In] VMRVideoStreamInfo pVideoStreamInfo,
			[In] int cStreams
			);
	}

	[ComVisible(true), ComImport,
		Guid("058d1f11-2a54-4bef-bd54-df706626b727"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRVideoStreamControl
	{
		[PreserveSig]
		int SetColorKey([In] int lpClrKey);

		[PreserveSig]
		int GetColorKey([Out] out int lpClrKey);

		[PreserveSig]
		int SetStreamActiveState([In, MarshalAs(UnmanagedType.Bool)] bool fActive);

		[PreserveSig]
		int GetStreamActiveState([Out, MarshalAs(UnmanagedType.Bool)] out bool fActive);
	}

	[ComVisible(true), ComImport,
		Guid("a9849bbe-9ec8-4263-b764-62730f0d15d0"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRSurface
	{
		[PreserveSig]
		int IsSurfaceLocked();

		[PreserveSig]
		int LockSurface([Out] out IntPtr lpSurface); // BYTE**

		[PreserveSig]
		int UnlockSurface();

		[PreserveSig]
		int GetSurface([Out, MarshalAs(UnmanagedType.Interface)] out object lplpSurface);
	}

	[ComVisible(true), ComImport,
		Guid("9f3a1c85-8555-49ba-935f-be5b5b29d178"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRImagePresenterConfig
	{
		[PreserveSig]
		int SetRenderingPrefs([In] VMRRenderPrefs dwRenderFlags);

		[PreserveSig]
		int GetRenderingPrefs([Out] out VMRRenderPrefs dwRenderFlags);
	}

	[ComVisible(true), ComImport,
		Guid("e6f7ce40-4673-44f1-8f77-5499d68cb4ea"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVMRImagePresenterExclModeConfig : IVMRImagePresenterConfig
	{
		#region IVMRImagePresenterConfig Methods

		[PreserveSig]
		new int SetRenderingPrefs([In] VMRRenderPrefs dwRenderFlags);

		[PreserveSig]
		new int GetRenderingPrefs([Out] out VMRRenderPrefs dwRenderFlags);

		#endregion

		[PreserveSig]
		int SetXlcModeDDObjAndPrimarySurface(
			[In, MarshalAs(UnmanagedType.Interface)] object lpDDObj,
			[In, MarshalAs(UnmanagedType.Interface)] object lpPrimarySurf
			);

		[PreserveSig]
		int GetXlcModeDDObjAndPrimarySurface(
			[Out, MarshalAs(UnmanagedType.Interface)] out object lpDDObj,
			[Out, MarshalAs(UnmanagedType.Interface)] out object lpPrimarySurf
			);
	}

	[ComVisible(true), ComImport,
		Guid("aac18c18-e186-46d2-825d-a1f8dc8e395a"),
		InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IVPManager
	{
		[PreserveSig]
		int SetVideoPortIndex([In] int dwVideoPortIndex);

		[PreserveSig]
		int GetVideoPortIndex([Out] out int dwVideoPortIndex);
	}
#endif

    [ComVisible(true), ComImport,
    Guid("9e5530c5-7034-48b4-bb46-0b8a6efc8e36"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVMRFilterConfig
    {
        [PreserveSig]
        int SetImageCompositor([In] IVMRImageCompositor lpVMRImgCompositor);

        [PreserveSig]
        int SetNumberOfStreams([In] int dwMaxStreams);

        [PreserveSig]
        int GetNumberOfStreams([Out] out int pdwMaxStreams);

        [PreserveSig]
        int SetRenderingPrefs([In] VMRRenderPrefs dwRenderFlags);

        [PreserveSig]
        int GetRenderingPrefs([Out] out VMRRenderPrefs pdwRenderFlags);

        [PreserveSig]
        int SetRenderingMode([In] VMRMode Mode);

        [PreserveSig]
        int GetRenderingMode([Out] out VMRMode Mode);
    }

    [ComVisible(true), ComImport,
    Guid("0eb1088c-4dcd-46f0-878f-39dae86a51b7"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVMRWindowlessControl
    {
        [PreserveSig]
        int GetNativeVideoSize(
            [Out] out int lpWidth,
            [Out] out int lpHeight,
            [Out] out int lpARWidth,
            [Out] out int lpARHeight
            );

        [PreserveSig]
        int GetMinIdealVideoSize(
            [Out] out int lpWidth,
            [Out] out int lpHeight
            );

        [PreserveSig]
        int GetMaxIdealVideoSize(
            [Out] out int lpWidth,
            [Out] out int lpHeight
            );

        [PreserveSig]
        int SetVideoPosition(
            [In] ref Rectangle lpSRCRect,
            [In] ref Rectangle lpDSTRect
            );

        [PreserveSig]
        int GetVideoPosition(
            [Out] out Rectangle lpSRCRect,
            [Out] out Rectangle lpDSTRect
            );

        [PreserveSig]
        int GetAspectRatioMode([Out] out VMRAspectRatioMode lpAspectRatioMode);

        [PreserveSig]
        int SetAspectRatioMode([In] VMRAspectRatioMode AspectRatioMode);

        [PreserveSig]
        int SetVideoClippingWindow([In] IntPtr hwnd); // HWND

        [PreserveSig]
        int RepaintVideo(
            [In] IntPtr hwnd, // HWND
            [In] IntPtr hdc // HDC
            );

        [PreserveSig]
        int DisplayModeChanged();

        /// <summary>
        /// the caller is responsible for free the returned memory by calling CoTaskMemFree.
        /// </summary>
        [PreserveSig]
        int GetCurrentImage([Out] out IntPtr lpDib); // BYTE**

        [PreserveSig]
        int SetBorderColor([In] int Clr);

        [PreserveSig]
        int GetBorderColor([Out] out int lpClr);

        [PreserveSig]
        int SetColorKey([In] int Clr);

        [PreserveSig]
        int GetColorKey([Out] out int lpClr);
    }

    #endregion
}