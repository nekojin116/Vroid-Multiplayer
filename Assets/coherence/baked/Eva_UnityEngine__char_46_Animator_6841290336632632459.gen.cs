// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct Eva_UnityEngine__char_46_Animator_6841290336632632459 : ICoherenceComponentData
	{
		public bool Jump;
		public bool Grounded;
		public bool FreeFall;
		public float Speed;
		public float MotionSpeed;

		public override string ToString()
		{
			return $"Eva_UnityEngine__char_46_Animator_6841290336632632459(Jump: {Jump}, Grounded: {Grounded}, FreeFall: {FreeFall}, Speed: {Speed}, MotionSpeed: {MotionSpeed})";
		}

		public uint GetComponentType() => Definition.InternalEva_UnityEngine__char_46_Animator_6841290336632632459;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;
	

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (Eva_UnityEngine__char_46_Animator_6841290336632632459)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				Jump = other.Jump;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				Grounded = other.Grounded;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				FreeFall = other.FreeFall;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				Speed = other.Speed;
			}
			mask >>= 1;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				MotionSpeed = other.MotionSpeed;
			}
			mask >>= 1;
			return this;
		}

		public uint DiffWith(ICoherenceComponentData data)
		{
			throw new System.NotSupportedException($"{nameof(DiffWith)} is not supported in Unity");

		}

		public static void Serialize(Eva_UnityEngine__char_46_Animator_6841290336632632459 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.Jump);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.Grounded);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteBool(data.FreeFall);
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteFloat(data.Speed, FloatMeta.NoCompression());
			}
			mask >>= 1;
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteFloat(data.MotionSpeed, FloatMeta.NoCompression());
			}
			mask >>= 1;
		}

		public static (Eva_UnityEngine__char_46_Animator_6841290336632632459, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Eva_UnityEngine__char_46_Animator_6841290336632632459();
	
			if (bitStream.ReadMask())
			{
				val.Jump = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.Grounded = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.FreeFall = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000100;
			}
			if (bitStream.ReadMask())
			{
				val.Speed = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000001000;
			}
			if (bitStream.ReadMask())
			{
				val.MotionSpeed = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000010000;
			}
			return (val, mask, null);
		}
		public static (Eva_UnityEngine__char_46_Animator_6841290336632632459, uint, uint?) DeserializeArchetypeEva_a4015406731486f4694c40c0ee0848a3_Eva_UnityEngine__char_46_Animator_6841290336632632459_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new Eva_UnityEngine__char_46_Animator_6841290336632632459();
			if (bitStream.ReadMask())
			{
				val.Jump = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000001;
			}
			if (bitStream.ReadMask())
			{
				val.Grounded = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000010;
			}
			if (bitStream.ReadMask())
			{
				val.FreeFall = bitStream.ReadBool();
				mask |= 0b00000000000000000000000000000100;
			}
			if (bitStream.ReadMask())
			{
				val.Speed = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000001000;
			}
			if (bitStream.ReadMask())
			{
				val.MotionSpeed = bitStream.ReadFloat(FloatMeta.NoCompression());
				mask |= 0b00000000000000000000000000010000;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as Eva_UnityEngine__char_46_Animator_6841290336632632459?;
	
		}
	}
}