//
// Copyright 2004 Pete Barber, All Rights Reserved
//
using System.Runtime.InteropServices;

namespace nfsV2
{
	/// <summary>
	/// Summary description for UnmanagedWin32API.
	/// </summary>
	public class UnmanagedWin32API
	{
		[DllImport("Kernel32.dll")]				
		public static extern bool GetDiskFreeSpaceEx(
			string directoryName, 
			ref System.UInt64 freeBytesAvailable,
			ref System.UInt64 totalNumberOfBytes,
			ref System.UInt64 totalNumberOfFreeBytes);

		[DllImport("Kernal32.dll")]
		public static extern bool GetVolumeInformation(
			string rootPathName,
			ref string volumeNameBuffer, ref uint volumeNameSize,
			ref uint volumeSerialNumber,
			ref uint maximumComponentLength,
			ref uint fileSystemFlags,
			ref string fileSystemNameBuffer,
			ref uint fileSysteNameSize);
	}
}
