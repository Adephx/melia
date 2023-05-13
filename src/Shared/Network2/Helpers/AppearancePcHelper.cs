﻿using System;
using Melia.Shared.Tos.Const;

namespace Melia.Shared.Network2.Helpers
{
	/// <summary>
	/// Contains extension methods to write data about a characters'
	/// appearances to packets.
	/// </summary>
	public static class AppearancePcHelper
	{
		/// <summary>
		/// Writes data about the character's appearance to the packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="appearancePc"></param>
		/// <exception cref="InvalidOperationException"></exception>
		public static void AddAppearancePc(this Packet packet, IAppearancePc appearancePc)
		{
			packet.PutString(appearancePc.Name, 65);
			packet.PutString(appearancePc.TeamName, 65);
			packet.PutEmptyBin(6);
			packet.PutLong(appearancePc.AccountId);
			packet.PutInt(appearancePc.Stance);
			packet.PutShort((short)appearancePc.JobId);
			packet.PutByte((byte)appearancePc.Gender);
			packet.PutByte(0);
			packet.PutInt(appearancePc.Level);
			packet.PutInt(1022); // i1
			packet.PutByte(0x80); //128
			packet.PutByte(0x80); //128
			packet.PutByte(0x80); //128
			packet.PutByte(0xFF); //255
			packet.PutInt(0); // i2 1 or 0

			// Items
			var equipIds = appearancePc.GetEquipIds();
			if (equipIds.Length != Items.EquipSlotCount)
				throw new InvalidOperationException("Incorrect amount of equipment (" + equipIds.Length + ").");

			for (var i = 0; i < equipIds.Length; ++i)
				packet.PutInt(equipIds[i]);

			// [i10671, 2015-10-26 iCBT2] ?
			{
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
			}

			// Visual Equip Ids?
			for (var i = 0; i < Items.DefaultItems.Length; ++i)
				packet.PutInt(Items.DefaultItems[i]);

			// [i336041, 2021-07-25]
			{
				packet.PutInt(0);
				packet.PutInt(0);
				packet.PutInt(0);
			}

			packet.PutShort(appearancePc.Hair);

			// Up until i171032 we had these as "pose" and "team id",
			// but they actually contain the visible hats, so we either
			// had them wrong, or they changed. This was first noticed in
			// i170175.
			{
				//packet.PutShort(0); // Pose
				//packet.PutInt(0); // Team ID

				packet.PutByte(0);
				packet.PutByte((appearancePc.VisibleHats & HatVisibleStates.Hat1) != 0);
				packet.PutByte((appearancePc.VisibleHats & HatVisibleStates.Hat2) != 0);
				packet.PutByte((appearancePc.VisibleHats & HatVisibleStates.Hat3) != 0);
				packet.PutByte(0);
				packet.PutByte(1);
			}

			packet.PutEmptyBin(8); // [i373230 (2023-05-10)] Might've been added before
		}
	}

	/// <summary>
	/// Describes a character a with an appearance.
	/// </summary>
	public interface IAppearancePc
	{
		/// <summary>
		/// Returns the character's account id.
		/// </summary>
		long AccountId { get; }

		/// <summary>
		/// Returns the character's name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Returns the character's team name.
		/// </summary>
		string TeamName { get; }

		/// <summary>
		/// Returns the character's stance.
		/// </summary>
		int Stance { get; }

		/// <summary>
		/// Returns the character's main job id.
		/// </summary>
		JobId JobId { get; }

		/// <summary>
		/// Returns the character's gender.
		/// </summary>
		Gender Gender { get; }

		/// <summary>
		/// Returns the character's current level.
		/// </summary>
		int Level { get; }

		/// <summary>
		/// Returns the character's hair id.
		/// </summary>
		int Hair { get; }

		/// <summary>
		/// Returns whether to display the character's hats.
		/// </summary>
		HatVisibleStates VisibleHats { get; }

		/// <summary>
		/// Returns the ids of the character's equipment.
		/// </summary>
		/// <returns></returns>
		int[] GetEquipIds();
	}
}