﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

using Mosa.Platform.Internal.x86;

namespace Mosa.Kernel.x86
{
	/// <summary>
	/// A physical page allocator.
	/// </summary>
	public static class PageFrameAllocator
	{
		// Location for memory map starts at 28MB
		private const uint StartLocation = 1024 * 1024 * 28;

		// Reserve memory up to 32MB
		public const uint ReserveMemory = 1024 * 1024 * 32;

		// Maximum memory usage (4GB)
		public const uint MaximumMemory = 0xFFFFFFFF;

		// Start of memory map
		private static uint map;

		// Current position in map data structure
		private static uint at;

		private static uint totalPages;
		private static uint totalUsedPages;

		/// <summary>
		/// Setup the physical page manager
		/// </summary>
		public static void Setup()
		{
			map = StartLocation;
			at = StartLocation;
			totalPages = 0;
			totalUsedPages = 0;
			SetupFreeMemory();
		}

		/// <summary>
		/// Setups the free memory.
		/// </summary>
		private static void SetupFreeMemory()
		{
			if (!Multiboot.IsMultibootEnabled)
				return;

			uint cnt = 0;
			for (uint index = 0; index < Multiboot.MemoryMapCount; index++)
			{
				byte value = Multiboot.GetMemoryMapType(index);

				ulong start = Multiboot.GetMemoryMapBase(index);
				ulong size = Multiboot.GetMemoryMapLength(index);

				if (value == 1)
					AddFreeMemory(cnt++, (uint)start, (uint)size);
			}
		}

		/// <summary>
		/// Adds the free memory.
		/// </summary>
		/// <param name="cnt">The count.</param>
		/// <param name="start">The start.</param>
		/// <param name="size">The size.</param>
		private static void AddFreeMemory(uint cnt, uint start, uint size)
		{
			if ((start > MaximumMemory) || (start + size < ReserveMemory))
				return;

			// Normalize
			uint normstart = (uint)((start + PageSize - 1) & ~(PageSize - 1));
			uint normend = (uint)((start + size) & ~(PageSize - 1));
			uint normsize = (uint)(normend - normstart);

			// Adjust if memory below is reserved
			if (normstart < ReserveMemory)
			{
				normsize = (normstart + normsize) - ReserveMemory;
				normstart = ReserveMemory;

				if (normsize <= 0)
					return;
			}

			// Populate free table
			for (uint mem = normstart; mem < normstart + normsize; mem = mem + PageSize, at = at + 4)
				Native.Set32(at, mem);

			at = at - 4;
			totalPages = totalPages + (normsize / PageSize);
		}

		/// <summary>
		/// Allocate a physical page from the free list
		/// </summary>
		/// <returns>The page</returns>
		public static uint Allocate()
		{
			if (at == map) return 0; // out of memory

			totalUsedPages++;
			uint avail = Native.Get32(at);
			at = at - sizeof(uint);

			// Clear out memory
			Memory.Clear(avail, PageSize);

			return avail;
		}

		/// <summary>
		/// Releases a page to the free list
		/// </summary>
		/// <param name="address">The address.</param>
		public static void Free(uint address)
		{
			totalUsedPages--;
			at = at + sizeof(uint);
			Native.Set32(at, address);
		}

		/// <summary>
		/// Retrieves the size of a single memory page.
		/// </summary>
		public static uint PageSize { get { return 4096; } }

		/// <summary>
		/// Retrieves the amount of total physical memory pages available in the system.
		/// </summary>
		public static uint TotalPages { get { return totalPages; } }

		/// <summary>
		/// Retrieves the amount of number of physical pages in use.
		/// </summary>
		public static uint TotalPagesInUse { get { return totalUsedPages; } }
	}
}