﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    internal class CommonUnsafeNativeMethods
    {
        #region PInvoke General
        // If this value is used, %windows%\system32 is searched for the DLL 
        // and its dependencies. Directories in the standard search path are not searched.
        // Windows 7: this value requires KB2533623 to be installed.
        // Windows Server 2003 and Windows XP: This value is not supported.
        internal const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

        [DllImport(ExternDll.Kernel32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Ansi)]
        public static extern IntPtr GetProcAddress(HandleRef hModule, string lpProcName);

        [DllImport(ExternDll.Kernel32, SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string modName);

        [DllImport(ExternDll.Kernel32, CharSet = CharSet.Auto, SetLastError = true, BestFitMapping = false)]
        private static extern IntPtr LoadLibraryEx(string lpModuleName, IntPtr hFile, uint dwFlags);

        [DllImport(ExternDll.Kernel32, CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr LoadLibrary(string libname);

        [DllImport(ExternDll.Kernel32, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool FreeLibrary(HandleRef hModule);

        /// <summary>
        /// Loads library from system path only.
        /// </summary>
        /// <param name="libraryName"> Library name</param>
        /// <returns>module handle to the specified library if available. Otherwise, returns Intptr.Zero.</returns>
        public static IntPtr LoadLibraryFromSystemPathIfAvailable(string libraryName)
        {
            IntPtr module = IntPtr.Zero;

            // KB2533623 introduced the LOAD_LIBRARY_SEARCH_SYSTEM32 flag. It also introduced
            // the AddDllDirectory function. We test for presence of AddDllDirectory as an 
            // indirect evidence for the support of LOAD_LIBRARY_SEARCH_SYSTEM32 flag. 
            IntPtr kernel32 = GetModuleHandle(ExternDll.Kernel32);
            if (kernel32 != IntPtr.Zero)
            {
                if (GetProcAddress(new HandleRef(null, kernel32), "AddDllDirectory") != IntPtr.Zero)
                {
                    module = LoadLibraryEx(libraryName, IntPtr.Zero, LOAD_LIBRARY_SEARCH_SYSTEM32);
                }
                else
                {
                    // LOAD_LIBRARY_SEARCH_SYSTEM32 is not supported on this OS. 
                    // Fall back to using plain ol' LoadLibrary
                    // There is risk that this call might fail, or that it might be
                    // susceptible to DLL hijacking. 
                    module = LoadLibrary(libraryName);
                }
            }
            return module;
        }

        #endregion

        #region PInvoke DpiRelated
        // This section could go to Nativemethods.cs or Safenativemethods.cs but we have separate copies of them in each library (System.winforms, System.Design and System.Drawing).
        // These APIs are available starting Windows 10, version 1607 only.
        [DllImport(ExternDll.User32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern DpiAwarenessContext GetThreadDpiAwarenessContext();

        [DllImport(ExternDll.User32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern DpiAwarenessContext SetThreadDpiAwarenessContext(DpiAwarenessContext dpiContext);

        [DllImport(ExternDll.User32, SetLastError = true, ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern bool AreDpiAwarenessContextsEqual(DpiAwarenessContext dpiContextA, DpiAwarenessContext dpiContextB);

        /// <summary>
        /// Tries to compare two DPIawareness context values. Return true if they were equal. 
        /// Return false when they are not equal or underlying OS does not support this API.
        /// </summary>
        /// <returns>true/false</returns>
        public static bool TryFindDpiAwarenessContextsEqual(DpiAwarenessContext dpiContextA, DpiAwarenessContext dpiContextB)
        {
            if (ApiHelper.IsApiAvailable(ExternDll.User32, "AreDpiAwarenessContextsEqual"))
            {
                return AreDpiAwarenessContextsEqual(dpiContextA, dpiContextB);
            }

            return false;
        }

        /// <summary>
        /// Tries to set thread dpi awareness context
        /// </summary>
        /// <returns> returns old thread dpi awareness context if API is available in this version of OS. otherwise, return IntPtr.Zero.</returns>
        public static DpiAwarenessContext TrySetThreadDpiAwarenessContext(DpiAwarenessContext dpiCOntext)
        {
            if (ApiHelper.IsApiAvailable(ExternDll.User32, "SetThreadDpiAwarenessContext"))
            {
                return SetThreadDpiAwarenessContext(dpiCOntext);
            }
            else
            {
                // legacy OS that does not have this API available.
                return DpiAwarenessContext.DPI_AWARENESS_CONTEXT_UNSPECIFIED;
            }
        }
        /*
                // Dpi awareness context values. Matching windows values.
                public static readonly DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_UNAWARE = (-1);
                public static readonly DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_SYSTEM_AWARE = (-2);
                public static readonly DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE = (-3);
                public static readonly DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2 = (-4);
                public static readonly DPI_AWARENESS_CONTEXT DPI_AWARENESS_CONTEXT_UNSPECIFIED = (0);*/
        #endregion
    }
}
