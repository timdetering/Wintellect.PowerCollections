//******************************
// Written by Peter Golde
// Copyright (c) 2004-2007, Wintellect
//
// Use and restribution of this code is subject to the license agreement 
// contained in the file "License.txt" accompanying this file.
//******************************

using System.Reflection;
using System.Runtime.CompilerServices;

// Make internals of this library available to the unit test framework.
// NOTE: If you are building the PowerCollections with your own key you will need to change the public key below.
[assembly: InternalsVisibleTo("Wintellect.PowerCollections.Tests, PublicKey = " +
"0024000004800000940000000602000000240000525341310004000001000100094e056116d23654c58fb4438f80555edc1ba42f47c23ac2cf50585aa5040edda143d88717cc9405293e50e04a8b7ba419a967f7cd7a9d453b23461bbb6dd5a7df6706de63494db86f7607b7b96551f7f494375296678333f4cb606a7a1e32603cd032f369533767e919d07cbc0a3684dd842949660401f623a1d39a8b395ce9")]

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("Wintellect.PowerCollections")]
[assembly: AssemblyDescription("The Power Collections group of collection classes.")]
#if DEBUG
[assembly: AssemblyConfiguration("DEBUG")]
#else
[assembly: AssemblyConfiguration("")]
#endif
[assembly: AssemblyCompany("Wintellect")]
[assembly: AssemblyProduct("Power Collections")]
[assembly: AssemblyCopyright("Copyright (c) 2004-2007, Wintellect")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("1.0.*")]

