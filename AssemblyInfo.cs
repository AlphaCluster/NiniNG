#region Copyright
//
// NiniNG Configuration Project.
//
// Copyright (C) 2014 Nicholas Omann
// Copyright (C) 2006 Brent R. Matzelle.  All rights reserved.
//
// This software is published under the terms of the MIT X11 license, a copy of 
// which has been included with this distribution in the LICENSE.txt file.
// 
#endregion

using System;
using System.Reflection;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("NiniNG")]

[assembly: AssemblyDescription(".NET NextGen Configuration Library - https://github.com/AlphaCluster/NiniNG")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Nicholas Omann")]
[assembly: AssemblyProduct("NiniNG")]
[assembly: AssemblyCopyright("Copyright (c) 2014 Nicholas Omann")]
[assembly: AssemblyTrademark("Copyright (c) 2014 Nicholas Omann")]
[assembly: AssemblyDefaultAlias("NiniNG")]
[assembly: AssemblyCulture("")]

#if STRONG
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile(@"..\..\Nini.key")]
#endif

[assembly: System.Reflection.AssemblyVersion("1.0.0.0")]

[assembly:CLSCompliant(true)] // Required for CLS compliance

// Mark as false by default and explicity set others as true
[assembly:ComVisible(false)]

// Permview attributes
#if (NET_COMPACT_1_0)
#else
[assembly:IsolatedStorageFilePermission(SecurityAction.RequestMinimum)]
[assembly:SecurityPermission(SecurityAction.RequestRefuse)]
[assembly:FileIOPermission(SecurityAction.RequestMinimum)]
#endif
