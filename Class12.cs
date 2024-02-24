using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal class Class12
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct4
	{
		[FieldOffset(0)]
		public byte byte_0;

		[FieldOffset(0)]
		public sbyte sbyte_0;

		[FieldOffset(0)]
		public ushort ushort_0;

		[FieldOffset(0)]
		public short short_0;

		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(0)]
		public int int_0;
	}

	internal abstract class Class13
	{
		internal Enum3 enum3_0;

		public Class13()
		{
		}

		internal bool method_0()
		{
			return enum3_0 == (Enum3)0;
		}

		internal bool method_1()
		{
			return enum3_0 == (Enum3)1;
		}

		internal bool method_2()
		{
			if (enum3_0 != (Enum3)3)
			{
				return enum3_0 == (Enum3)4;
			}
			return true;
		}

		internal bool method_3()
		{
			return enum3_0 == (Enum3)2;
		}

		internal bool method_4()
		{
			return enum3_0 == (Enum3)5;
		}

		internal bool method_5()
		{
			return enum3_0 == (Enum3)6;
		}

		internal virtual bool vmethod_0()
		{
			return false;
		}

		internal virtual bool vmethod_1()
		{
			return false;
		}

		internal abstract void vmethod_2(Class13 class13_0);

		internal virtual bool vmethod_3()
		{
			return false;
		}

		internal Class13(Enum3 enum3_1)
		{
			enum3_0 = enum3_1;
		}

		internal abstract object vmethod_4(Type type_0);

		internal abstract bool vmethod_5(Class13 class13_0);

		internal abstract bool vmethod_6(Class13 class13_0);

		internal abstract bool vmethod_7();

		internal abstract Class13 vmethod_8();

		internal virtual bool vmethod_9()
		{
			return false;
		}

		internal abstract void vmethod_10(Class13 class13_0);

		internal static Enum1 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Enum1)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (!(type == typeof(string)))
			{
				if (type == typeof(byte))
				{
					return (Enum1)2;
				}
				if (type == typeof(sbyte))
				{
					return (Enum1)1;
				}
				if (type == typeof(short))
				{
					return (Enum1)3;
				}
				if (type == typeof(ushort))
				{
					return (Enum1)4;
				}
				if (type == typeof(int))
				{
					return (Enum1)5;
				}
				if (type == typeof(uint))
				{
					return (Enum1)6;
				}
				if (!(type == typeof(long)))
				{
					if (type == typeof(ulong))
					{
						return (Enum1)8;
					}
					if (type == typeof(float))
					{
						return (Enum1)9;
					}
					if (!(type == typeof(double)))
					{
						if (!(type == typeof(bool)))
						{
							if (type == typeof(IntPtr))
							{
								return (Enum1)12;
							}
							if (type == typeof(UIntPtr))
							{
								return (Enum1)13;
							}
							if (!(type == typeof(char)))
							{
								if (!(type == typeof(object)))
								{
									if (!type.IsEnum)
									{
										return (Enum1)17;
									}
									return (Enum1)16;
								}
								return (Enum1)0;
							}
							return (Enum1)15;
						}
						return (Enum1)11;
					}
					return (Enum1)10;
				}
				return (Enum1)7;
			}
			return (Enum1)14;
		}

		internal static Class13 smethod_1(Type type_0, object object_0)
		{
			Enum1 @enum = smethod_0(type_0);
			Enum1 enum2 = (Enum1)18;
			if (object_0 != null)
			{
				enum2 = smethod_0(object_0.GetType());
			}
			Class13 @class = null;
			switch (@enum)
			{
			case (Enum1)0:
			{
				Enum1 enum7 = enum2;
				@class = ((enum7 != (Enum1)15) ? smethod_2(object_0) : new Class25(object_0));
				goto default;
			}
			case (Enum1)1:
				@class = enum2 switch
				{
					(Enum1)15 => new Class15((sbyte)(char)object_0, (Enum0)1), 
					(Enum1)11 => ((bool)object_0) ? new Class15(1, (Enum0)1) : new Class15(0, (Enum0)1), 
					(Enum1)1 => new Class15((sbyte)object_0, (Enum0)1), 
					(Enum1)2 => new Class15((sbyte)(byte)object_0, (Enum0)1), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)2:
				@class = enum2 switch
				{
					(Enum1)15 => new Class15((byte)(char)object_0, (Enum0)2), 
					(Enum1)11 => ((bool)object_0) ? new Class15(1, (Enum0)2) : new Class15(0, (Enum0)2), 
					(Enum1)1 => new Class15((byte)(sbyte)object_0, (Enum0)2), 
					(Enum1)2 => new Class15((byte)object_0, (Enum0)2), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)3:
				@class = enum2 switch
				{
					(Enum1)15 => new Class15((short)(char)object_0, (Enum0)3), 
					(Enum1)11 => (!(bool)object_0) ? new Class15(0, (Enum0)3) : new Class15(1, (Enum0)3), 
					(Enum1)3 => new Class15((short)object_0, (Enum0)3), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)4:
				@class = enum2 switch
				{
					(Enum1)15 => new Class15((char)object_0, (Enum0)4), 
					(Enum1)11 => (!(bool)object_0) ? new Class15(0, (Enum0)4) : new Class15(1, (Enum0)4), 
					(Enum1)4 => new Class15((ushort)object_0, (Enum0)4), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)5:
				@class = enum2 switch
				{
					(Enum1)15 => new Class15((char)object_0, (Enum0)5), 
					(Enum1)11 => ((bool)object_0) ? new Class15(1, (Enum0)5) : new Class15(0, (Enum0)5), 
					(Enum1)5 => new Class15((int)object_0, (Enum0)5), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)6:
				@class = enum2 switch
				{
					(Enum1)15 => new Class15((uint)(char)object_0, (Enum0)6), 
					(Enum1)11 => ((bool)object_0) ? new Class15(1u, (Enum0)6) : new Class15(0u, (Enum0)6), 
					(Enum1)6 => new Class15((uint)object_0, (Enum0)6), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)7:
				@class = enum2 switch
				{
					(Enum1)15 => new Class16((char)object_0, (Enum0)7), 
					(Enum1)11 => (!(bool)object_0) ? new Class16(0L, (Enum0)7) : new Class16(1L, (Enum0)7), 
					(Enum1)7 => new Class16((long)object_0, (Enum0)7), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)8:
				@class = enum2 switch
				{
					(Enum1)15 => new Class16((ulong)(char)object_0, (Enum0)8), 
					(Enum1)11 => (!(bool)object_0) ? new Class16(0uL, (Enum0)8) : new Class16(1uL, (Enum0)8), 
					(Enum1)8 => new Class16((ulong)object_0, (Enum0)8), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)9:
			{
				Enum1 enum6 = enum2;
				if (enum6 == (Enum1)9)
				{
					@class = new Class18((float)object_0);
					goto default;
				}
				throw new InvalidCastException();
			}
			case (Enum1)10:
			{
				Enum1 enum5 = enum2;
				if (enum5 == (Enum1)10)
				{
					@class = new Class18((double)object_0);
					goto default;
				}
				throw new InvalidCastException();
			}
			case (Enum1)11:
				switch (enum2)
				{
				case (Enum1)1:
					@class = new Class15((sbyte)object_0 != 0);
					break;
				case (Enum1)2:
					@class = new Class15((byte)object_0 != 0);
					break;
				case (Enum1)3:
					@class = new Class15((short)object_0 != 0);
					break;
				case (Enum1)4:
					@class = new Class15((ushort)object_0 != 0);
					break;
				case (Enum1)5:
					@class = new Class15((int)object_0 != 0);
					break;
				case (Enum1)6:
					@class = new Class15((uint)object_0 != 0);
					break;
				case (Enum1)7:
					@class = new Class15((long)object_0 != 0L);
					break;
				case (Enum1)8:
					@class = new Class15((ulong)object_0 != 0L);
					break;
				case (Enum1)11:
					@class = new Class15((bool)object_0);
					break;
				case (Enum1)9:
				case (Enum1)10:
				case (Enum1)12:
				case (Enum1)13:
				case (Enum1)14:
				case (Enum1)15:
				case (Enum1)16:
					throw new InvalidCastException();
				default:
					@class = new Class15(object_0 != null);
					break;
				case (Enum1)18:
					@class = new Class15(bool_0: false);
					break;
				}
				goto default;
			case (Enum1)12:
			{
				Enum1 enum4 = enum2;
				if (enum4 == (Enum1)12)
				{
					@class = new Class17((IntPtr)object_0);
					goto default;
				}
				throw new InvalidCastException();
			}
			case (Enum1)13:
			{
				Enum1 enum3 = enum2;
				if (enum3 == (Enum1)13)
				{
					@class = new Class17((UIntPtr)object_0);
					goto default;
				}
				throw new InvalidCastException();
			}
			case (Enum1)14:
				@class = new Class26(object_0 as string);
				goto default;
			case (Enum1)15:
				@class = enum2 switch
				{
					(Enum1)15 => new Class15((char)object_0, (Enum0)15), 
					(Enum1)1 => new Class15((sbyte)object_0, (Enum0)15), 
					(Enum1)2 => new Class15((byte)object_0, (Enum0)15), 
					(Enum1)3 => new Class15((short)object_0, (Enum0)15), 
					(Enum1)4 => new Class15((ushort)object_0, (Enum0)15), 
					(Enum1)5 => new Class15((int)object_0, (Enum0)15), 
					(Enum1)6 => new Class15((int)(uint)object_0, (Enum0)15), 
					_ => throw new InvalidCastException(), 
				};
				goto default;
			case (Enum1)16:
			case (Enum1)17:
				@class = smethod_2(object_0);
				goto default;
			default:
				if (type_0.IsByRef)
				{
					@class = new Class24(@class, type_0.GetElementType());
				}
				return @class;
			case (Enum1)18:
				throw new InvalidCastException();
			}
		}

		public static Class13 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object object_ = Convert.ChangeType(object_0, underlyingType);
				Class13 @class = smethod_3(smethod_1(underlyingType, object_));
				if (@class != null)
				{
					return @class as Class14;
				}
			}
			return new Class25(object_0);
		}

		public static Class14 smethod_3(Class13 class13_0)
		{
			Class14 @class = class13_0 as Class14;
			if (@class == null && class13_0.vmethod_0())
			{
				@class = class13_0.vmethod_8() as Class14;
			}
			return @class;
		}
	}

	public abstract class Class14 : Class13
	{
		public abstract bool ucFrayBeGvG();

		public abstract bool vmethod_11();

		public abstract Class13 vmethod_12(Enum0 enum0_0);

		public abstract Class15 zrQrasfExAV();

		public abstract Class15 vmethod_13();

		public abstract Class15 vmethod_14();

		public abstract Class15 vmethod_15();

		public abstract Class15 vmethod_16();

		public abstract Class15 vmethod_17();

		public abstract Class15 vmethod_18();

		public abstract Class16 vmethod_19();

		public abstract Class16 vmethod_20();

		public abstract Class15 rIoranxyrKy();

		public abstract Class15 vmethod_21();

		public abstract Class15 vmethod_22();

		public abstract Class16 vmethod_23();

		public abstract Class15 vmethod_24();

		public abstract Class15 vmethod_25();

		public abstract Class15 vmethod_26();

		public abstract Class16 vmethod_27();

		public abstract Class15 vmethod_28();

		public abstract Class15 vmethod_29();

		public abstract Class15 vmethod_30();

		public abstract Class15 vmethod_31();

		public abstract Class15 vmethod_32();

		public abstract Class15 vmethod_33();

		public abstract Class16 vmethod_34();

		public abstract Class16 vmethod_35();

		public abstract Class15 vmethod_36();

		public abstract Class15 vmethod_37();

		public abstract Class15 vmethod_38();

		public abstract Class15 vmethod_39();

		public abstract Class15 vmethod_40();

		public abstract Class15 vmethod_41();

		public abstract Class16 vmethod_42();

		public abstract Class16 vmethod_43();

		public abstract Class18 vmethod_44();

		public abstract Class18 vmethod_45();

		public abstract Class18 vmethod_46();

		public abstract Class17 vmethod_47();

		public abstract Class17 vmethod_48();

		public abstract Class17 vmethod_49();

		public abstract Class17 vmethod_50();

		public abstract Class17 vmethod_51();

		public abstract Class17 vmethod_52();

		public abstract Class13 vmethod_53();

		public abstract Class13 Add(Class13 class13_0);

		public abstract Class13 vmethod_54(Class13 class13_0);

		public abstract Class13 vmethod_55(Class13 class13_0);

		public abstract Class13 vmethod_56(Class13 class13_0);

		public abstract Class13 vmethod_57(Class13 class13_0);

		public abstract Class13 vmethod_58(Class13 class13_0);

		public abstract Class13 vmethod_59(Class13 class13_0);

		public abstract Class13 vmethod_60(Class13 class13_0);

		public abstract Class13 vmethod_61(Class13 class13_0);

		public abstract Class13 vmethod_62(Class13 class13_0);

		public abstract Class13 vmethod_63(Class13 class13_0);

		public abstract Class13 vPxrkrTinu9(Class13 class13_0);

		public abstract Class13 vmethod_64(Class13 class13_0);

		public abstract Class13 vmethod_65(Class13 class13_0);

		public abstract Class13 vmethod_66(Class13 class13_0);

		public abstract Class13 vmethod_67();

		public abstract Class13 vmethod_68(Class13 class13_0);

		public abstract Class14 vmethod_69();

		public abstract Class13 vmethod_70(Class13 class13_0);

		public abstract Class13 vmethod_71(Class13 class13_0);

		public abstract Class13 vmethod_72(Class13 class13_0);

		public abstract bool vmethod_73(Class13 class13_0);

		public abstract bool vmethod_74(Class13 class13_0);

		public abstract bool vmethod_75(Class13 class13_0);

		public abstract bool vmethod_76(Class13 class13_0);

		public abstract bool vmethod_77(Class13 class13_0);

		public abstract bool vmethod_78(Class13 class13_0);

		public abstract bool vmethod_79(Class13 class13_0);

		public abstract bool vmethod_80(Class13 class13_0);

		internal override bool vmethod_3()
		{
			return true;
		}
	}

	public class Class15 : Class14
	{
		public Struct4 struct4_0;

		public Enum0 enum0_0;

		internal override void vmethod_10(Class13 class13_0)
		{
			struct4_0 = ((Class15)class13_0).struct4_0;
			enum0_0 = ((Class15)class13_0).enum0_0;
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_10(class13_0);
		}

		public Class15(bool bool_0)
		{
			enum3_0 = (Enum3)1;
			if (bool_0)
			{
				struct4_0.int_0 = 1;
			}
			else
			{
				struct4_0.int_0 = 0;
			}
			enum0_0 = (Enum0)11;
		}

		public Class15(Class15 class15_0)
		{
			enum3_0 = class15_0.enum3_0;
			struct4_0.int_0 = class15_0.struct4_0.int_0;
			enum0_0 = class15_0.enum0_0;
		}

		public override Class14 vmethod_69()
		{
			return new Class15(this);
		}

		public Class15(int int_0)
		{
			enum3_0 = (Enum3)1;
			struct4_0.int_0 = int_0;
			enum0_0 = (Enum0)5;
		}

		public Class15(uint uint_0)
		{
			enum3_0 = (Enum3)1;
			struct4_0.uint_0 = uint_0;
			enum0_0 = (Enum0)6;
		}

		public Class15(int int_0, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)1;
			struct4_0.int_0 = int_0;
			enum0_0 = enum0_1;
		}

		public Class15(uint uint_0, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)1;
			struct4_0.uint_0 = uint_0;
			enum0_0 = enum0_1;
		}

		public override bool ucFrayBeGvG()
		{
			switch (enum0_0)
			{
			default:
				return struct4_0.uint_0 == 0;
			case (Enum0)1:
			case (Enum0)3:
			case (Enum0)5:
			case (Enum0)7:
			case (Enum0)11:
			case (Enum0)15:
				return struct4_0.int_0 == 0;
			}
		}

		public override bool vmethod_11()
		{
			return !ucFrayBeGvG();
		}

		public override Class13 vmethod_12(Enum0 enum0_1)
		{
			return enum0_1 switch
			{
				(Enum0)1 => vmethod_13(), 
				(Enum0)2 => vmethod_14(), 
				(Enum0)3 => vmethod_15(), 
				(Enum0)4 => vmethod_16(), 
				(Enum0)5 => vmethod_17(), 
				(Enum0)6 => vmethod_18(), 
				(Enum0)11 => zrQrasfExAV(), 
				(Enum0)15 => method_7(), 
				(Enum0)16 => vmethod_69(), 
				_ => throw new Exception(Enum4.TruncationNotSupported.ToString()), 
			};
		}

		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (!(type_0 == null) && !(type_0 == typeof(object)))
			{
				if (!(type_0 == typeof(int)))
				{
					if (!(type_0 == typeof(uint)))
					{
						if (!(type_0 == typeof(short)))
						{
							if (type_0 == typeof(ushort))
							{
								return struct4_0.ushort_0;
							}
							if (!(type_0 == typeof(byte)))
							{
								if (!(type_0 == typeof(sbyte)))
								{
									if (type_0 == typeof(bool))
									{
										return !ucFrayBeGvG();
									}
									if (!(type_0 == typeof(long)))
									{
										if (!(type_0 == typeof(ulong)))
										{
											if (!(type_0 == typeof(char)))
											{
												if (!(type_0 == typeof(IntPtr)))
												{
													if (type_0 == typeof(UIntPtr))
													{
														return new UIntPtr(struct4_0.uint_0);
													}
													if (!type_0.IsEnum)
													{
														throw new Exception1();
													}
													return method_6(type_0);
												}
												return new IntPtr(struct4_0.int_0);
											}
											return (char)struct4_0.int_0;
										}
										return (ulong)struct4_0.uint_0;
									}
									return (long)struct4_0.int_0;
								}
								return struct4_0.sbyte_0;
							}
							return struct4_0.byte_0;
						}
						return struct4_0.short_0;
					}
					return struct4_0.uint_0;
				}
				return struct4_0.int_0;
			}
			return enum0_0 switch
			{
				(Enum0)1 => struct4_0.sbyte_0, 
				(Enum0)2 => struct4_0.byte_0, 
				(Enum0)3 => struct4_0.short_0, 
				(Enum0)4 => struct4_0.ushort_0, 
				(Enum0)5 => struct4_0.int_0, 
				(Enum0)6 => struct4_0.uint_0, 
				(Enum0)7 => (long)struct4_0.int_0, 
				(Enum0)8 => (ulong)struct4_0.uint_0, 
				(Enum0)11 => vmethod_11(), 
				(Enum0)15 => (char)struct4_0.int_0, 
				_ => struct4_0.int_0, 
			};
		}

		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (!(underlyingType == typeof(int)))
			{
				if (underlyingType == typeof(uint))
				{
					return Enum.ToObject(type_0, struct4_0.uint_0);
				}
				if (underlyingType == typeof(short))
				{
					return Enum.ToObject(type_0, struct4_0.short_0);
				}
				if (!(underlyingType == typeof(ushort)))
				{
					if (!(underlyingType == typeof(byte)))
					{
						if (!(underlyingType == typeof(sbyte)))
						{
							if (!(underlyingType == typeof(long)))
							{
								if (!(underlyingType == typeof(ulong)))
								{
									if (underlyingType == typeof(char))
									{
										return Enum.ToObject(type_0, (ushort)struct4_0.int_0);
									}
									return Enum.ToObject(type_0, struct4_0.int_0);
								}
								return Enum.ToObject(type_0, (ulong)struct4_0.uint_0);
							}
							return Enum.ToObject(type_0, (long)struct4_0.int_0);
						}
						return Enum.ToObject(type_0, struct4_0.sbyte_0);
					}
					return Enum.ToObject(type_0, struct4_0.byte_0);
				}
				return Enum.ToObject(type_0, struct4_0.ushort_0);
			}
			return Enum.ToObject(type_0, struct4_0.int_0);
		}

		public override Class15 zrQrasfExAV()
		{
			return new Class15((!ucFrayBeGvG()) ? 1 : 0);
		}

		internal override bool vmethod_7()
		{
			return vmethod_11();
		}

		public override Class15 vmethod_13()
		{
			return new Class15(struct4_0.sbyte_0, (Enum0)1);
		}

		public Class15 method_7()
		{
			return new Class15(struct4_0.int_0, (Enum0)15);
		}

		public override Class15 vmethod_14()
		{
			return new Class15((uint)struct4_0.byte_0, (Enum0)2);
		}

		public override Class15 vmethod_15()
		{
			return new Class15(struct4_0.short_0, (Enum0)3);
		}

		public override Class15 vmethod_16()
		{
			return new Class15((uint)struct4_0.ushort_0, (Enum0)4);
		}

		public override Class15 vmethod_17()
		{
			return new Class15(struct4_0.int_0, (Enum0)5);
		}

		public override Class15 vmethod_18()
		{
			return new Class15(struct4_0.uint_0, (Enum0)6);
		}

		public override Class16 vmethod_19()
		{
			return new Class16(struct4_0.int_0, (Enum0)7);
		}

		public override Class16 vmethod_20()
		{
			return new Class16((ulong)struct4_0.uint_0, (Enum0)8);
		}

		public override Class15 rIoranxyrKy()
		{
			return vmethod_13();
		}

		public override Class15 vmethod_21()
		{
			return vmethod_15();
		}

		public override Class15 vmethod_22()
		{
			return vmethod_17();
		}

		public override Class16 vmethod_23()
		{
			return vmethod_19();
		}

		public override Class15 vmethod_24()
		{
			return vmethod_14();
		}

		public override Class15 vmethod_25()
		{
			return vmethod_16();
		}

		public override Class15 vmethod_26()
		{
			return vmethod_18();
		}

		public override Class16 vmethod_27()
		{
			return vmethod_20();
		}

		public override Class15 vmethod_28()
		{
			return new Class15(checked((sbyte)struct4_0.int_0), (Enum0)1);
		}

		public override Class15 vmethod_29()
		{
			return new Class15(checked((sbyte)struct4_0.uint_0), (Enum0)1);
		}

		public override Class15 vmethod_30()
		{
			return new Class15(checked((short)struct4_0.int_0), (Enum0)3);
		}

		public override Class15 vmethod_31()
		{
			return new Class15(checked((short)struct4_0.uint_0), (Enum0)3);
		}

		public override Class15 vmethod_32()
		{
			return new Class15(struct4_0.int_0, (Enum0)5);
		}

		public override Class15 vmethod_33()
		{
			return new Class15(checked((int)struct4_0.uint_0), (Enum0)5);
		}

		public override Class16 vmethod_34()
		{
			return new Class16(struct4_0.int_0, (Enum0)7);
		}

		public override Class16 vmethod_35()
		{
			return new Class16(struct4_0.uint_0, (Enum0)7);
		}

		public override Class15 vmethod_36()
		{
			return new Class15(checked((byte)struct4_0.int_0), (Enum0)2);
		}

		public override Class15 vmethod_37()
		{
			return new Class15(checked((byte)struct4_0.uint_0), (Enum0)2);
		}

		public override Class15 vmethod_38()
		{
			return new Class15(checked((ushort)struct4_0.int_0), (Enum0)4);
		}

		public override Class15 vmethod_39()
		{
			return new Class15(checked((ushort)struct4_0.uint_0), (Enum0)4);
		}

		public override Class15 vmethod_40()
		{
			return new Class15(checked((uint)struct4_0.int_0), (Enum0)6);
		}

		public override Class15 vmethod_41()
		{
			return new Class15(struct4_0.uint_0, (Enum0)6);
		}

		public override Class16 vmethod_42()
		{
			return new Class16(checked((ulong)struct4_0.int_0), (Enum0)8);
		}

		public override Class16 vmethod_43()
		{
			return new Class16((ulong)struct4_0.uint_0, (Enum0)8);
		}

		public override Class18 vmethod_44()
		{
			return new Class18(struct4_0.int_0);
		}

		public override Class18 vmethod_45()
		{
			return new Class18((double)struct4_0.int_0);
		}

		public override Class18 vmethod_46()
		{
			return new Class18((double)struct4_0.uint_0);
		}

		public override Class17 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_23().struct5_0.long_0);
			}
			return new Class17(vmethod_22().struct4_0.int_0);
		}

		public override Class17 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_27().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_26().struct4_0.uint_0);
		}

		public override Class17 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_34().struct5_0.long_0);
			}
			return new Class17(vmethod_32().struct4_0.int_0);
		}

		public override Class17 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_42().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_40().struct4_0.uint_0);
		}

		public override Class17 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_35().struct5_0.long_0);
			}
			return new Class17(vmethod_33().struct4_0.int_0);
		}

		public override Class17 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_43().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_41().struct4_0.uint_0);
		}

		public override Class13 vmethod_53()
		{
			switch (enum0_0)
			{
			default:
				return new Class15((int)(0L - (long)struct4_0.uint_0));
			case (Enum0)1:
			case (Enum0)3:
			case (Enum0)5:
			case (Enum0)11:
			case (Enum0)15:
				return new Class15(-struct4_0.int_0);
			}
		}

		public override Class13 Add(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).Add(this);
				}
				throw new Exception1();
			}
			return new Class15(struct4_0.int_0 + ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_54(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(checked(struct4_0.int_0 + ((Class15)class13_0).struct4_0.int_0));
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_54(this);
		}

		public override Class13 vmethod_55(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(checked(struct4_0.uint_0 + ((Class15)class13_0).struct4_0.uint_0));
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_55(this);
		}

		public override Class13 vmethod_56(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).method_8(this);
				}
				throw new Exception1();
			}
			return new Class15(struct4_0.int_0 - ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_57(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				return ((Class17)class13_0).method_9(this);
			}
			return new Class15(checked(struct4_0.int_0 - ((Class15)class13_0).struct4_0.int_0));
		}

		public override Class13 vmethod_58(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(checked(struct4_0.uint_0 - ((Class15)class13_0).struct4_0.uint_0));
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).method_10(this);
		}

		public override Class13 vmethod_59(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).vmethod_59(this);
				}
				throw new Exception1();
			}
			return new Class15(struct4_0.int_0 * ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_60(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(checked(struct4_0.int_0 * ((Class15)class13_0).struct4_0.int_0));
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_60(this);
		}

		public override Class13 vmethod_61(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).vmethod_61(this);
				}
				throw new Exception1();
			}
			return new Class15(checked(struct4_0.uint_0 * ((Class15)class13_0).struct4_0.uint_0));
		}

		public override Class13 vmethod_62(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(struct4_0.int_0 / ((Class15)class13_0).struct4_0.int_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).method_11(this);
		}

		public override Class13 vmethod_63(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(struct4_0.uint_0 / ((Class15)class13_0).struct4_0.uint_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).method_12(this);
		}

		public override Class13 vPxrkrTinu9(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				return ((Class17)class13_0).method_13(this);
			}
			return new Class15(struct4_0.int_0 % ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_64(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).hDdjuohhOr(this);
				}
				throw new Exception1();
			}
			return new Class15(struct4_0.uint_0 % ((Class15)class13_0).struct4_0.uint_0);
		}

		public override Class13 vmethod_65(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(struct4_0.int_0 & ((Class15)class13_0).struct4_0.int_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_65(this);
		}

		public override Class13 vmethod_66(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).vmethod_66(this);
				}
				throw new Exception1();
			}
			return new Class15(struct4_0.int_0 | ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_67()
		{
			return new Class15(~struct4_0.int_0);
		}

		public override Class13 vmethod_68(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).vmethod_68(this);
				}
				throw new Exception1();
			}
			return new Class15(struct4_0.int_0 ^ ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_70(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(struct4_0.int_0 << ((Class15)class13_0).struct4_0.int_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).method_16(this);
		}

		public override Class13 vmethod_71(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				return ((Class17)class13_0).method_15(this);
			}
			return new Class15(struct4_0.int_0 >> ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_72(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return new Class15(struct4_0.uint_0 >> ((Class15)class13_0).struct4_0.int_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).method_14(this);
		}

		public override string ToString()
		{
			switch (enum0_0)
			{
			default:
				return struct4_0.uint_0.ToString();
			case (Enum0)1:
			case (Enum0)3:
			case (Enum0)5:
			case (Enum0)11:
				return struct4_0.int_0.ToString();
			}
		}

		internal override Class13 vmethod_8()
		{
			return this;
		}

		internal override bool vmethod_9()
		{
			return true;
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (!class13_0.method_0())
			{
				if (class13_0.vmethod_0())
				{
					return ((Class19)class13_0).vmethod_5(this);
				}
				Class13 @class = class13_0.vmethod_8();
				if (@class.vmethod_9())
				{
					if (!@class.method_3())
					{
						if (@class.method_1())
						{
							return struct4_0.int_0 == ((Class15)@class).struct4_0.int_0;
						}
						return ((Class17)@class).vmethod_5(this);
					}
					return false;
				}
				return false;
			}
			return ((Class25)class13_0).vmethod_5(this);
		}

		public static Class14 smethod_4(Class13 class13_0)
		{
			Class14 @class = class13_0 as Class14;
			if (@class == null && class13_0.vmethod_0())
			{
				@class = class13_0.vmethod_8() as Class14;
			}
			return @class;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (class13_0.method_0())
			{
				return false;
			}
			if (class13_0.vmethod_0())
			{
				return ((Class19)class13_0).vmethod_6(this);
			}
			Class13 @class = class13_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (!@class.method_3())
			{
				if (@class.method_1())
				{
					return struct4_0.uint_0 != ((Class15)@class).struct4_0.uint_0;
				}
				return ((Class17)@class).vmethod_6(this);
			}
			return false;
		}

		public override bool vmethod_73(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return struct4_0.int_0 >= ((Class15)class13_0).struct4_0.int_0;
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_77(this);
		}

		public override bool vmethod_74(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				return ((Class17)class13_0).vmethod_78(this);
			}
			return struct4_0.uint_0 >= ((Class15)class13_0).struct4_0.uint_0;
		}

		public override bool vmethod_75(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					return ((Class17)class13_0).vmethod_79(this);
				}
				throw new Exception1();
			}
			return struct4_0.int_0 > ((Class15)class13_0).struct4_0.int_0;
		}

		public override bool vmethod_76(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return struct4_0.uint_0 > ((Class15)class13_0).struct4_0.uint_0;
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_80(this);
		}

		public override bool vmethod_77(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return struct4_0.int_0 <= ((Class15)class13_0).struct4_0.int_0;
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_73(this);
		}

		public override bool vmethod_78(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				return ((Class17)class13_0).vmethod_74(this);
			}
			return struct4_0.uint_0 <= ((Class15)class13_0).struct4_0.uint_0;
		}

		public override bool vmethod_79(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				return ((Class17)class13_0).vmethod_75(this);
			}
			return struct4_0.int_0 < ((Class15)class13_0).struct4_0.int_0;
		}

		public override bool vmethod_80(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				return struct4_0.uint_0 < ((Class15)class13_0).struct4_0.uint_0;
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			return ((Class17)class13_0).vmethod_76(this);
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Struct5
	{
		[FieldOffset(0)]
		public byte byte_0;

		[FieldOffset(0)]
		public sbyte sbyte_0;

		[FieldOffset(0)]
		public ushort ushort_0;

		[FieldOffset(0)]
		public short short_0;

		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(0)]
		public int int_0;

		[FieldOffset(0)]
		public ulong ulong_0;

		[FieldOffset(0)]
		public long long_0;
	}

	public class Class16 : Class14
	{
		public Struct5 struct5_0;

		public Enum0 enum0_0;

		internal override void vmethod_10(Class13 class13_0)
		{
			struct5_0 = ((Class16)class13_0).struct5_0;
			enum0_0 = ((Class16)class13_0).enum0_0;
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_10(class13_0);
		}

		public Class16(long long_0)
		{
			enum3_0 = (Enum3)2;
			struct5_0.long_0 = long_0;
			enum0_0 = (Enum0)7;
		}

		public Class16(Class16 class16_0)
		{
			enum3_0 = class16_0.enum3_0;
			struct5_0.long_0 = class16_0.struct5_0.long_0;
			enum0_0 = class16_0.enum0_0;
		}

		public override Class14 vmethod_69()
		{
			return new Class16(this);
		}

		public Class16(long long_0, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)2;
			struct5_0.long_0 = long_0;
			enum0_0 = enum0_1;
		}

		public Class16(ulong ulong_0)
		{
			enum3_0 = (Enum3)2;
			struct5_0.ulong_0 = ulong_0;
			enum0_0 = (Enum0)8;
		}

		public Class16(ulong ulong_0, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)2;
			struct5_0.ulong_0 = ulong_0;
			enum0_0 = enum0_1;
		}

		public override bool ucFrayBeGvG()
		{
			if (enum0_0 == (Enum0)7)
			{
				return struct5_0.long_0 == 0L;
			}
			return struct5_0.ulong_0 == 0L;
		}

		public override bool vmethod_11()
		{
			return !ucFrayBeGvG();
		}

		public override Class13 vmethod_12(Enum0 enum0_1)
		{
			return enum0_1 switch
			{
				(Enum0)1 => vmethod_13(), 
				(Enum0)2 => vmethod_14(), 
				(Enum0)3 => vmethod_15(), 
				(Enum0)4 => vmethod_16(), 
				(Enum0)5 => vmethod_17(), 
				(Enum0)6 => vmethod_18(), 
				(Enum0)7 => vmethod_19(), 
				(Enum0)8 => vmethod_20(), 
				(Enum0)11 => zrQrasfExAV(), 
				(Enum0)15 => method_7(), 
				(Enum0)16 => vmethod_69(), 
				_ => throw new Exception(Enum4.TruncationNotSupported.ToString()), 
			};
		}

		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (!(type_0 == null) && !(type_0 == typeof(object)))
			{
				if (type_0 == typeof(int))
				{
					return struct5_0.int_0;
				}
				if (type_0 == typeof(uint))
				{
					return struct5_0.uint_0;
				}
				if (type_0 == typeof(short))
				{
					return struct5_0.short_0;
				}
				if (type_0 == typeof(ushort))
				{
					return struct5_0.ushort_0;
				}
				if (!(type_0 == typeof(byte)))
				{
					if (!(type_0 == typeof(sbyte)))
					{
						if (type_0 == typeof(bool))
						{
							return !ucFrayBeGvG();
						}
						if (type_0 == typeof(long))
						{
							return struct5_0.long_0;
						}
						if (type_0 == typeof(ulong))
						{
							return struct5_0.ulong_0;
						}
						if (!(type_0 == typeof(char)))
						{
							if (!type_0.IsEnum)
							{
								throw new Exception1();
							}
							return method_6(type_0);
						}
						return (char)struct5_0.long_0;
					}
					return struct5_0.sbyte_0;
				}
				return struct5_0.byte_0;
			}
			return enum0_0 switch
			{
				(Enum0)1 => struct5_0.sbyte_0, 
				(Enum0)2 => struct5_0.byte_0, 
				(Enum0)3 => struct5_0.short_0, 
				(Enum0)4 => struct5_0.ushort_0, 
				(Enum0)5 => struct5_0.int_0, 
				(Enum0)6 => struct5_0.uint_0, 
				(Enum0)7 => struct5_0.long_0, 
				(Enum0)8 => struct5_0.ulong_0, 
				(Enum0)11 => vmethod_11(), 
				(Enum0)15 => (char)struct5_0.int_0, 
				_ => struct5_0.long_0, 
			};
		}

		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (!(underlyingType == typeof(int)))
			{
				if (!(underlyingType == typeof(uint)))
				{
					if (!(underlyingType == typeof(short)))
					{
						if (!(underlyingType == typeof(ushort)))
						{
							if (!(underlyingType == typeof(byte)))
							{
								if (!(underlyingType == typeof(sbyte)))
								{
									if (!(underlyingType == typeof(long)))
									{
										if (!(underlyingType == typeof(ulong)))
										{
											if (!(underlyingType == typeof(char)))
											{
												return Enum.ToObject(type_0, struct5_0.long_0);
											}
											return Enum.ToObject(type_0, (ushort)struct5_0.int_0);
										}
										return Enum.ToObject(type_0, struct5_0.ulong_0);
									}
									return Enum.ToObject(type_0, struct5_0.long_0);
								}
								return Enum.ToObject(type_0, struct5_0.sbyte_0);
							}
							return Enum.ToObject(type_0, struct5_0.byte_0);
						}
						return Enum.ToObject(type_0, struct5_0.ushort_0);
					}
					return Enum.ToObject(type_0, struct5_0.short_0);
				}
				return Enum.ToObject(type_0, struct5_0.uint_0);
			}
			return Enum.ToObject(type_0, struct5_0.int_0);
		}

		public override Class15 zrQrasfExAV()
		{
			return new Class15((!ucFrayBeGvG()) ? 1 : 0);
		}

		internal override bool vmethod_7()
		{
			return vmethod_11();
		}

		public Class15 method_7()
		{
			return new Class15(struct5_0.sbyte_0, (Enum0)15);
		}

		public override Class15 vmethod_13()
		{
			return new Class15(struct5_0.sbyte_0, (Enum0)1);
		}

		public override Class15 vmethod_14()
		{
			return new Class15((uint)struct5_0.byte_0, (Enum0)2);
		}

		public override Class15 vmethod_15()
		{
			return new Class15(struct5_0.short_0, (Enum0)3);
		}

		public override Class15 vmethod_16()
		{
			return new Class15((uint)struct5_0.ushort_0, (Enum0)4);
		}

		public override Class15 vmethod_17()
		{
			return new Class15(struct5_0.int_0, (Enum0)5);
		}

		public override Class15 vmethod_18()
		{
			return new Class15(struct5_0.uint_0, (Enum0)6);
		}

		public override Class16 vmethod_19()
		{
			return new Class16(struct5_0.long_0, (Enum0)7);
		}

		public override Class16 vmethod_20()
		{
			return new Class16(struct5_0.ulong_0, (Enum0)8);
		}

		public override Class15 rIoranxyrKy()
		{
			return vmethod_13();
		}

		public override Class15 vmethod_21()
		{
			return vmethod_15();
		}

		public override Class15 vmethod_22()
		{
			return vmethod_17();
		}

		public override Class16 vmethod_23()
		{
			return vmethod_19();
		}

		public override Class15 vmethod_24()
		{
			return vmethod_14();
		}

		public override Class15 vmethod_25()
		{
			return vmethod_16();
		}

		public override Class15 vmethod_26()
		{
			return vmethod_18();
		}

		public override Class16 vmethod_27()
		{
			return vmethod_20();
		}

		public override Class15 vmethod_28()
		{
			return new Class15(checked((sbyte)struct5_0.long_0), (Enum0)1);
		}

		public override Class15 vmethod_29()
		{
			return new Class15(checked((sbyte)struct5_0.ulong_0), (Enum0)1);
		}

		public override Class15 vmethod_30()
		{
			return new Class15(checked((short)struct5_0.long_0), (Enum0)3);
		}

		public override Class15 vmethod_31()
		{
			return new Class15(checked((short)struct5_0.ulong_0), (Enum0)3);
		}

		public override Class15 vmethod_32()
		{
			return new Class15(checked((int)struct5_0.long_0), (Enum0)5);
		}

		public override Class15 vmethod_33()
		{
			return new Class15(checked((int)struct5_0.ulong_0), (Enum0)5);
		}

		public override Class16 vmethod_34()
		{
			return new Class16(struct5_0.long_0, (Enum0)7);
		}

		public override Class16 vmethod_35()
		{
			return new Class16(checked((long)struct5_0.ulong_0), (Enum0)7);
		}

		public override Class15 vmethod_36()
		{
			return new Class15(checked((byte)struct5_0.long_0), (Enum0)2);
		}

		public override Class15 vmethod_37()
		{
			return new Class15(checked((byte)struct5_0.ulong_0), (Enum0)2);
		}

		public override Class15 vmethod_38()
		{
			return new Class15(checked((ushort)struct5_0.long_0), (Enum0)4);
		}

		public override Class15 vmethod_39()
		{
			return new Class15(checked((ushort)struct5_0.ulong_0), (Enum0)4);
		}

		public override Class15 vmethod_40()
		{
			return new Class15(checked((uint)struct5_0.long_0), (Enum0)6);
		}

		public override Class15 vmethod_41()
		{
			return new Class15(checked((uint)struct5_0.ulong_0), (Enum0)6);
		}

		public override Class16 vmethod_42()
		{
			return new Class16(checked((ulong)struct5_0.long_0), (Enum0)8);
		}

		public override Class16 vmethod_43()
		{
			return new Class16(struct5_0.ulong_0, (Enum0)8);
		}

		public override Class18 vmethod_44()
		{
			return new Class18(struct5_0.long_0);
		}

		public override Class18 vmethod_45()
		{
			return new Class18((double)struct5_0.long_0);
		}

		public override Class18 vmethod_46()
		{
			return new Class18((double)struct5_0.ulong_0);
		}

		public override Class17 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_23().struct5_0.long_0);
			}
			return new Class17(vmethod_22().struct4_0.int_0);
		}

		public override Class17 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_27().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_26().struct4_0.uint_0);
		}

		public override Class17 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_34().struct5_0.long_0);
			}
			return new Class17(vmethod_32().struct4_0.int_0);
		}

		public override Class17 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_42().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_40().struct4_0.uint_0);
		}

		public override Class17 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_35().struct5_0.long_0);
			}
			return new Class17(vmethod_33().struct4_0.int_0);
		}

		public override Class17 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(struct5_0.ulong_0);
			}
			return new Class17((ulong)checked((uint)struct5_0.ulong_0));
		}

		public override Class13 vmethod_53()
		{
			return new Class16(-struct5_0.long_0);
		}

		public override Class13 Add(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 + ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_54(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(checked(struct5_0.long_0 + ((Class16)class13_0).struct5_0.long_0));
		}

		public override Class13 vmethod_55(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(checked(struct5_0.ulong_0 + ((Class16)class13_0).struct5_0.ulong_0));
		}

		public override Class13 vmethod_56(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 - ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_57(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(checked(struct5_0.long_0 - ((Class16)class13_0).struct5_0.long_0));
		}

		public override Class13 vmethod_58(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(checked(struct5_0.ulong_0 - ((Class16)class13_0).struct5_0.ulong_0));
		}

		public override Class13 vmethod_59(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 * ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_60(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(checked(struct5_0.long_0 * ((Class16)class13_0).struct5_0.long_0));
		}

		public override Class13 vmethod_61(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(checked(struct5_0.ulong_0 * ((Class16)class13_0).struct5_0.ulong_0));
		}

		public override Class13 vmethod_62(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 / ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_63(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.ulong_0 / ((Class16)class13_0).struct5_0.ulong_0);
		}

		public override Class13 vPxrkrTinu9(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 % ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_64(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.ulong_0 % ((Class16)class13_0).struct5_0.ulong_0);
		}

		public override Class13 vmethod_65(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 & ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_66(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 | ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_67()
		{
			return new Class16(~struct5_0.long_0);
		}

		public override Class13 vmethod_68(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 ^ ((Class16)class13_0).struct5_0.long_0);
		}

		public override Class13 vmethod_70(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				if (class13_0.vmethod_3())
				{
					return new Class16(struct5_0.long_0 << ((Class14)class13_0).vmethod_17().struct4_0.int_0);
				}
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 << ((Class16)class13_0).struct5_0.int_0);
		}

		public override Class13 vmethod_71(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_3())
			{
				return new Class16(struct5_0.long_0 >> ((Class16)class13_0).struct5_0.int_0);
			}
			if (!class13_0.vmethod_3())
			{
				throw new Exception1();
			}
			return new Class16(struct5_0.long_0 >> ((Class14)class13_0).vmethod_17().struct4_0.int_0);
		}

		public override Class13 vmethod_72(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				if (!class13_0.vmethod_3())
				{
					throw new Exception1();
				}
				return new Class16(struct5_0.ulong_0 >> ((Class14)class13_0).vmethod_17().struct4_0.int_0);
			}
			return new Class16(struct5_0.ulong_0 >> ((Class16)class13_0).struct5_0.int_0);
		}

		public override string ToString()
		{
			if (enum0_0 == (Enum0)7)
			{
				return struct5_0.long_0.ToString();
			}
			return struct5_0.ulong_0.ToString();
		}

		internal override Class13 vmethod_8()
		{
			return this;
		}

		internal override bool vmethod_9()
		{
			return true;
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (class13_0.method_0())
			{
				return ((Class25)class13_0).vmethod_5(this);
			}
			if (class13_0.vmethod_0())
			{
				return ((Class19)class13_0).vmethod_5(this);
			}
			Class13 @class = class13_0.vmethod_8();
			if (!@class.method_3())
			{
				return false;
			}
			return struct5_0.long_0 == ((Class16)@class).struct5_0.long_0;
		}

		public static Class14 smethod_4(Class13 class13_0)
		{
			Class14 @class = class13_0 as Class14;
			if (@class == null && class13_0.vmethod_0())
			{
				@class = class13_0.vmethod_8() as Class14;
			}
			return @class;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (class13_0.method_0())
			{
				return false;
			}
			if (class13_0.vmethod_0())
			{
				return ((Class19)class13_0).vmethod_6(this);
			}
			Class13 @class = class13_0.vmethod_8();
			if (!@class.method_3())
			{
				return false;
			}
			return struct5_0.ulong_0 != ((Class16)@class).struct5_0.ulong_0;
		}

		public override bool vmethod_73(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.long_0 >= ((Class16)class13_0).struct5_0.long_0;
		}

		public override bool vmethod_74(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.ulong_0 >= ((Class16)class13_0).struct5_0.ulong_0;
		}

		public override bool vmethod_75(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.long_0 > ((Class16)class13_0).struct5_0.long_0;
		}

		public override bool vmethod_76(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.ulong_0 > ((Class16)class13_0).struct5_0.ulong_0;
		}

		public override bool vmethod_77(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.long_0 <= ((Class16)class13_0).struct5_0.long_0;
		}

		public override bool vmethod_78(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.ulong_0 <= ((Class16)class13_0).struct5_0.ulong_0;
		}

		public override bool vmethod_79(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.long_0 < ((Class16)class13_0).struct5_0.long_0;
		}

		public override bool vmethod_80(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_3())
			{
				throw new Exception1();
			}
			return struct5_0.ulong_0 < ((Class16)class13_0).struct5_0.ulong_0;
		}
	}

	public class Class17 : Class14
	{
		public object object_0;

		public Enum0 enum0_0;

		internal void method_6(Class13 class13_0)
		{
			if (class13_0.method_2())
			{
				object_0 = ((Class17)class13_0).object_0;
				enum0_0 = ((Class17)class13_0).enum0_0;
			}
			else
			{
				vmethod_10(class13_0);
			}
		}

		internal unsafe override void vmethod_10(Class13 class13_0)
		{
			if (!class13_0.method_2())
			{
				object obj = class13_0.vmethod_4(null);
				if (obj == null)
				{
					return;
				}
				IntPtr intPtr = ((IntPtr.Size != 8) ? new IntPtr(((Class15)object_0).struct4_0.int_0) : new IntPtr(((Class16)object_0).struct5_0.long_0));
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (!(type == typeof(byte)))
				{
					if (!(type == typeof(sbyte)))
					{
						if (!(type == typeof(short)))
						{
							if (!(type == typeof(ushort)))
							{
								if (type == typeof(int))
								{
									*(int*)(void*)intPtr = (int)obj;
								}
								else if (!(type == typeof(uint)))
								{
									if (!(type == typeof(long)))
									{
										if (!(type == typeof(ulong)))
										{
											if (!(type == typeof(float)))
											{
												if (!(type == typeof(double)))
												{
													if (!(type == typeof(bool)))
													{
														if (!(type == typeof(IntPtr)))
														{
															if (type == typeof(UIntPtr))
															{
																*(UIntPtr*)(void*)intPtr = (UIntPtr)obj;
																return;
															}
															if (!(type == typeof(char)))
															{
																throw new Exception1();
															}
															*(char*)(void*)intPtr = (char)obj;
														}
														else
														{
															*(IntPtr*)(void*)intPtr = (IntPtr)obj;
														}
													}
													else
													{
														*(bool*)(void*)intPtr = (bool)obj;
													}
												}
												else
												{
													*(double*)(void*)intPtr = (double)obj;
												}
											}
											else
											{
												*(float*)(void*)intPtr = (float)obj;
											}
										}
										else
										{
											*(ulong*)(void*)intPtr = (ulong)obj;
										}
									}
									else
									{
										*(long*)(void*)intPtr = (long)obj;
									}
								}
								else
								{
									*(uint*)(void*)intPtr = (uint)obj;
								}
							}
							else
							{
								*(ushort*)(void*)intPtr = (ushort)obj;
							}
						}
						else
						{
							*(short*)(void*)intPtr = (short)obj;
						}
					}
					else
					{
						*(sbyte*)(void*)intPtr = (sbyte)obj;
					}
				}
				else
				{
					*(byte*)(void*)intPtr = (byte)obj;
				}
			}
			else if (IntPtr.Size == 8)
			{
				IntPtr intPtr2 = new IntPtr(((Class16)object_0).struct5_0.long_0);
				IntPtr intPtr3 = new IntPtr(((Class16)((Class17)class13_0).object_0).struct5_0.long_0);
				*(long*)(void*)intPtr2 = intPtr3.ToInt64();
			}
			else
			{
				IntPtr intPtr4 = new IntPtr(((Class15)object_0).struct4_0.int_0);
				IntPtr intPtr5 = new IntPtr(((Class15)((Class17)class13_0).object_0).struct4_0.int_0);
				*(int*)(void*)intPtr4 = intPtr5.ToInt32();
			}
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_10(class13_0);
		}

		public Class17(IntPtr intptr_0)
		{
			enum3_0 = (Enum3)3;
			if (IntPtr.Size == 8)
			{
				object_0 = new Class16(intptr_0.ToInt64());
				enum0_0 = (Enum0)12;
			}
			else
			{
				object_0 = new Class15(intptr_0.ToInt32());
				enum0_0 = (Enum0)12;
			}
		}

		public Class17(UIntPtr uintptr_0)
		{
			enum3_0 = (Enum3)3;
			if (IntPtr.Size == 8)
			{
				object_0 = new Class16(uintptr_0.ToUInt64());
				enum0_0 = (Enum0)12;
			}
			else
			{
				object_0 = new Class15(uintptr_0.ToUInt32());
				enum0_0 = (Enum0)12;
			}
		}

		public Class17()
		{
			enum3_0 = (Enum3)3;
			if (IntPtr.Size == 8)
			{
				object_0 = new Class16(0L);
				enum0_0 = (Enum0)12;
			}
			else
			{
				object_0 = new Class15(0);
				enum0_0 = (Enum0)12;
			}
		}

		public override Class14 vmethod_69()
		{
			Class17 @class = new Class17();
			@class.object_0 = ((Class14)object_0).vmethod_69();
			@class.enum0_0 = enum0_0;
			return @class;
		}

		public Class17(long long_0)
		{
			enum3_0 = (Enum3)3;
			if (IntPtr.Size == 8)
			{
				object_0 = new Class16(long_0);
				enum0_0 = (Enum0)12;
			}
			else
			{
				object_0 = new Class15((int)long_0);
				enum0_0 = (Enum0)12;
			}
		}

		public Class17(long long_0, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)3;
			if (IntPtr.Size == 8)
			{
				object_0 = new Class16(long_0);
				enum0_0 = enum0_1;
			}
			else
			{
				object_0 = new Class15((int)long_0);
				enum0_0 = enum0_1;
			}
		}

		public Class17(ulong ulong_0)
		{
			enum3_0 = (Enum3)4;
			if (IntPtr.Size == 8)
			{
				object_0 = new Class16(ulong_0);
				enum0_0 = (Enum0)13;
			}
			else
			{
				object_0 = new Class15((uint)ulong_0);
				enum0_0 = (Enum0)13;
			}
		}

		public Class17(ulong ulong_0, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)4;
			if (IntPtr.Size == 8)
			{
				object_0 = new Class16(ulong_0);
				enum0_0 = enum0_1;
			}
			else
			{
				object_0 = new Class15((uint)ulong_0);
				enum0_0 = enum0_1;
			}
		}

		public override bool ucFrayBeGvG()
		{
			return ((Class14)object_0).ucFrayBeGvG();
		}

		public override bool vmethod_11()
		{
			return !ucFrayBeGvG();
		}

		internal override bool vmethod_7()
		{
			return vmethod_11();
		}

		internal override bool vmethod_1()
		{
			return true;
		}

		public override Class13 vmethod_12(Enum0 enum0_1)
		{
			return enum0_1 switch
			{
				(Enum0)1 => vmethod_13(), 
				(Enum0)2 => vmethod_14(), 
				(Enum0)3 => vmethod_15(), 
				(Enum0)4 => vmethod_16(), 
				(Enum0)5 => vmethod_17(), 
				(Enum0)6 => vmethod_18(), 
				(Enum0)7 => vmethod_19(), 
				(Enum0)8 => vmethod_20(), 
				(Enum0)11 => zrQrasfExAV(), 
				(Enum0)12 => this, 
				(Enum0)13 => this, 
				(Enum0)16 => vmethod_69(), 
				_ => throw new Exception(Enum4.TruncationNotSupported.ToString()), 
			};
		}

		internal IntPtr method_7()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class16)object_0).struct5_0.long_0);
			}
			return new IntPtr(((Class15)object_0).struct4_0.int_0);
		}

		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(IntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class16)object_0).struct5_0.long_0);
				}
				return new IntPtr(((Class15)object_0).struct4_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new UIntPtr(((Class16)object_0).struct5_0.ulong_0);
				}
				return new UIntPtr(((Class15)object_0).struct4_0.uint_0);
			}
			if (!(type_0 == null) && !(type_0 == typeof(object)))
			{
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				if (enum0_0 == (Enum0)12)
				{
					return new IntPtr(((Class16)object_0).struct5_0.long_0);
				}
				return new UIntPtr(((Class16)object_0).struct5_0.ulong_0);
			}
			if (enum0_0 == (Enum0)12)
			{
				return new IntPtr(((Class16)object_0).struct5_0.int_0);
			}
			return new UIntPtr(((Class15)object_0).struct4_0.uint_0);
		}

		public override Class15 zrQrasfExAV()
		{
			return ((Class14)object_0).zrQrasfExAV();
		}

		public override Class15 vmethod_13()
		{
			return ((Class14)object_0).vmethod_13();
		}

		public override Class15 vmethod_14()
		{
			return ((Class14)object_0).vmethod_14();
		}

		public override Class15 vmethod_15()
		{
			return ((Class14)object_0).vmethod_15();
		}

		public override Class15 vmethod_16()
		{
			return ((Class14)object_0).vmethod_16();
		}

		public override Class15 vmethod_17()
		{
			return ((Class14)object_0).vmethod_17();
		}

		public override Class15 vmethod_18()
		{
			return ((Class14)object_0).vmethod_18();
		}

		public override Class16 vmethod_19()
		{
			return ((Class14)object_0).vmethod_19();
		}

		public override Class16 vmethod_20()
		{
			return ((Class14)object_0).vmethod_20();
		}

		public override Class15 rIoranxyrKy()
		{
			return vmethod_13();
		}

		public override Class15 vmethod_21()
		{
			return vmethod_15();
		}

		public override Class15 vmethod_22()
		{
			return vmethod_17();
		}

		public override Class16 vmethod_23()
		{
			return vmethod_19();
		}

		public override Class15 vmethod_24()
		{
			return vmethod_14();
		}

		public override Class15 vmethod_25()
		{
			return vmethod_16();
		}

		public override Class15 vmethod_26()
		{
			return vmethod_18();
		}

		public override Class16 vmethod_27()
		{
			return vmethod_20();
		}

		public override Class15 vmethod_28()
		{
			return ((Class14)object_0).vmethod_28();
		}

		public override Class15 vmethod_29()
		{
			return ((Class14)object_0).vmethod_29();
		}

		public override Class15 vmethod_30()
		{
			return ((Class14)object_0).vmethod_30();
		}

		public override Class15 vmethod_31()
		{
			return ((Class14)object_0).vmethod_31();
		}

		public override Class15 vmethod_32()
		{
			return ((Class14)object_0).vmethod_32();
		}

		public override Class15 vmethod_33()
		{
			return ((Class14)object_0).vmethod_33();
		}

		public override Class16 vmethod_34()
		{
			return ((Class14)object_0).vmethod_34();
		}

		public override Class16 vmethod_35()
		{
			return ((Class14)object_0).vmethod_35();
		}

		public override Class15 vmethod_36()
		{
			return ((Class14)object_0).vmethod_36();
		}

		public override Class15 vmethod_37()
		{
			return ((Class14)object_0).vmethod_37();
		}

		public override Class15 vmethod_38()
		{
			return ((Class14)object_0).vmethod_38();
		}

		public override Class15 vmethod_39()
		{
			return ((Class14)object_0).vmethod_39();
		}

		public override Class15 vmethod_40()
		{
			return ((Class14)object_0).vmethod_40();
		}

		public override Class15 vmethod_41()
		{
			return ((Class14)object_0).vmethod_41();
		}

		public override Class16 vmethod_42()
		{
			return ((Class14)object_0).vmethod_42();
		}

		public override Class16 vmethod_43()
		{
			return ((Class14)object_0).vmethod_43();
		}

		public override Class18 vmethod_44()
		{
			return ((Class14)object_0).vmethod_44();
		}

		public override Class18 vmethod_45()
		{
			return ((Class14)object_0).vmethod_45();
		}

		public override Class18 vmethod_46()
		{
			return ((Class14)object_0).vmethod_46();
		}

		public override Class17 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_23().struct5_0.long_0);
			}
			return new Class17(vmethod_22().struct4_0.int_0);
		}

		public override Class17 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_27().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_26().struct4_0.uint_0);
		}

		public override Class17 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_34().struct5_0.long_0);
			}
			return new Class17(vmethod_32().struct4_0.int_0);
		}

		public override Class17 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_42().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_40().struct4_0.uint_0);
		}

		public override Class17 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_35().struct5_0.long_0);
			}
			return new Class17(vmethod_33().struct4_0.int_0);
		}

		public override Class17 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_43().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_41().struct4_0.uint_0);
		}

		public override Class13 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(-((Class16)object_0).struct5_0.long_0);
			}
			return new Class17(-((Class15)object_0).struct4_0.int_0);
		}

		public override Class13 Add(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(vmethod_19().struct5_0.long_0 + ((Class17)class13_0).vmethod_19().struct5_0.long_0);
					}
					return new Class17(vmethod_17().struct4_0.int_0 + ((Class17)class13_0).vmethod_17().struct4_0.int_0);
				}
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 + ((Class15)class13_0).vmethod_19().struct5_0.long_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 + ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_54(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			checked
			{
				if (!class13_0.method_1())
				{
					if (class13_0.method_2())
					{
						if (IntPtr.Size == 8)
						{
							return new Class17(vmethod_19().struct5_0.long_0 + ((Class17)class13_0).vmethod_19().struct5_0.long_0);
						}
						return new Class17(vmethod_17().struct4_0.int_0 + ((Class17)class13_0).vmethod_17().struct4_0.int_0);
					}
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 + ((Class15)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 + ((Class15)class13_0).struct4_0.int_0);
			}
		}

		public override Class13 vmethod_55(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			checked
			{
				if (class13_0.method_1())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(vmethod_19().struct5_0.ulong_0 + ((Class15)class13_0).struct4_0.uint_0);
					}
					return new Class17(vmethod_17().struct4_0.uint_0 + ((Class15)class13_0).struct4_0.uint_0);
				}
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.ulong_0 + ((Class17)class13_0).vmethod_19().struct5_0.ulong_0);
				}
			}
			return new Class17((ulong)checked(vmethod_17().struct4_0.uint_0 + ((Class17)class13_0).vmethod_17().struct4_0.uint_0));
		}

		public override Class13 vmethod_56(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(vmethod_19().struct5_0.long_0 - ((Class17)class13_0).vmethod_19().struct5_0.long_0);
					}
					return new Class17(vmethod_17().struct4_0.int_0 - ((Class17)class13_0).vmethod_17().struct4_0.int_0);
				}
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 - ((Class15)class13_0).vmethod_19().struct5_0.long_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 - ((Class15)class13_0).struct4_0.int_0);
		}

		public Class13 method_8(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(((Class17)class13_0).vmethod_19().struct5_0.long_0 - vmethod_19().struct5_0.long_0);
					}
					return new Class17(((Class17)class13_0).vmethod_17().struct4_0.int_0 - vmethod_17().struct4_0.int_0);
				}
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(((Class15)class13_0).vmethod_19().struct5_0.long_0 - vmethod_19().struct5_0.long_0);
			}
			return new Class17(((Class15)class13_0).struct4_0.int_0 - vmethod_17().struct4_0.int_0);
		}

		public override Class13 vmethod_57(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			checked
			{
				if (!class13_0.method_1())
				{
					if (class13_0.method_2())
					{
						if (IntPtr.Size == 8)
						{
							return new Class17(vmethod_19().struct5_0.long_0 - ((Class17)class13_0).vmethod_19().struct5_0.long_0);
						}
						return new Class17(vmethod_17().struct4_0.int_0 - ((Class17)class13_0).vmethod_17().struct4_0.int_0);
					}
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 - ((Class15)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 - ((Class15)class13_0).struct4_0.int_0);
			}
		}

		public Class13 method_9(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			checked
			{
				if (!class13_0.method_1())
				{
					if (!class13_0.method_2())
					{
						throw new Exception1();
					}
					if (IntPtr.Size == 8)
					{
						return new Class17(((Class17)class13_0).vmethod_19().struct5_0.long_0 - vmethod_19().struct5_0.long_0);
					}
					return new Class17(((Class17)class13_0).vmethod_17().struct4_0.int_0 - vmethod_17().struct4_0.int_0);
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class15)class13_0).vmethod_19().struct5_0.long_0 - vmethod_19().struct5_0.long_0);
				}
				return new Class17(((Class15)class13_0).struct4_0.int_0 - vmethod_17().struct4_0.int_0);
			}
		}

		public override Class13 vmethod_58(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			checked
			{
				if (class13_0.method_1())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(vmethod_19().struct5_0.ulong_0 - ((Class15)class13_0).struct4_0.uint_0);
					}
					return new Class17(vmethod_17().struct4_0.uint_0 - ((Class15)class13_0).struct4_0.uint_0);
				}
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.ulong_0 - ((Class17)class13_0).vmethod_19().struct5_0.ulong_0);
				}
			}
			return new Class17((ulong)checked(vmethod_17().struct4_0.uint_0 - ((Class17)class13_0).vmethod_17().struct4_0.uint_0));
		}

		public Class13 method_10(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			checked
			{
				if (class13_0.method_1())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(((Class15)class13_0).struct4_0.uint_0 - vmethod_19().struct5_0.ulong_0);
					}
					return new Class17(((Class15)class13_0).struct4_0.uint_0 - vmethod_17().struct4_0.uint_0);
				}
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class17)class13_0).vmethod_19().struct5_0.ulong_0 - vmethod_19().struct5_0.ulong_0);
				}
			}
			return new Class17((ulong)checked(((Class17)class13_0).vmethod_17().struct4_0.uint_0 - vmethod_17().struct4_0.uint_0));
		}

		public override Class13 vmethod_59(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 * ((Class15)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 * ((Class15)class13_0).struct4_0.int_0);
			}
			if (class13_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 * ((Class17)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 * ((Class17)class13_0).vmethod_17().struct4_0.int_0);
			}
			throw new Exception1();
		}

		public override Class13 vmethod_60(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			checked
			{
				if (!class13_0.method_1())
				{
					if (!class13_0.method_2())
					{
						throw new Exception1();
					}
					if (IntPtr.Size == 8)
					{
						return new Class17(vmethod_19().struct5_0.long_0 * ((Class17)class13_0).vmethod_19().struct5_0.long_0);
					}
					return new Class17(vmethod_17().struct4_0.int_0 * ((Class17)class13_0).vmethod_17().struct4_0.int_0);
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 * ((Class15)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 * ((Class15)class13_0).struct4_0.int_0);
			}
		}

		public override Class13 vmethod_61(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(checked(vmethod_19().struct5_0.ulong_0 * ((Class17)class13_0).vmethod_19().struct5_0.ulong_0));
					}
					return new Class17((ulong)checked(vmethod_17().struct4_0.uint_0 * ((Class17)class13_0).vmethod_17().struct4_0.uint_0));
				}
				throw new Exception1();
			}
			checked
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.ulong_0 * ((Class15)class13_0).struct4_0.uint_0);
				}
				return new Class17(vmethod_17().struct4_0.uint_0 * ((Class15)class13_0).struct4_0.uint_0);
			}
		}

		public override Class13 vmethod_62(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 / ((Class15)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 / ((Class15)class13_0).struct4_0.int_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 / ((Class17)class13_0).vmethod_19().struct5_0.long_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 / ((Class17)class13_0).vmethod_17().struct4_0.int_0);
		}

		public Class13 method_11(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class15)class13_0).vmethod_19().struct5_0.long_0 / vmethod_19().struct5_0.long_0);
				}
				return new Class17(((Class15)class13_0).struct4_0.int_0 / vmethod_17().struct4_0.int_0);
			}
			if (class13_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class17)class13_0).vmethod_19().struct5_0.long_0 / vmethod_19().struct5_0.long_0);
				}
				return new Class17(((Class17)class13_0).vmethod_17().struct4_0.int_0 / vmethod_17().struct4_0.int_0);
			}
			throw new Exception1();
		}

		public override Class13 vmethod_63(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.ulong_0 / ((Class17)class13_0).vmethod_19().struct5_0.ulong_0);
				}
				return new Class17((ulong)(vmethod_17().struct4_0.uint_0 / ((Class17)class13_0).vmethod_17().struct4_0.uint_0));
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.ulong_0 / ((Class15)class13_0).vmethod_19().struct5_0.ulong_0);
			}
			return new Class17(vmethod_17().struct4_0.uint_0 / ((Class15)class13_0).struct4_0.uint_0);
		}

		public Class13 method_12(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class15)class13_0).vmethod_19().struct5_0.ulong_0 / vmethod_19().struct5_0.ulong_0);
				}
				return new Class17(((Class15)class13_0).struct4_0.uint_0 / vmethod_17().struct4_0.uint_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(((Class17)class13_0).vmethod_19().struct5_0.ulong_0 / vmethod_19().struct5_0.ulong_0);
			}
			return new Class17((ulong)(((Class17)class13_0).vmethod_17().struct4_0.uint_0 / vmethod_17().struct4_0.uint_0));
		}

		public override Class13 vPxrkrTinu9(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 % ((Class17)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 % ((Class17)class13_0).vmethod_17().struct4_0.int_0);
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 % ((Class15)class13_0).vmethod_19().struct5_0.long_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 % ((Class15)class13_0).struct4_0.int_0);
		}

		public Class13 method_13(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class15)class13_0).vmethod_19().struct5_0.long_0 % vmethod_19().struct5_0.long_0);
				}
				return new Class17(((Class15)class13_0).struct4_0.int_0 % vmethod_17().struct4_0.int_0);
			}
			if (class13_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class17)class13_0).vmethod_19().struct5_0.long_0 % vmethod_19().struct5_0.long_0);
				}
				return new Class17(((Class17)class13_0).vmethod_17().struct4_0.int_0 % vmethod_17().struct4_0.int_0);
			}
			throw new Exception1();
		}

		public override Class13 vmethod_64(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.ulong_0 % ((Class15)class13_0).vmethod_19().struct5_0.ulong_0);
				}
				return new Class17(vmethod_17().struct4_0.uint_0 % ((Class15)class13_0).struct4_0.uint_0);
			}
			if (class13_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.ulong_0 % ((Class17)class13_0).vmethod_19().struct5_0.ulong_0);
				}
				return new Class17((ulong)(vmethod_17().struct4_0.uint_0 % ((Class17)class13_0).vmethod_17().struct4_0.uint_0));
			}
			throw new Exception1();
		}

		public Class13 hDdjuohhOr(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class15)class13_0).vmethod_19().struct5_0.ulong_0 % vmethod_19().struct5_0.ulong_0);
				}
				return new Class17(((Class15)class13_0).struct4_0.uint_0 % vmethod_17().struct4_0.uint_0);
			}
			if (class13_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(((Class17)class13_0).vmethod_19().struct5_0.ulong_0 % vmethod_19().struct5_0.ulong_0);
				}
				return new Class17((ulong)(((Class17)class13_0).vmethod_17().struct4_0.uint_0 % vmethod_17().struct4_0.uint_0));
			}
			throw new Exception1();
		}

		public override Class13 vmethod_65(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 & ((Class15)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 & ((Class15)class13_0).struct4_0.int_0);
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 & ((Class17)class13_0).vmethod_19().struct5_0.long_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 & ((Class17)class13_0).vmethod_17().struct4_0.int_0);
		}

		public override Class13 vmethod_66(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return new Class17(vmethod_19().struct5_0.long_0 | ((Class17)class13_0).vmethod_19().struct5_0.long_0);
					}
					return new Class17(vmethod_17().struct4_0.int_0 | ((Class17)class13_0).vmethod_17().struct4_0.int_0);
				}
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 | ((Class15)class13_0).vmethod_19().struct5_0.long_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 | ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_67()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(~vmethod_19().struct5_0.long_0);
			}
			return new Class17(~vmethod_17().struct4_0.int_0);
		}

		public override Class13 vmethod_68(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 ^ ((Class17)class13_0).vmethod_19().struct5_0.long_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 ^ ((Class17)class13_0).vmethod_17().struct4_0.int_0);
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 ^ ((Class15)class13_0).vmethod_19().struct5_0.long_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 ^ ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_70(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 << ((Class15)class13_0).struct4_0.int_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 << ((Class15)class13_0).struct4_0.int_0);
			}
			if (class13_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 << ((Class17)class13_0).vmethod_19().struct5_0.int_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 << ((Class17)class13_0).vmethod_17().struct4_0.int_0);
			}
			throw new Exception1();
		}

		public override Class13 vmethod_71(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.long_0 >> ((Class17)class13_0).vmethod_19().struct5_0.int_0);
				}
				return new Class17(vmethod_17().struct4_0.int_0 >> ((Class17)class13_0).vmethod_17().struct4_0.int_0);
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.long_0 >> ((Class15)class13_0).struct4_0.int_0);
			}
			return new Class17(vmethod_17().struct4_0.int_0 >> ((Class15)class13_0).struct4_0.int_0);
		}

		public override Class13 vmethod_72(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class17(vmethod_19().struct5_0.ulong_0 >> ((Class17)class13_0).vmethod_19().struct5_0.int_0);
				}
				return new Class17(vmethod_17().struct4_0.uint_0 >> ((Class17)class13_0).vmethod_17().struct4_0.int_0);
			}
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_19().struct5_0.ulong_0 >> ((Class15)class13_0).struct4_0.int_0);
			}
			return new Class17(vmethod_17().struct4_0.uint_0 >> ((Class15)class13_0).struct4_0.int_0);
		}

		public Class13 method_14(Class15 class15_0)
		{
			return new Class17(class15_0.struct4_0.uint_0 >> vmethod_17().struct4_0.int_0);
		}

		public Class13 method_15(Class15 class15_0)
		{
			return new Class17(class15_0.struct4_0.int_0 >> vmethod_19().struct5_0.int_0);
		}

		public Class13 method_16(Class15 class15_0)
		{
			return new Class17(class15_0.struct4_0.int_0 << vmethod_19().struct5_0.int_0);
		}

		public override string ToString()
		{
			return object_0.ToString();
		}

		internal override Class13 vmethod_8()
		{
			return this;
		}

		internal override bool vmethod_9()
		{
			return true;
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (class13_0.method_0())
			{
				return false;
			}
			if (!class13_0.vmethod_0())
			{
				Class13 @class = class13_0.vmethod_8();
				if (!@class.vmethod_9())
				{
					return false;
				}
				if (!@class.method_1())
				{
					if (!@class.method_2())
					{
						return false;
					}
					if (IntPtr.Size == 8)
					{
						return vmethod_19().struct5_0.long_0 == ((Class17)class13_0).vmethod_19().struct5_0.long_0;
					}
					return vmethod_19().struct5_0.long_0 == ((Class17)class13_0).vmethod_19().struct5_0.long_0;
				}
				if (IntPtr.Size == 8)
				{
					return vmethod_19().struct5_0.long_0 == ((Class15)class13_0).vmethod_19().struct5_0.long_0;
				}
				return vmethod_17().struct4_0.int_0 == ((Class15)class13_0).struct4_0.int_0;
			}
			return ((Class19)class13_0).vmethod_5(this);
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (!class13_0.method_0())
			{
				if (!class13_0.vmethod_0())
				{
					Class13 @class = class13_0.vmethod_8();
					if (!@class.vmethod_9())
					{
						return false;
					}
					if (@class.method_1())
					{
						if (IntPtr.Size == 8)
						{
							return vmethod_19().struct5_0.ulong_0 != ((Class15)class13_0).vmethod_19().struct5_0.ulong_0;
						}
						return vmethod_17().struct4_0.uint_0 != ((Class15)class13_0).struct4_0.uint_0;
					}
					if (!@class.method_2())
					{
						return false;
					}
					if (IntPtr.Size == 8)
					{
						return vmethod_19().struct5_0.ulong_0 != ((Class17)class13_0).vmethod_19().struct5_0.ulong_0;
					}
					return vmethod_19().struct5_0.ulong_0 != ((Class17)class13_0).vmethod_19().struct5_0.ulong_0;
				}
				return ((Class19)class13_0).vmethod_6(this);
			}
			return false;
		}

		public override bool vmethod_73(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return vmethod_19().struct5_0.long_0 >= ((Class15)class13_0).vmethod_19().struct5_0.long_0;
				}
				return vmethod_17().struct4_0.int_0 >= ((Class15)class13_0).struct4_0.int_0;
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return vmethod_19().struct5_0.long_0 >= ((Class17)class13_0).vmethod_19().struct5_0.long_0;
			}
			return vmethod_17().struct4_0.int_0 >= ((Class17)class13_0).vmethod_17().struct4_0.int_0;
		}

		public override bool vmethod_74(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return vmethod_19().struct5_0.ulong_0 >= ((Class15)class13_0).vmethod_19().struct5_0.ulong_0;
				}
				return vmethod_17().struct4_0.uint_0 >= ((Class15)class13_0).struct4_0.uint_0;
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return vmethod_19().struct5_0.ulong_0 >= ((Class17)class13_0).vmethod_19().struct5_0.ulong_0;
			}
			return vmethod_17().struct4_0.uint_0 >= ((Class17)class13_0).vmethod_17().struct4_0.uint_0;
		}

		public override bool vmethod_75(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (!class13_0.method_2())
				{
					throw new Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return vmethod_19().struct5_0.long_0 > ((Class17)class13_0).vmethod_19().struct5_0.long_0;
				}
				return vmethod_17().struct4_0.int_0 > ((Class17)class13_0).vmethod_17().struct4_0.int_0;
			}
			if (IntPtr.Size == 8)
			{
				return vmethod_19().struct5_0.long_0 > ((Class15)class13_0).vmethod_19().struct5_0.long_0;
			}
			return vmethod_17().struct4_0.int_0 > ((Class15)class13_0).struct4_0.int_0;
		}

		public override bool vmethod_76(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return vmethod_19().struct5_0.ulong_0 > ((Class15)class13_0).vmethod_19().struct5_0.ulong_0;
				}
				return vmethod_17().struct4_0.uint_0 > ((Class15)class13_0).struct4_0.uint_0;
			}
			if (!class13_0.method_2())
			{
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return vmethod_19().struct5_0.ulong_0 > ((Class17)class13_0).vmethod_19().struct5_0.ulong_0;
			}
			return vmethod_17().struct4_0.uint_0 > ((Class17)class13_0).vmethod_17().struct4_0.uint_0;
		}

		public override bool vmethod_77(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return vmethod_19().struct5_0.long_0 <= ((Class17)class13_0).vmethod_19().struct5_0.long_0;
					}
					return vmethod_17().struct4_0.int_0 <= ((Class17)class13_0).vmethod_17().struct4_0.int_0;
				}
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return vmethod_19().struct5_0.long_0 <= ((Class15)class13_0).vmethod_19().struct5_0.long_0;
			}
			return vmethod_17().struct4_0.int_0 <= ((Class15)class13_0).struct4_0.int_0;
		}

		public override bool vmethod_78(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return vmethod_19().struct5_0.ulong_0 <= ((Class17)class13_0).vmethod_19().struct5_0.ulong_0;
					}
					return vmethod_17().struct4_0.uint_0 <= ((Class17)class13_0).vmethod_17().struct4_0.uint_0;
				}
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return vmethod_19().struct5_0.ulong_0 <= ((Class15)class13_0).vmethod_19().struct5_0.ulong_0;
			}
			return vmethod_17().struct4_0.uint_0 <= ((Class15)class13_0).struct4_0.uint_0;
		}

		public override bool vmethod_79(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_1())
			{
				if (class13_0.method_2())
				{
					if (IntPtr.Size == 8)
					{
						return vmethod_19().struct5_0.long_0 < ((Class17)class13_0).vmethod_19().struct5_0.long_0;
					}
					return vmethod_17().struct4_0.int_0 < ((Class17)class13_0).vmethod_17().struct4_0.int_0;
				}
				throw new Exception1();
			}
			if (IntPtr.Size == 8)
			{
				return vmethod_19().struct5_0.long_0 < ((Class15)class13_0).vmethod_19().struct5_0.long_0;
			}
			return vmethod_17().struct4_0.int_0 < ((Class15)class13_0).struct4_0.int_0;
		}

		public override bool vmethod_80(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (class13_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return vmethod_19().struct5_0.ulong_0 < ((Class15)class13_0).vmethod_19().struct5_0.ulong_0;
				}
				return vmethod_17().struct4_0.uint_0 < ((Class15)class13_0).struct4_0.uint_0;
			}
			if (class13_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					return vmethod_19().struct5_0.ulong_0 < ((Class17)class13_0).vmethod_19().struct5_0.ulong_0;
				}
				return vmethod_17().struct4_0.uint_0 < ((Class17)class13_0).vmethod_17().struct4_0.uint_0;
			}
			throw new Exception1();
		}
	}

	public class Class18 : Class14
	{
		public double double_0;

		public Enum0 enum0_0;

		internal override void vmethod_10(Class13 class13_0)
		{
			double_0 = ((Class18)class13_0).double_0;
			enum0_0 = ((Class18)class13_0).enum0_0;
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_10(class13_0);
		}

		public Class18(double double_1)
		{
			enum3_0 = (Enum3)5;
			enum0_0 = (Enum0)10;
			double_0 = double_1;
		}

		public Class18(Class18 class18_0)
		{
			enum3_0 = class18_0.enum3_0;
			enum0_0 = class18_0.enum0_0;
			double_0 = class18_0.double_0;
		}

		public override Class14 vmethod_69()
		{
			return new Class18(this);
		}

		public Class18(double double_1, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)5;
			double_0 = double_1;
			enum0_0 = enum0_1;
		}

		public Class18(float float_0)
		{
			enum3_0 = (Enum3)5;
			double_0 = float_0;
			enum0_0 = (Enum0)9;
		}

		public Class18(float float_0, Enum0 enum0_1)
		{
			enum3_0 = (Enum3)5;
			double_0 = float_0;
			enum0_0 = enum0_1;
		}

		public override bool ucFrayBeGvG()
		{
			return double_0 == 0.0;
		}

		public override bool vmethod_11()
		{
			return !ucFrayBeGvG();
		}

		public override string ToString()
		{
			return double_0.ToString();
		}

		public override Class13 vmethod_12(Enum0 enum0_1)
		{
			return enum0_1 switch
			{
				(Enum0)1 => vmethod_13(), 
				(Enum0)2 => vmethod_14(), 
				(Enum0)3 => vmethod_15(), 
				(Enum0)4 => vmethod_16(), 
				(Enum0)5 => vmethod_17(), 
				(Enum0)6 => vmethod_18(), 
				(Enum0)7 => vmethod_19(), 
				(Enum0)8 => vmethod_20(), 
				(Enum0)9 => vmethod_44(), 
				(Enum0)10 => vmethod_45(), 
				(Enum0)11 => zrQrasfExAV(), 
				_ => throw new Exception(Enum4.TruncationNotSupported.ToString()), 
			};
		}

		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)double_0;
			}
			if (!(type_0 == typeof(double)))
			{
				if ((type_0 == null || type_0 == typeof(object)) && enum0_0 == (Enum0)9)
				{
					return (float)double_0;
				}
				return double_0;
			}
			return double_0;
		}

		public override Class15 zrQrasfExAV()
		{
			return new Class15(ucFrayBeGvG() ? 1 : 0);
		}

		internal override bool vmethod_7()
		{
			return vmethod_11();
		}

		public override Class15 vmethod_13()
		{
			return new Class15((sbyte)double_0, (Enum0)1);
		}

		public override Class15 vmethod_14()
		{
			return new Class15((uint)(byte)double_0, (Enum0)2);
		}

		public override Class15 vmethod_15()
		{
			return new Class15((short)double_0, (Enum0)3);
		}

		public override Class15 vmethod_16()
		{
			return new Class15((uint)(ushort)double_0, (Enum0)4);
		}

		public override Class15 vmethod_17()
		{
			return new Class15((int)double_0, (Enum0)5);
		}

		public override Class15 vmethod_18()
		{
			return new Class15((uint)double_0, (Enum0)6);
		}

		public override Class16 vmethod_19()
		{
			return new Class16((long)double_0, (Enum0)7);
		}

		public override Class16 vmethod_20()
		{
			return new Class16((ulong)double_0, (Enum0)8);
		}

		public override Class15 rIoranxyrKy()
		{
			return vmethod_13();
		}

		public override Class15 vmethod_21()
		{
			return vmethod_15();
		}

		public override Class15 vmethod_22()
		{
			return vmethod_17();
		}

		public override Class16 vmethod_23()
		{
			return vmethod_19();
		}

		public override Class15 vmethod_24()
		{
			return vmethod_14();
		}

		public override Class15 vmethod_25()
		{
			return vmethod_16();
		}

		public override Class15 vmethod_26()
		{
			return vmethod_18();
		}

		public override Class16 vmethod_27()
		{
			return vmethod_20();
		}

		public override Class15 vmethod_28()
		{
			return new Class15(checked((sbyte)double_0), (Enum0)1);
		}

		public override Class15 vmethod_29()
		{
			return new Class15(checked((sbyte)double_0), (Enum0)1);
		}

		public override Class15 vmethod_30()
		{
			return new Class15(checked((short)double_0), (Enum0)3);
		}

		public override Class15 vmethod_31()
		{
			return new Class15(checked((short)double_0), (Enum0)3);
		}

		public override Class15 vmethod_32()
		{
			return new Class15(checked((int)double_0), (Enum0)5);
		}

		public override Class15 vmethod_33()
		{
			return new Class15(checked((int)double_0), (Enum0)5);
		}

		public override Class16 vmethod_34()
		{
			return new Class16(checked((long)double_0), (Enum0)7);
		}

		public override Class16 vmethod_35()
		{
			return new Class16(checked((long)double_0), (Enum0)7);
		}

		public override Class15 vmethod_36()
		{
			return new Class15(checked((byte)double_0), (Enum0)2);
		}

		public override Class15 vmethod_37()
		{
			return new Class15(checked((byte)double_0), (Enum0)2);
		}

		public override Class15 vmethod_38()
		{
			return new Class15(checked((ushort)double_0), (Enum0)4);
		}

		public override Class15 vmethod_39()
		{
			return new Class15(checked((ushort)double_0), (Enum0)4);
		}

		public override Class15 vmethod_40()
		{
			return new Class15(checked((uint)double_0), (Enum0)6);
		}

		public override Class15 vmethod_41()
		{
			return new Class15(checked((uint)double_0), (Enum0)6);
		}

		public override Class16 vmethod_42()
		{
			return new Class16(checked((ulong)double_0), (Enum0)8);
		}

		public override Class16 vmethod_43()
		{
			return new Class16(checked((ulong)double_0), (Enum0)8);
		}

		public override Class18 vmethod_44()
		{
			return new Class18((float)double_0, (Enum0)9);
		}

		public override Class18 vmethod_45()
		{
			return new Class18(double_0, (Enum0)10);
		}

		public override Class18 vmethod_46()
		{
			return new Class18(double_0);
		}

		public override Class17 vmethod_47()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_23().struct5_0.long_0);
			}
			return new Class17(vmethod_22().struct4_0.int_0);
		}

		public override Class17 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_27().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_26().struct4_0.uint_0);
		}

		public override Class17 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_34().struct5_0.long_0);
			}
			return new Class17(vmethod_32().struct4_0.int_0);
		}

		public override Class17 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_42().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_40().struct4_0.uint_0);
		}

		public override Class17 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_35().struct5_0.long_0);
			}
			return new Class17(vmethod_33().struct4_0.int_0);
		}

		public override Class17 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class17(vmethod_43().struct5_0.ulong_0);
			}
			return new Class17((ulong)vmethod_41().struct4_0.uint_0);
		}

		public override Class13 vmethod_53()
		{
			if (enum0_0 == (Enum0)9)
			{
				return new Class18((float)(0.0 - double_0));
			}
			return new Class18(0.0 - double_0);
		}

		public override Class13 Add(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 + ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_54(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 + ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_55(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 + ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_56(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 - ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_57(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 - ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_58(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 - ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_59(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4() || !class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 * ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_60(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 * ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_61(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 * ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_62(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 / ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_63(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 / ((Class18)class13_0).double_0);
		}

		public override Class13 vPxrkrTinu9(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 % ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_64(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return new Class18(double_0 % ((Class18)class13_0).double_0);
		}

		public override Class13 vmethod_65(Class13 class13_0)
		{
			throw new Exception1();
		}

		public override Class13 vmethod_66(Class13 class13_0)
		{
			throw new Exception1();
		}

		public override Class13 vmethod_67()
		{
			throw new Exception1();
		}

		public override Class13 vmethod_68(Class13 class13_0)
		{
			throw new Exception1();
		}

		public override Class13 vmethod_70(Class13 class13_0)
		{
			throw new Exception1();
		}

		public override Class13 vmethod_71(Class13 class13_0)
		{
			throw new Exception1();
		}

		public override Class13 vmethod_72(Class13 class13_0)
		{
			throw new Exception1();
		}

		internal override Class13 vmethod_8()
		{
			return this;
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (class13_0.method_0())
			{
				return false;
			}
			if (class13_0.vmethod_0())
			{
				return ((Class19)class13_0).vmethod_5(this);
			}
			Class13 @class = class13_0.vmethod_8();
			if (!@class.method_4())
			{
				return false;
			}
			return double_0 == ((Class18)@class).double_0;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (!class13_0.method_0())
			{
				if (!class13_0.vmethod_0())
				{
					Class13 @class = class13_0.vmethod_8();
					if (@class.method_4())
					{
						return double_0 != ((Class18)@class).double_0;
					}
					return false;
				}
				return ((Class19)class13_0).vmethod_6(this);
			}
			return false;
		}

		public override bool vmethod_73(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 >= ((Class18)class13_0).double_0;
		}

		public override bool vmethod_74(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 >= ((Class18)class13_0).double_0;
		}

		public override bool vmethod_75(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 > ((Class18)class13_0).double_0;
		}

		public override bool vmethod_76(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 > ((Class18)class13_0).double_0;
		}

		public override bool vmethod_77(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 <= ((Class18)class13_0).double_0;
		}

		public override bool vmethod_78(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 <= ((Class18)class13_0).double_0;
		}

		public override bool vmethod_79(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 < ((Class18)class13_0).double_0;
		}

		public override bool vmethod_80(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				class13_0 = class13_0.vmethod_8();
			}
			if (!class13_0.method_4())
			{
				throw new Exception1();
			}
			return double_0 < ((Class18)class13_0).double_0;
		}
	}

	internal enum Enum0 : byte
	{

	}

	internal enum Enum1 : byte
	{

	}

	public class Exception0 : Exception
	{
		public Exception0(string string_0)
			: base(string_0)
		{
		}
	}

	public class Exception1 : Exception
	{
		public Exception1()
		{
		}

		public Exception1(string string_0)
			: base(string_0)
		{
		}
	}

	internal class Class27
	{
		internal Enum2 enum2_0 = (Enum2)126;

		internal object object_0;

		public override string ToString()
		{
			object obj = enum2_0;
			if (object_0 == null)
			{
				return obj.ToString();
			}
			return obj.ToString() + 'H' + object_0.ToString();
		}
	}

	internal abstract class Class19 : Class13
	{
		public Class19()
		{
		}

		internal override bool vmethod_0()
		{
			return true;
		}

		internal abstract IntPtr vmethod_11();

		internal abstract void vmethod_12(Class13 class13_0);

		internal override bool vmethod_1()
		{
			return true;
		}
	}

	internal class Class20 : Class19
	{
		public Class35 class35_0;

		internal int fyXjcDhuo7;

		public Class20(int int_0, Class35 class35_1)
		{
			class35_0 = class35_1;
			fyXjcDhuo7 = int_0;
			enum3_0 = (Enum3)7;
		}

		internal override void vmethod_10(Class13 class13_0)
		{
			if (!(class13_0 is Class20))
			{
				Class29 @class = class35_0.class32_0.list_1[fyXjcDhuo7];
				if (class13_0 is Class19 && (int)(@class.enum0_0 & (Enum0)226) > 0)
				{
					Class19 class2 = class13_0 as Class19;
					Class13 class13_ = class2.vmethod_8();
					vmethod_12(class13_);
				}
				else
				{
					vmethod_12(class13_0);
				}
			}
			else
			{
				class35_0 = ((Class20)class13_0).class35_0;
				fyXjcDhuo7 = ((Class20)class13_0).fyXjcDhuo7;
			}
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_12(class13_0);
		}

		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		internal override void vmethod_12(Class13 class13_0)
		{
			class35_0.class13_1[fyXjcDhuo7] = class13_0;
		}

		internal override object vmethod_4(Type type_0)
		{
			if (class35_0.class13_1[fyXjcDhuo7] != null)
			{
				return vmethod_8().vmethod_4(type_0);
			}
			return null;
		}

		internal override Class13 vmethod_8()
		{
			if (class35_0.class13_1[fyXjcDhuo7] == null)
			{
				return new Class25(null);
			}
			return class35_0.class13_1[fyXjcDhuo7].vmethod_8();
		}

		internal override bool vmethod_9()
		{
			return vmethod_8().vmethod_9();
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (!class13_0.vmethod_0())
			{
				return false;
			}
			if (class13_0 is Class20)
			{
				Class20 @class = (Class20)class13_0;
				if (@class.fyXjcDhuo7 == fyXjcDhuo7)
				{
					return true;
				}
				return false;
			}
			return false;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				if (class13_0 is Class20)
				{
					Class20 @class = (Class20)class13_0;
					if (@class.fyXjcDhuo7 != fyXjcDhuo7)
					{
						return true;
					}
					return false;
				}
				return true;
			}
			return true;
		}

		internal override bool vmethod_7()
		{
			return vmethod_8().vmethod_7();
		}
	}

	internal class Class21 : Class19
	{
		public Array array_0;

		internal int int_0;

		public Class21(int int_1, Array array_1)
		{
			array_0 = array_1;
			int_0 = int_1;
			enum3_0 = (Enum3)7;
		}

		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		internal override void vmethod_10(Class13 class13_0)
		{
			if (class13_0 is Class21)
			{
				array_0 = ((Class21)class13_0).array_0;
				int_0 = ((Class21)class13_0).int_0;
			}
			else
			{
				vmethod_12(class13_0);
			}
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_12(class13_0);
		}

		internal override void vmethod_12(Class13 class13_0)
		{
			array_0.SetValue(class13_0.vmethod_4(null), int_0);
		}

		internal override object vmethod_4(Type type_0)
		{
			return vmethod_8().vmethod_4(type_0);
		}

		internal override Class13 vmethod_8()
		{
			Type elementType = array_0.GetType().GetElementType();
			return Class13.smethod_1(elementType, array_0.GetValue(int_0));
		}

		internal override bool vmethod_9()
		{
			return vmethod_8().vmethod_9();
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				if (class13_0 is Class21)
				{
					Class21 @class = (Class21)class13_0;
					if (@class.int_0 != int_0)
					{
						return false;
					}
					if (@class.array_0 != array_0)
					{
						return false;
					}
					return true;
				}
				return false;
			}
			return false;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (!class13_0.vmethod_0())
			{
				return true;
			}
			if (!(class13_0 is Class21))
			{
				return true;
			}
			Class21 @class = (Class21)class13_0;
			if (@class.int_0 != int_0)
			{
				return true;
			}
			if (@class.array_0 != array_0)
			{
				return true;
			}
			return false;
		}

		internal override bool vmethod_7()
		{
			return vmethod_8().vmethod_7();
		}
	}

	internal class Class22 : Class19
	{
		internal FieldInfo fieldInfo_0;

		internal object object_0;

		public Class22(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
			enum3_0 = (Enum3)7;
		}

		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		internal override void vmethod_12(Class13 class13_0)
		{
			if (object_0 != null && object_0 is Class13)
			{
				fieldInfo_0.SetValue(((Class13)object_0).vmethod_4(null), class13_0.vmethod_4(null));
			}
			else
			{
				fieldInfo_0.SetValue(object_0, class13_0.vmethod_4(null));
			}
		}

		internal override void vmethod_10(Class13 class13_0)
		{
			if (!(class13_0 is Class22))
			{
				vmethod_12(class13_0);
				return;
			}
			fieldInfo_0 = ((Class22)class13_0).fieldInfo_0;
			object_0 = ((Class22)class13_0).object_0;
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_12(class13_0);
		}

		internal override object vmethod_4(Type type_0)
		{
			return vmethod_8().vmethod_4(type_0);
		}

		internal override Class13 vmethod_8()
		{
			if (object_0 != null && object_0 is Class13)
			{
				return Class13.smethod_1(fieldInfo_0.FieldType, fieldInfo_0.GetValue(((Class13)object_0).vmethod_4(null)));
			}
			return Class13.smethod_1(fieldInfo_0.FieldType, fieldInfo_0.GetValue(object_0));
		}

		internal override bool vmethod_9()
		{
			return vmethod_8().vmethod_9();
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				if (!(class13_0 is Class22))
				{
					return false;
				}
				Class22 @class = (Class22)class13_0;
				if (@class.fieldInfo_0 != fieldInfo_0)
				{
					return false;
				}
				if (@class.object_0 != object_0)
				{
					return false;
				}
				return true;
			}
			return false;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				if (class13_0 is Class22)
				{
					Class22 @class = (Class22)class13_0;
					if (!(@class.fieldInfo_0 != fieldInfo_0))
					{
						if (@class.object_0 != object_0)
						{
							return true;
						}
						return false;
					}
					return true;
				}
				return true;
			}
			return true;
		}

		internal override bool vmethod_7()
		{
			return vmethod_8().vmethod_7();
		}
	}

	internal class Class23 : Class19
	{
		public Class35 class35_0;

		internal int int_0;

		public Class23(int int_1, Class35 class35_1)
		{
			class35_0 = class35_1;
			int_0 = int_1;
			enum3_0 = (Enum3)7;
		}

		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		internal override void vmethod_10(Class13 class13_0)
		{
			if (!(class13_0 is Class23))
			{
				vmethod_12(class13_0);
				return;
			}
			class35_0 = ((Class23)class13_0).class35_0;
			int_0 = ((Class23)class13_0).int_0;
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_12(class13_0);
		}

		internal override void vmethod_12(Class13 class13_0)
		{
			class35_0.class13_0[int_0] = class13_0;
		}

		internal override object vmethod_4(Type type_0)
		{
			if (class35_0.class13_0[int_0] != null)
			{
				return vmethod_8().vmethod_4(type_0);
			}
			return null;
		}

		internal override Class13 vmethod_8()
		{
			if (class35_0.class13_0[int_0] == null)
			{
				return new Class25(null);
			}
			return class35_0.class13_0[int_0].vmethod_8();
		}

		internal override bool vmethod_9()
		{
			return vmethod_8().vmethod_9();
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				if (class13_0 is Class23)
				{
					Class23 @class = (Class23)class13_0;
					return @class.int_0 == int_0;
				}
				return false;
			}
			return false;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				if (class13_0 is Class23)
				{
					Class23 @class = (Class23)class13_0;
					return @class.int_0 != int_0;
				}
				return true;
			}
			return true;
		}

		internal override bool vmethod_7()
		{
			return vmethod_8().vmethod_7();
		}
	}

	internal class Class24 : Class19
	{
		public Class13 class13_0;

		public Type type_0;

		public Class24(Class13 class13_1, Type type_1)
		{
			class13_0 = class13_1;
			type_0 = type_1;
			enum3_0 = (Enum3)7;
		}

		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		internal override void vmethod_10(Class13 class13_1)
		{
			if (!(class13_1 is Class24))
			{
				class13_0.vmethod_10(class13_1);
				return;
			}
			type_0 = ((Class24)class13_1).type_0;
			class13_0 = ((Class24)class13_1).class13_0;
		}

		internal override void vmethod_2(Class13 class13_1)
		{
			vmethod_12(class13_1);
		}

		internal override void vmethod_12(Class13 class13_1)
		{
			class13_0 = class13_1;
		}

		internal override object vmethod_4(Type type_1)
		{
			if (class13_0 == null)
			{
				return new Class25(null);
			}
			if (!(type_1 == null) && !(type_1 == typeof(object)))
			{
				return class13_0.vmethod_4(type_1);
			}
			return class13_0.vmethod_4(type_0);
		}

		internal override Class13 vmethod_8()
		{
			if (class13_0 != null)
			{
				return class13_0.vmethod_8();
			}
			return new Class25(null);
		}

		internal override bool vmethod_9()
		{
			return vmethod_8().vmethod_9();
		}

		internal override bool vmethod_5(Class13 class13_1)
		{
			if (class13_1.vmethod_0())
			{
				if (class13_1 is Class24)
				{
					Class24 @class = (Class24)class13_1;
					if (!(@class.type_0 != type_0))
					{
						if (class13_0 == null)
						{
							if (@class.class13_0 == null)
							{
								return true;
							}
							return false;
						}
						return class13_0.vmethod_5(@class.class13_0);
					}
					return false;
				}
				return false;
			}
			return false;
		}

		internal override bool vmethod_6(Class13 class13_1)
		{
			if (class13_1.vmethod_0())
			{
				if (class13_1 is Class24)
				{
					Class24 @class = (Class24)class13_1;
					if (@class.type_0 != type_0)
					{
						return true;
					}
					if (class13_0 == null)
					{
						if (@class.class13_0 == null)
						{
							return false;
						}
						return true;
					}
					return class13_0.vmethod_6(@class.class13_0);
				}
				return true;
			}
			return true;
		}

		internal override bool vmethod_7()
		{
			return vmethod_8().vmethod_7();
		}
	}

	internal class Class28
	{
		public int int_0;

		public bool bool_0;

		public Enum0 enum0_0;
	}

	internal class Class29
	{
		public int int_0;

		public Enum0 enum0_0;

		public bool bool_0;

		public Type type_0 = typeof(object);
	}

	internal class Class30
	{
		public int int_0;

		public int int_1;

		public Class31 class31_0;
	}

	internal class Class31
	{
		public int int_0;

		public int int_1;

		public byte byte_0;

		public Type type_0;

		public int int_2;

		public int int_3;
	}

	internal class Class32
	{
		internal object object_0;

		internal List<Class27> list_0;

		internal Class28[] class28_0;

		internal List<Class29> list_1;

		internal List<Class30> list_2;
	}

	public class Class33
	{
		internal object object_0;

		internal int int_0;

		public Class33(FieldInfo fieldInfo_0, int int_1)
		{
			object_0 = fieldInfo_0;
			int_0 = int_1;
		}
	}

	public class Class34
	{
		public List<Class33> list_0 = new List<Class33>();

		public MethodBase methodBase_0;

		public Class34(MethodBase methodBase_1, List<Class33> list_1)
		{
			list_0 = list_1;
			methodBase_0 = methodBase_1;
		}

		public Class34(MethodBase methodBase_1, Class33[] class33_0)
		{
			list_0.AddRange(class33_0);
		}

		public override bool Equals(object obj)
		{
			Class34 @class = obj as Class34;
			if (obj == null)
			{
				return false;
			}
			if (methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			int num = 0;
			while (true)
			{
				if (num < list_0.Count)
				{
					if ((FieldInfo)list_0[num].object_0 != (FieldInfo)@class.list_0[num].object_0)
					{
						break;
					}
					if (list_0[num].int_0 == @class.list_0[num].int_0)
					{
						num++;
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}

		public override int GetHashCode()
		{
			int num = methodBase_0.GetHashCode();
			foreach (Class33 item in list_0)
			{
				int num2 = item.object_0.GetHashCode() + item.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		public Class33 method_0(int int_0)
		{
			foreach (Class33 item in list_0)
			{
				if (item.int_0 == int_0)
				{
					return item;
				}
			}
			return null;
		}

		public bool method_1(int int_0)
		{
			foreach (Class33 item in list_0)
			{
				if (item.int_0 == int_0)
				{
					return true;
				}
			}
			return false;
		}
	}

	public delegate object Delegate5(object target, object[] paramters);

	public delegate object Delegate6(object target);

	public delegate void Delegate7(IntPtr a, byte b, int c);

	public delegate void Delegate8(IntPtr s, IntPtr t, uint c);

	internal class Class35
	{
		internal Class32 class32_0;

		internal Class13[] class13_0 = new Class13[0];

		internal Class13[] class13_1 = new Class13[0];

		internal Class36 class36_0 = new Class36();

		internal Class13 class13_2;

		internal Exception exception_0;

		internal List<IntPtr> list_0;

		public int int_0;

		public int int_1;

		public int int_2 = -1;

		public object GfqOmusece;

		public bool bool_0;

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public static Dictionary<Type, int> dictionary_0;

		public static Dictionary<object, Class13> dictionary_1;

		public static Dictionary<MethodBase, Delegate5> dictionary_2;

		public static Dictionary<MethodBase, Delegate5> dictionary_3;

		public static Dictionary<Class34, Delegate5> dictionary_4;

		public static Dictionary<Class34, Delegate5> dictionary_5;

		public static Dictionary<Class34, Delegate5> dictionary_6;

		public static Dictionary<Type, Delegate6> dictionary_7;

		public static Delegate7 delegate7_0;

		public static Delegate8 delegate8_0;

		[CompilerGenerated]
		public static Comparison<Class30> comparison_0;

		internal void method_0()
		{
			bool bool_ = false;
			method_2(ref bool_);
		}

		internal void method_1()
		{
			class36_0.method_1();
			class13_1 = null;
			if (list_0 == null)
			{
				return;
			}
			foreach (IntPtr item in list_0)
			{
				try
				{
					Marshal.FreeHGlobal(item);
				}
				catch
				{
				}
			}
			list_0.Clear();
			list_0 = null;
		}

		internal void method_2(ref bool bool_4)
		{
			while (true)
			{
				if (int_0 > -2)
				{
					if (bool_0)
					{
						bool_0 = false;
						int num = int_1;
						int num2 = int_0;
						bLcJkaGgy9(int_1, int_0);
						int_0 = num2;
						int_1 = num;
					}
					if (bool_2)
					{
						break;
					}
					if (!bool_1)
					{
						int_1 = int_0;
						Class27 @class = class32_0.list_0[int_0];
						GfqOmusece = @class.object_0;
						try
						{
							method_6(@class);
						}
						catch (Exception ex)
						{
							Exception ex2 = (exception_0 = ex);
							bool_4 = true;
							class36_0.method_1();
							int int_ = int_1;
							Class30 class2 = method_4(int_, ex2);
							List<Class30> list = method_5(int_, bool_4: false);
							List<Class30> list2 = new List<Class30>();
							if (class2 != null)
							{
								list2.Add(class2);
							}
							if (list != null && list.Count > 0)
							{
								list2.AddRange(list);
							}
							Class30 class3 = null;
							foreach (Class30 item in list2)
							{
								if (item.class31_0.int_3 != 0)
								{
									class36_0.method_2(new Class25(ex2));
									int_1 = item.class31_0.int_2;
									int_0 = int_1;
									method_0();
									if (bool_3)
									{
										bool_3 = false;
										class3 = item;
										break;
									}
									continue;
								}
								class3 = item;
								break;
							}
							if (class3 == null)
							{
								throw ex2;
							}
							int_2 = class3.class31_0.int_0;
							method_3(int_, class3.class31_0.int_0);
							if (int_2 >= 0)
							{
								class36_0.method_2(new Class25(ex2));
								int_1 = int_2;
								int_0 = int_1;
								int_2 = -1;
								method_0();
							}
							return;
						}
						int_0++;
						continue;
					}
					bool_1 = false;
					return;
				}
				class36_0.method_1();
				return;
			}
			bool_2 = false;
		}

		internal void method_3(int int_3, int int_4)
		{
			if (class32_0.list_2 == null)
			{
				return;
			}
			foreach (Class30 item in class32_0.list_2)
			{
				if ((item.class31_0.int_3 == 4 || item.class31_0.int_3 == 2) && item.class31_0.int_0 >= int_3 && item.class31_0.int_1 <= int_4)
				{
					int_1 = item.class31_0.int_0;
					int_0 = int_1;
					bool bool_ = false;
					method_2(ref bool_);
					if (bool_)
					{
						break;
					}
				}
			}
		}

		internal void bLcJkaGgy9(int int_3, int int_4)
		{
			if (class32_0.list_2 == null)
			{
				return;
			}
			foreach (Class30 item in class32_0.list_2)
			{
				if (item.class31_0.int_3 == 2 && item.class31_0.int_0 >= int_3 && item.class31_0.int_1 <= int_4)
				{
					int_1 = item.class31_0.int_0;
					int_0 = int_1;
					bool bool_ = false;
					method_2(ref bool_);
					if (bool_)
					{
						break;
					}
				}
			}
		}

		internal Class30 method_4(int int_3, Exception exception_1)
		{
			Class30 @class = null;
			if (class32_0.list_2 != null)
			{
				foreach (Class30 item in class32_0.list_2)
				{
					if (item.class31_0.int_3 == 0 && (item.class31_0.type_0 == exception_1.GetType() || (item.class31_0.type_0 != null && (item.class31_0.type_0.FullName == exception_1.GetType().FullName || item.class31_0.type_0.FullName == typeof(object).FullName || item.class31_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= item.int_0 && int_3 <= item.int_1)
					{
						if (@class == null)
						{
							@class = item;
						}
						else if (item.class31_0.int_0 < @class.class31_0.int_0)
						{
							@class = item;
						}
					}
				}
			}
			return @class;
		}

		internal List<Class30> method_5(int int_3, bool bool_4)
		{
			if (class32_0.list_2 == null)
			{
				return null;
			}
			List<Class30> list = new List<Class30>();
			foreach (Class30 item in class32_0.list_2)
			{
				if ((item.class31_0.int_3 & 1) == 1 && int_3 >= item.int_0 && int_3 <= item.int_1)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		public unsafe void method_6(Class27 class27_0)
		{
			switch (class27_0.enum2_0)
			{
			case (Enum2)0:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.Add(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)1:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class2 != null && class4 != null)
				{
					class36_0.method_2(class2.vmethod_66(class4));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)2:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_71(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)3:
				int_0 = (int)GfqOmusece - 1;
				bool_0 = true;
				break;
			case (Enum2)4:
			{
				bool flag;
				if (flag = !class36_0.method_4().vmethod_7())
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)5:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_67());
				break;
			}
			case (Enum2)7:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_62(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)8:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_49());
				break;
			}
			case (Enum2)9:
			{
				Class13 @class = class36_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class14)@class).vmethod_44();
				}
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)10:
			{
				Class13 @class = class36_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class14)@class).rIoranxyrKy();
				}
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)11:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_47());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					if (IntPtr.Size == 8)
					{
						long long_ = *(long*)(void*)intPtr;
						class36_0.method_2(new Class17(long_, (Enum0)12));
					}
					else
					{
						int metadataToken = *(int*)(void*)intPtr;
						class36_0.method_2(new Class17(metadataToken, (Enum0)12));
					}
					break;
				}
				throw new Exception1();
			}
			case (Enum2)12:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_45());
				break;
			}
			case (Enum2)13:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(type_, value));
				break;
			}
			case (Enum2)14:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_78(@class))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)15:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_52());
				break;
			}
			case (Enum2)17:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				FieldInfo fieldInfo = module.ResolveField(metadataToken);
				class36_0.method_2(Class13.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				break;
			}
			case (Enum2)18:
			{
				Class13 @class = class36_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class14)@class).vmethod_47();
				}
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)20:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_51());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)21:
				class36_0.method_2(class13_0[(int)GfqOmusece]);
				break;
			case (Enum2)22:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_42());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)23:
				class36_0.method_2(new Class18((double)GfqOmusece));
				break;
			case (Enum2)24:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(float), value));
				break;
			}
			case (Enum2)25:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_73(@class))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)26:
			{
				Class13 @class = class36_0.method_4();
				if (!@class.vmethod_0())
				{
					throw new Exception1();
				}
				object value = @class.vmethod_4(null);
				@class = ((value == null) ? new Class25(null) : Class13.smethod_1(value.GetType(), value));
				class36_0.method_2(@class);
				break;
			}
			case (Enum2)27:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_22());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class15(*(int*)(void*)intPtr, (Enum0)5));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)28:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_58(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)29:
				class36_0.method_2(new Class16((long)GfqOmusece));
				break;
			case (Enum2)30:
			{
				Class13 @class = class36_0.method_4();
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)32:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (!(flag = class2.vmethod_79(@class)))
				{
					class36_0.method_2(new Class15(0));
				}
				else
				{
					class36_0.method_2(new Class15(1));
				}
				break;
			}
			case (Enum2)33:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_47());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)34:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_26());
				break;
			}
			case (Enum2)35:
				throw exception_0;
			case (Enum2)36:
			{
				Class14 class2 = smethod_1(class36_0.method_3());
				if (class2 != null)
				{
					if (class2 is Class18 class10)
					{
						if (double.IsNaN(class10.double_0))
						{
							throw new OverflowException(Enum4.NAN.ToString());
						}
						if (double.IsInfinity(class10.double_0))
						{
							throw new OverflowException(Enum4.InfinityValue.ToString());
						}
					}
					break;
				}
				throw new ArithmeticException(Enum4.const_0.ToString());
			}
			case (Enum2)37:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(double), value));
				break;
			}
			case (Enum2)38:
				class36_0.method_2(new Class20((int)GfqOmusece, this));
				break;
			case (Enum2)39:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.rIoranxyrKy());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)40:
				class36_0.method_2(new Class18((float)GfqOmusece));
				break;
			case (Enum2)41:
			{
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType((int)GfqOmusece);
				Class13 @class = class36_0.method_4();
				object value = @class.vmethod_4(type_);
				if (value == null)
				{
					value = Activator.CreateInstance(type_);
				}
				class36_0.method_2(new Class25(Class13.smethod_1(type_, smethod_9(value))));
				break;
			}
			case (Enum2)42:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_31());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)43:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(IntPtr), value));
				break;
			}
			case (Enum2)44:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_79(@class))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)45:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_39());
				break;
			}
			case (Enum2)46:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_59(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)48:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				module.ResolveType(metadataToken);
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				class36_0.method_2(new Class21(class2.vmethod_17().struct4_0.int_0, array));
				break;
			}
			case (Enum2)49:
			{
				Class13 @class = class36_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class14)@class).vmethod_22();
				}
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)50:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_55(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)51:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				FieldInfo fieldInfo = module.ResolveField(metadataToken);
				class36_0.method_2(new Class22(fieldInfo, null));
				break;
			}
			case (Enum2)52:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_56(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)54:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.rIoranxyrKy());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class15(*(sbyte*)(void*)intPtr, (Enum0)1));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)47:
			case (Enum2)55:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				Class13 @class = class36_0.method_4();
				object value = @class.vmethod_4(type_);
				if (value == null)
				{
					if (!type_.IsValueType)
					{
						@class = new Class25(null);
					}
					else
					{
						value = Activator.CreateInstance(type_);
						@class = Class13.smethod_1(type_, value);
					}
				}
				else
				{
					if (type_.IsValueType)
					{
						value = smethod_9(value);
					}
					@class = Class13.smethod_1(type_, value);
				}
				if (!(class36_0.method_4() is Class19 class11))
				{
					throw new Exception1();
				}
				class11.vmethod_10(@class);
				break;
			}
			case (Enum2)57:
			{
				object value = class36_0.method_4().vmethod_4(null);
				Class13 @class = null;
				if (!dictionary_1.TryGetValue(value, out @class))
				{
					class36_0.method_2(new Class25(null));
				}
				else
				{
					class36_0.method_2(@class);
				}
				break;
			}
			case (Enum2)59:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(byte), value));
				break;
			}
			case (Enum2)60:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_77(@class))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)62:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_24());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)63:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				Type type_ = array.GetType().GetElementType();
				class36_0.method_2(Class13.smethod_1(type_, value));
				break;
			}
			case (Enum2)65:
			{
				Class13 @class = smethod_6(class36_0.method_4());
				Class13 class3 = smethod_6(class36_0.method_4());
				bool flag;
				if (!(flag = @class.vmethod_5(class3)))
				{
					class36_0.method_2(new Class15(0));
				}
				else
				{
					class36_0.method_2(new Class15(1));
				}
				break;
			}
			case (Enum2)66:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_33());
				break;
			}
			case (Enum2)67:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				array.SetValue(@class.vmethod_4(type_), class2.vmethod_17().struct4_0.int_0);
				break;
			}
			case (Enum2)68:
				bool_3 = (bool)class36_0.method_4().vmethod_4(typeof(bool));
				bool_1 = true;
				break;
			case (Enum2)69:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_25());
				break;
			}
			case (Enum2)70:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				ConstructorInfo constructorInfo = (ConstructorInfo)module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array3 = new object[parameters.Length];
				Class13[] array4 = new Class13[parameters.Length];
				List<Class33> list = null;
				Class34 class7 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class13 @class = class36_0.method_4();
					ParameterInfo parameterInfo = parameters[parameters.Length - 1 - i];
					Type type_ = parameterInfo.ParameterType;
					object value = null;
					bool flag = false;
					if (type_.IsByRef && @class is Class22 class8)
					{
						if (list == null)
						{
							list = new List<Class33>();
						}
						list.Add(new Class33(class8.fieldInfo_0, i));
						value = class8.object_0;
						if (!(value is Class13))
						{
							flag = true;
						}
						else
						{
							@class = value as Class13;
						}
					}
					if (!flag)
					{
						if (@class != null)
						{
							value = @class.vmethod_4(type_);
						}
						if (value == null)
						{
							if (type_.IsByRef)
							{
								type_ = type_.GetElementType();
							}
							if (type_.IsValueType)
							{
								value = Activator.CreateInstance(type_);
								if (@class is Class20)
								{
									((Class19)@class).vmethod_12(Class13.smethod_1(type_, value));
								}
							}
						}
					}
					array4[array3.Length - 1 - i] = @class;
					array3[array3.Length - 1 - i] = value;
				}
				Delegate5 @delegate = null;
				if (list != null)
				{
					class7 = new Class34(constructorInfo, list);
					@delegate = smethod_4(constructorInfo, bool_4: true, class7);
				}
				object obj = null;
				obj = ((@delegate == null) ? constructorInfo.Invoke(array3) : @delegate(null, array3));
				for (int j = 0; j < parameters.Length; j++)
				{
					if (!parameters[j].ParameterType.IsByRef || (class7 != null && class7.method_1(j)))
					{
						continue;
					}
					if (!array4[j].method_2())
					{
						if (array4[j] is Class20)
						{
							array4[j].vmethod_10(Class13.smethod_1(parameters[j].ParameterType.GetElementType(), array3[j]));
						}
						else
						{
							array4[j].vmethod_10(Class13.smethod_1(parameters[j].ParameterType, array3[j]));
						}
					}
					else
					{
						((Class17)array4[j]).method_6(Class13.smethod_1(parameters[j].ParameterType, array3[j]));
					}
				}
				class36_0.method_2(Class13.smethod_1(constructorInfo.DeclaringType, obj));
				break;
			}
			case (Enum2)71:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_80(@class))
				{
					class36_0.method_2(new Class15(1));
				}
				else
				{
					class36_0.method_2(new Class15(0));
				}
				break;
			}
			case (Enum2)6:
			case (Enum2)72:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				class36_0.method_2(new Class17(module.ResolveMethod(metadataToken).MethodHandle.GetFunctionPointer()));
				break;
			}
			case (Enum2)75:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				FieldInfo fieldInfo = module.ResolveField(metadataToken);
				object value = class36_0.method_4().vmethod_4(fieldInfo.FieldType);
				Class13 @class = class36_0.method_4();
				object obj = @class.vmethod_4(null);
				if (obj == null)
				{
					Type type_ = fieldInfo.DeclaringType;
					if (type_.IsByRef)
					{
						type_ = type_.GetElementType();
					}
					if (!type_.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj = Activator.CreateInstance(type_);
					if (@class is Class20)
					{
						((Class19)@class).vmethod_12(Class13.smethod_1(type_, obj));
					}
				}
				fieldInfo.SetValue(obj, value);
				break;
			}
			case (Enum2)76:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = (Class14)class36_0.method_4();
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_57(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)77:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_54(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)78:
			{
				int metadataToken = (int)GfqOmusece;
				class13_1[metadataToken] = method_7(class36_0.method_4(), class32_0.list_1[metadataToken].enum0_0, class32_0.list_1[metadataToken].bool_0);
				break;
			}
			case (Enum2)79:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(int), value));
				break;
			}
			case (Enum2)80:
				class36_0.method_2(new Class25(null));
				break;
			case (Enum2)81:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_23());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)82:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_26());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class15(*(uint*)(void*)intPtr, (Enum0)6));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)83:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(short), value));
				break;
			}
			case (Enum2)84:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				object value = null;
				try
				{
					value = module.ResolveType(metadataToken);
				}
				catch
				{
					try
					{
						value = module.ResolveMethod(metadataToken);
					}
					catch
					{
						try
						{
							value = module.ResolveField(metadataToken);
							goto end_IL_195e;
						}
						catch
						{
							value = module.ResolveMember(metadataToken);
							goto end_IL_195e;
						}
						end_IL_195e:;
					}
				}
				class36_0.method_2(new Class25(value));
				break;
			}
			case (Enum2)85:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(sbyte), value));
				break;
			}
			case (Enum2)86:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				if (class36_0.method_4() is Class19 class9)
				{
					object value = class9.vmethod_4(type_);
					Class13 @class;
					if (value != null)
					{
						if (type_.IsValueType)
						{
							value = smethod_9(value);
						}
						@class = Class13.smethod_1(type_, value);
					}
					else if (!type_.IsValueType)
					{
						@class = new Class25(null);
					}
					else
					{
						value = Activator.CreateInstance(type_);
						@class = Class13.smethod_1(type_, value);
					}
					class36_0.method_2(@class);
					break;
				}
				throw new Exception1();
			}
			case (Enum2)87:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_75(@class))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)88:
			{
				Class14 class2 = class36_0.method_4() as Class14;
				int metadataToken = class2.vmethod_17().struct4_0.int_0;
				IntPtr intPtr = Marshal.AllocHGlobal(metadataToken);
				if (list_0 == null)
				{
					list_0 = new List<IntPtr>();
				}
				list_0.Add(intPtr);
				class36_0.method_2(new Class17(intPtr));
				break;
			}
			case (Enum2)89:
			{
				Class13 @class = class36_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class14)@class).vmethod_23();
				}
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)91:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_21());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class15(*(short*)(void*)intPtr, (Enum0)3));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)92:
			{
				Class13 @class = class13_1[(int)GfqOmusece];
				class36_0.method_2(@class);
				break;
			}
			case (Enum2)93:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_72(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)94:
			{
				int metadataToken = (int)GfqOmusece;
				if (((MethodBase)class32_0.object_0).IsStatic)
				{
					class13_0[metadataToken] = method_7(class36_0.method_4(), class32_0.class28_0[metadataToken].enum0_0);
				}
				else
				{
					class13_0[metadataToken] = method_7(class36_0.method_4(), class32_0.class28_0[metadataToken - 1].enum0_0);
				}
				break;
			}
			case (Enum2)95:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_74(@class))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)96:
			{
				Class14 class2 = class36_0.method_4() as Class14;
				IntPtr intPtr = smethod_8(class36_0.method_4());
				IntPtr intPtr2 = smethod_8(class36_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint uint_ = class2.vmethod_18().struct4_0.uint_0;
					smethod_11(intPtr2, intPtr, uint_);
				}
				break;
			}
			case (Enum2)97:
				class36_0.method_2(((Class14)class36_0.method_4()).vmethod_53());
				break;
			case (Enum2)98:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				FieldInfo fieldInfo = module.ResolveField(metadataToken);
				Class13 @class = class36_0.method_4();
				@class.vmethod_8();
				object value = @class.vmethod_4(null);
				class36_0.method_2(new Class22(fieldInfo, value));
				break;
			}
			case (Enum2)99:
			{
				int[] array2 = (int[])GfqOmusece;
				Class14 class2 = smethod_1(class36_0.method_4());
				long long_ = class2.vmethod_19().struct5_0.long_0;
				if ((long_ < 0L || class2.method_4()) && IntPtr.Size == 4)
				{
					long_ = (int)long_;
				}
				if (class2.method_1())
				{
					Class15 class6 = (Class15)class2;
					if (class6.enum0_0 == (Enum0)6)
					{
						long_ = class6.struct4_0.uint_0;
					}
				}
				if (long_ < array2.Length && long_ >= 0L)
				{
					int_0 = array2[long_] - 1;
				}
				break;
			}
			case (Enum2)100:
			{
				Class13 @class = class36_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class14)@class).vmethod_45();
				}
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)102:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(ushort), value));
				break;
			}
			case (Enum2)103:
			{
				if (Class12.list_0.Count != 0)
				{
					class36_0.method_2(new Class26(Class12.list_0[(int)GfqOmusece]));
					break;
				}
				Module module = typeof(Class12).Module;
				class36_0.method_2(new Class26(module.ResolveString((int)GfqOmusece | 0x70000000)));
				break;
			}
			case (Enum2)104:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_28());
				break;
			}
			case (Enum2)105:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(uint), value));
				break;
			}
			case (Enum2)106:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_45());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class18(*(double*)(void*)intPtr, (Enum0)10));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)107:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				Class13 @class = class36_0.method_4();
				object value = @class.vmethod_4(null);
				if (value != null)
				{
					if (type_.IsAssignableFrom(value.GetType()))
					{
						class36_0.method_2(@class);
					}
					else
					{
						class36_0.method_2(new Class25(null));
					}
				}
				else
				{
					class36_0.method_2(new Class25(null));
				}
				break;
			}
			case (Enum2)108:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_34());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)111:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_25());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class15(*(ushort*)(void*)intPtr, (Enum0)4));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)112:
				method_11(bool_4: true);
				break;
			case (Enum2)113:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_44());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class18(*(float*)(void*)intPtr, (Enum0)9));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)114:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = Array.CreateInstance(type_, class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(new Class25(array));
				break;
			}
			case (Enum2)115:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_37());
				break;
			}
			case (Enum2)116:
			{
				Class13 @class = class36_0.method_4();
				bool flag;
				if (flag = @class.vmethod_7())
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)117:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_46());
				break;
			}
			case (Enum2)118:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				FieldInfo fieldInfo = module.ResolveField(metadataToken);
				Class13 @class = class36_0.method_4();
				object value = @class.vmethod_4(null);
				class36_0.method_2(Class13.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(value)));
				break;
			}
			case (Enum2)120:
				bool_2 = true;
				break;
			case (Enum2)121:
				class36_0.method_2(class36_0.method_4().vmethod_8());
				break;
			case (Enum2)122:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_44());
				break;
			}
			case (Enum2)123:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_48());
				break;
			}
			case (Enum2)124:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_29());
				break;
			}
			case (Enum2)125:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_22());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)126:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class2 != null && class4 != null)
				{
					class36_0.method_2(class2.vmethod_65(class4));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)127:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_60(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)128:
				class36_0.method_2(new Class23((int)GfqOmusece, this));
				break;
			case (Enum2)129:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_24());
					break;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class17)class2).method_7();
					class36_0.method_2(new Class15(*(byte*)(void*)intPtr, (Enum0)2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)130:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_61(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)131:
			{
				bool flag;
				if (flag = class36_0.method_4().vmethod_6(class36_0.method_4()))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)132:
			{
				Class13 @class = class36_0.method_4();
				Array array = (Array)@class.vmethod_4(null);
				class36_0.method_2(new Class15(array.Length, (Enum0)5));
				break;
			}
			case (Enum2)133:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_50());
				break;
			}
			case (Enum2)134:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_27());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)135:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_38());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)136:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_43());
				break;
			}
			case (Enum2)137:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_76(@class))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)138:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				FieldInfo fieldInfo = module.ResolveField(metadataToken);
				object value = class36_0.method_4().vmethod_4(fieldInfo.FieldType);
				fieldInfo.SetValue(null, value);
				break;
			}
			case (Enum2)19:
			case (Enum2)58:
			case (Enum2)61:
			case (Enum2)74:
			case (Enum2)101:
			case (Enum2)139:
				throw new Exception1();
			case (Enum2)140:
				throw (Exception)class36_0.method_4().vmethod_4(null);
			case (Enum2)141:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				object value = class36_0.method_4().vmethod_8().vmethod_4(type_);
				Class13 @class = Class13.smethod_1(type_, value);
				class36_0.method_2(@class);
				break;
			}
			case (Enum2)142:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_35());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)143:
				method_11(bool_4: false);
				break;
			case (Enum2)144:
				class36_0.method_2(new Class15((int)GfqOmusece));
				break;
			case (Enum2)145:
			{
				Class13 @class = class36_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class14)@class).vmethod_21();
				}
				Class13 class3 = class36_0.method_4();
				class3.vmethod_2(@class);
				break;
			}
			case (Enum2)147:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (!(flag = class2.vmethod_75(@class)))
				{
					class36_0.method_2(new Class15(0));
				}
				else
				{
					class36_0.method_2(new Class15(1));
				}
				break;
			}
			case (Enum2)148:
			{
				Class13 @class = class36_0.method_4();
				object value = class36_0.method_4().vmethod_4(null);
				dictionary_1[value] = @class;
				break;
			}
			case (Enum2)149:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class2 != null && class4 != null)
				{
					class36_0.method_2(class2.vmethod_68(class4));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)150:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_63(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)152:
				class36_0.method_4();
				break;
			case (Enum2)153:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_80(@class))
				{
					class36_0.method_2(new Class15(1));
				}
				else
				{
					class36_0.method_2(new Class15(0));
				}
				if (flag)
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)154:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				object value = array.GetValue(class2.vmethod_17().struct4_0.int_0);
				class36_0.method_2(Class13.smethod_1(typeof(long), value));
				break;
			}
			case (Enum2)53:
			case (Enum2)90:
			case (Enum2)109:
			case (Enum2)110:
			case (Enum2)151:
			case (Enum2)155:
				break;
			case (Enum2)156:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vPxrkrTinu9(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)157:
				int_0 = -3;
				if (class36_0.method_0() > 0)
				{
					class13_2 = class36_0.method_4();
				}
				break;
			case (Enum2)158:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_64(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)159:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				bool flag;
				if (flag = class2.vmethod_76(@class))
				{
					class36_0.method_2(new Class15(1));
				}
				else
				{
					class36_0.method_2(new Class15(0));
				}
				break;
			}
			case (Enum2)160:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_21());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)161:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_41());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)162:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				if (class36_0.method_4() is Class19 class5)
				{
					if (!type_.IsValueType)
					{
						class5.vmethod_12(new Class25(null));
						break;
					}
					object value = Activator.CreateInstance(type_);
					class5.vmethod_12(Class13.smethod_1(type_, value));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)163:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				Class14 class4 = smethod_1(class36_0.method_4());
				if (class4 != null && class2 != null)
				{
					class36_0.method_2(class4.vmethod_70(class2));
					break;
				}
				throw new Exception1();
			}
			case (Enum2)164:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_32());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)165:
				int_0 = (int)GfqOmusece - 1;
				break;
			case (Enum2)166:
			{
				Class14 class2 = class36_0.method_4() as Class14;
				Class14 class4 = class36_0.method_4() as Class14;
				IntPtr intPtr = smethod_8(class36_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class4.vmethod_14().struct4_0.byte_0;
					uint uint_ = class2.vmethod_18().struct4_0.uint_0;
					smethod_10(intPtr, byte_, (int)uint_);
				}
				break;
			}
			case (Enum2)167:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 == null)
				{
					throw new Exception1();
				}
				class36_0.method_2(class2.vmethod_36());
				break;
			}
			case (Enum2)168:
				class36_0.method_2(class36_0.method_3());
				break;
			case (Enum2)169:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_40());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)170:
			{
				Class14 class2 = smethod_1(class36_0.method_4());
				if (class2 != null)
				{
					class36_0.method_2(class2.vmethod_30());
					break;
				}
				throw new Exception1();
			}
			case (Enum2)171:
			{
				Class13 @class = class36_0.method_4();
				Class13 class3 = class36_0.method_4();
				bool flag;
				if (flag = @class.vmethod_5(class3))
				{
					int_0 = (int)GfqOmusece - 1;
				}
				break;
			}
			case (Enum2)172:
				break;
			case (Enum2)16:
			case (Enum2)31:
			case (Enum2)56:
			case (Enum2)64:
			case (Enum2)73:
			case (Enum2)119:
			case (Enum2)146:
			case (Enum2)173:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(class36_0.method_4());
				Array array = (Array)class36_0.method_4().vmethod_4(null);
				Type type_ = array.GetType().GetElementType();
				array.SetValue(@class.vmethod_4(type_), class2.vmethod_17().struct4_0.int_0);
				break;
			}
			case (Enum2)174:
			{
				int metadataToken = (int)GfqOmusece;
				Module module = typeof(Class12).Module;
				Type type_ = module.ResolveType(metadataToken);
				uint uint_ = (uint)smethod_0(type_);
				class36_0.method_2(new Class15(uint_, (Enum0)6));
				break;
			}
			case (Enum2)175:
			{
				Class13 @class = class36_0.method_4();
				Class14 class2 = smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					class36_0.method_2(class2.vmethod_23());
					break;
				}
				if (class2 == null || !class2.method_2())
				{
					throw new Exception1();
				}
				IntPtr intPtr = ((Class17)class2).method_7();
				class36_0.method_2(new Class16(*(long*)(void*)intPtr, (Enum0)7));
				break;
			}
			}
		}

		public Class13 method_7(Class13 class13_3, Enum0 enum0_0, bool bool_4 = false)
		{
			if (!bool_4 && class13_3.vmethod_0())
			{
				class13_3 = class13_3.vmethod_8();
			}
			if (class13_3.method_1())
			{
				return ((Class15)class13_3).vmethod_12(enum0_0);
			}
			if (!class13_3.method_3())
			{
				if (class13_3.method_4())
				{
					return ((Class18)class13_3).vmethod_12(enum0_0);
				}
				if (!class13_3.method_2())
				{
					return class13_3;
				}
				return ((Class17)class13_3).vmethod_12(enum0_0);
			}
			return ((Class16)class13_3).vmethod_12(enum0_0);
		}

		public Class13 method_8(int int_3)
		{
			return class13_1[int_3];
		}

		public void method_9(int int_3)
		{
			method_10(int_3, class36_0.method_4());
		}

		public static int smethod_0(Type type_0)
		{
			if (dictionary_0 == null)
			{
				dictionary_0 = new Dictionary<Type, int>();
			}
			try
			{
				int value = 0;
				if (dictionary_0.TryGetValue(type_0, out value))
				{
					return value;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, restrictedSkipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Sizeof, type_0);
				iLGenerator.Emit(OpCodes.Ret);
				value = (int)dynamicMethod.Invoke(null, null);
				dictionary_0[type_0] = value;
				return value;
			}
			catch
			{
				return 0;
			}
		}

		public void method_10(int int_3, Class13 class13_3)
		{
			class13_1[int_3] = method_7(class13_3, class32_0.list_1[int_3].enum0_0, class32_0.list_1[int_3].bool_0);
		}

		public static Class14 smethod_1(Class13 class13_3)
		{
			Class14 @class = class13_3 as Class14;
			if (@class == null && class13_3.vmethod_0())
			{
				@class = class13_3.vmethod_8() as Class14;
			}
			return @class;
		}

		public void method_11(bool bool_4)
		{
			int metadataToken = (int)GfqOmusece;
			MethodBase methodBase = typeof(Class12).Module.ResolveMethod(metadataToken);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class13[] array2 = new Class13[parameters.Length];
			List<Class33> list = null;
			Class34 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class13 class2 = class36_0.method_4();
				ParameterInfo parameterInfo = parameters[parameters.Length - 1 - i];
				Type type = parameterInfo.ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef && class2 is Class22 class3)
				{
					if (list == null)
					{
						list = new List<Class33>();
					}
					list.Add(new Class33(class3.fieldInfo_0, i));
					obj = class3.object_0;
					if (obj is Class13)
					{
						class2 = obj as Class13;
					}
					else
					{
						flag = true;
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_4(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class20)
							{
								((Class19)class2).vmethod_12(Class13.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Delegate5 @delegate = null;
			if (list == null)
			{
				if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					@delegate = smethod_2(methodBase, bool_4);
				}
			}
			else
			{
				@class = new Class34(methodBase, list);
				@delegate = smethod_3(methodBase, bool_4, @class);
			}
			object obj2 = null;
			Class13 class4 = null;
			if (!methodBase.IsStatic)
			{
				class4 = class36_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_4(methodBase.DeclaringType);
				}
				if (obj2 == null)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (class4 is Class20)
					{
						((Class19)class4).vmethod_12(Class13.smethod_1(type2, obj2));
					}
				}
			}
			object obj3 = null;
			obj3 = ((@delegate == null) ? methodBase.Invoke(obj2, array) : @delegate(obj2, array));
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (array2[j].method_2())
					{
						((Class17)array2[j]).method_6(Class13.smethod_1(parameters[j].ParameterType, array[j]));
					}
					else if (!(array2[j] is Class20))
					{
						array2[j].vmethod_10(Class13.smethod_1(parameters[j].ParameterType, array[j]));
					}
					else
					{
						array2[j].vmethod_10(Class13.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				class36_0.method_2(Class13.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		public static Delegate5 smethod_2(object object_0, bool bool_4)
		{
			Delegate5 value = null;
			if (!bool_4)
			{
				if (dictionary_3.TryGetValue((MethodBase)object_0, out value))
				{
					return value;
				}
			}
			else if (dictionary_2.TryGetValue((MethodBase)object_0, out value))
			{
				return value;
			}
			MethodInfo methodInfo = object_0 as MethodInfo;
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[2]
			{
				typeof(object),
				typeof(object[])
			}, restrictedSkipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			ParameterInfo[] parameters = ((MethodBase)object_0).GetParameters();
			Type[] array = new Type[parameters.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (parameters[i].ParameterType.IsByRef)
				{
					array[i] = parameters[i].ParameterType.GetElementType();
				}
				else
				{
					array[i] = parameters[i].ParameterType;
				}
			}
			int num = array.Length;
			if (((MemberInfo)object_0).DeclaringType.IsValueType)
			{
				num++;
			}
			LocalBuilder[] array2 = new LocalBuilder[num];
			for (int j = 0; j < array.Length; j++)
			{
				array2[j] = iLGenerator.DeclareLocal(array[j]);
			}
			if (((MemberInfo)object_0).DeclaringType.IsValueType)
			{
				array2[array2.Length - 1] = iLGenerator.DeclareLocal(((MemberInfo)object_0).DeclaringType.MakeByRefType());
			}
			for (int k = 0; k < array.Length; k++)
			{
				iLGenerator.Emit(OpCodes.Ldarg_1);
				smethod_5(iLGenerator, k);
				iLGenerator.Emit(OpCodes.Ldelem_Ref);
				if (array[k].IsValueType)
				{
					iLGenerator.Emit(OpCodes.Unbox_Any, array[k]);
				}
				else if (array[k] != typeof(object))
				{
					iLGenerator.Emit(OpCodes.Castclass, array[k]);
				}
				iLGenerator.Emit(OpCodes.Stloc, array2[k]);
			}
			if (!((MethodBase)object_0).IsStatic)
			{
				iLGenerator.Emit(OpCodes.Ldarg_0);
				if (!((MemberInfo)object_0).DeclaringType.IsValueType)
				{
					iLGenerator.Emit(OpCodes.Castclass, ((MemberInfo)object_0).DeclaringType);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Unbox, ((MemberInfo)object_0).DeclaringType);
					iLGenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
					iLGenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
				}
			}
			for (int l = 0; l < array.Length; l++)
			{
				if (!parameters[l].ParameterType.IsByRef)
				{
					iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Ldloca_S, array2[l]);
				}
			}
			if (!bool_4)
			{
				if (methodInfo != null)
				{
					iLGenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Callvirt, object_0 as ConstructorInfo);
				}
			}
			else if (methodInfo != null)
			{
				iLGenerator.EmitCall(OpCodes.Call, methodInfo, null);
			}
			else
			{
				iLGenerator.Emit(OpCodes.Call, object_0 as ConstructorInfo);
			}
			if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
			{
				if (!methodInfo.ReturnType.IsByRef)
				{
					if (methodInfo.ReturnType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					Type elementType = methodInfo.ReturnType.GetElementType();
					if (!elementType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Ldind_Ref, elementType);
					}
					else
					{
						iLGenerator.Emit(OpCodes.Ldobj, elementType);
					}
					if (elementType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Box, elementType);
					}
				}
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			for (int m = 0; m < array.Length; m++)
			{
				if (parameters[m].ParameterType.IsByRef)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
					smethod_5(iLGenerator, m);
					iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					iLGenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			iLGenerator.Emit(OpCodes.Ret);
			Delegate5 @delegate = (Delegate5)dynamicMethod.CreateDelegate(typeof(Delegate5));
			if (!bool_4)
			{
				dictionary_3.Add((MethodBase)object_0, @delegate);
			}
			else
			{
				dictionary_2.Add((MethodBase)object_0, @delegate);
			}
			return @delegate;
		}

		public static Delegate5 smethod_3(object object_0, bool bool_4, Class34 class34_0)
		{
			Delegate5 value = null;
			if (bool_4)
			{
				if (dictionary_4.TryGetValue(class34_0, out value))
				{
					return value;
				}
			}
			else if (dictionary_5.TryGetValue(class34_0, out value))
			{
				return value;
			}
			MethodInfo methodInfo = object_0 as MethodInfo;
			DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[2]
			{
				typeof(object),
				typeof(object[])
			}, typeof(Class12), skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			ParameterInfo[] parameters = ((MethodBase)object_0).GetParameters();
			Type[] array = new Type[parameters.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (!parameters[i].ParameterType.IsByRef)
				{
					array[i] = parameters[i].ParameterType;
				}
				else
				{
					array[i] = parameters[i].ParameterType.GetElementType();
				}
			}
			int num = array.Length;
			if (((MemberInfo)object_0).DeclaringType.IsValueType)
			{
				num++;
			}
			LocalBuilder[] array2 = new LocalBuilder[num];
			for (int j = 0; j < array.Length; j++)
			{
				if (!class34_0.method_1(j))
				{
					array2[j] = iLGenerator.DeclareLocal(array[j]);
				}
				else
				{
					array2[j] = iLGenerator.DeclareLocal(typeof(object));
				}
			}
			if (((MemberInfo)object_0).DeclaringType.IsValueType)
			{
				array2[array2.Length - 1] = iLGenerator.DeclareLocal(((MemberInfo)object_0).DeclaringType.MakeByRefType());
			}
			for (int k = 0; k < array.Length; k++)
			{
				iLGenerator.Emit(OpCodes.Ldarg_1);
				smethod_5(iLGenerator, k);
				iLGenerator.Emit(OpCodes.Ldelem_Ref);
				if (!class34_0.method_1(k))
				{
					if (array[k].IsValueType)
					{
						iLGenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						iLGenerator.Emit(OpCodes.Castclass, array[k]);
					}
				}
				iLGenerator.Emit(OpCodes.Stloc, array2[k]);
			}
			if (!((MethodBase)object_0).IsStatic)
			{
				iLGenerator.Emit(OpCodes.Ldarg_0);
				if (((MemberInfo)object_0).DeclaringType.IsValueType)
				{
					iLGenerator.Emit(OpCodes.Unbox, ((MemberInfo)object_0).DeclaringType);
					iLGenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
					iLGenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Castclass, ((MemberInfo)object_0).DeclaringType);
				}
			}
			for (int l = 0; l < array.Length; l++)
			{
				if (class34_0.method_1(l))
				{
					Class33 @class = class34_0.method_0(l);
					if (((FieldInfo)@class.object_0).IsStatic)
					{
						iLGenerator.Emit(OpCodes.Ldsflda, (FieldInfo)@class.object_0);
					}
					else if (!((MemberInfo)@class.object_0).DeclaringType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
						iLGenerator.Emit(OpCodes.Castclass, ((MemberInfo)@class.object_0).DeclaringType);
						iLGenerator.Emit(OpCodes.Ldflda, (FieldInfo)@class.object_0);
					}
					else
					{
						iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
						iLGenerator.Emit(OpCodes.Unbox, ((MemberInfo)@class.object_0).DeclaringType);
						iLGenerator.Emit(OpCodes.Ldflda, (FieldInfo)@class.object_0);
					}
				}
				else if (parameters[l].ParameterType.IsByRef)
				{
					iLGenerator.Emit(OpCodes.Ldloca_S, array2[l]);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
				}
			}
			if (bool_4)
			{
				if (methodInfo != null)
				{
					iLGenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				else
				{
					iLGenerator.Emit(OpCodes.Call, object_0 as ConstructorInfo);
				}
			}
			else if (!(methodInfo != null))
			{
				iLGenerator.Emit(OpCodes.Callvirt, object_0 as ConstructorInfo);
			}
			else
			{
				iLGenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
			}
			if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
			{
				if (!methodInfo.ReturnType.IsByRef)
				{
					if (methodInfo.ReturnType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					Type elementType = methodInfo.ReturnType.GetElementType();
					if (elementType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Ldobj, elementType);
					}
					else
					{
						iLGenerator.Emit(OpCodes.Ldind_Ref, elementType);
					}
					if (elementType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Box, elementType);
					}
				}
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			for (int m = 0; m < array.Length; m++)
			{
				if (!parameters[m].ParameterType.IsByRef)
				{
					continue;
				}
				if (class34_0.method_1(m))
				{
					Class33 class2 = class34_0.method_0(m);
					if (!((FieldInfo)class2.object_0).IsStatic)
					{
						iLGenerator.Emit(OpCodes.Ldarg_1);
						smethod_5(iLGenerator, m);
						iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						iLGenerator.Emit(OpCodes.Stelem_Ref);
					}
					else
					{
						iLGenerator.Emit(OpCodes.Ldarg_1);
						smethod_5(iLGenerator, m);
						iLGenerator.Emit(OpCodes.Ldsfld, (FieldInfo)class2.object_0);
						if (((FieldInfo)class2.object_0).FieldType.IsValueType)
						{
							iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						iLGenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				else
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
					smethod_5(iLGenerator, m);
					iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType)
					{
						iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					iLGenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			iLGenerator.Emit(OpCodes.Ret);
			Delegate5 @delegate = (Delegate5)dynamicMethod.CreateDelegate(typeof(Delegate5));
			if (!bool_4)
			{
				dictionary_5.Add(class34_0, @delegate);
			}
			else
			{
				dictionary_4.Add(class34_0, @delegate);
			}
			return @delegate;
		}

		public static Delegate5 smethod_4(object object_0, bool bool_4, Class34 class34_0)
		{
			Delegate5 value = null;
			if (!dictionary_6.TryGetValue(class34_0, out value))
			{
				ConstructorInfo constructorInfo = object_0 as ConstructorInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[2]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class12), skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = ((MethodBase)object_0).GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (((MemberInfo)object_0).DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (!class34_0.method_1(j))
					{
						array2[j] = iLGenerator.DeclareLocal(array[j]);
					}
					else
					{
						array2[j] = iLGenerator.DeclareLocal(typeof(object));
					}
				}
				if (((MemberInfo)object_0).DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = iLGenerator.DeclareLocal(((MemberInfo)object_0).DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
					smethod_5(iLGenerator, k);
					iLGenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class34_0.method_1(k))
					{
						if (!array[k].IsValueType)
						{
							if (array[k] != typeof(object))
							{
								iLGenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						else
						{
							iLGenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
					}
					iLGenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (class34_0.method_1(l))
					{
						Class33 @class = class34_0.method_0(l);
						if (((FieldInfo)@class.object_0).IsStatic)
						{
							iLGenerator.Emit(OpCodes.Ldsflda, (FieldInfo)@class.object_0);
						}
						else if (((MemberInfo)@class.object_0).DeclaringType.IsValueType)
						{
							iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
							iLGenerator.Emit(OpCodes.Unbox, ((MemberInfo)@class.object_0).DeclaringType);
							iLGenerator.Emit(OpCodes.Ldflda, (FieldInfo)@class.object_0);
						}
						else
						{
							iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
							iLGenerator.Emit(OpCodes.Castclass, ((MemberInfo)@class.object_0).DeclaringType);
							iLGenerator.Emit(OpCodes.Ldflda, (FieldInfo)@class.object_0);
						}
					}
					else if (parameters[l].ParameterType.IsByRef)
					{
						iLGenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				iLGenerator.Emit(OpCodes.Newobj, object_0 as ConstructorInfo);
				if (constructorInfo.DeclaringType.IsValueType)
				{
					iLGenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (!parameters[m].ParameterType.IsByRef)
					{
						continue;
					}
					if (class34_0.method_1(m))
					{
						Class33 class2 = class34_0.method_0(m);
						if (((FieldInfo)class2.object_0).IsStatic)
						{
							iLGenerator.Emit(OpCodes.Ldarg_1);
							smethod_5(iLGenerator, m);
							iLGenerator.Emit(OpCodes.Ldsfld, (FieldInfo)class2.object_0);
							if (((FieldInfo)class2.object_0).FieldType.IsValueType)
							{
								iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							iLGenerator.Emit(OpCodes.Stelem_Ref);
						}
						else
						{
							iLGenerator.Emit(OpCodes.Ldarg_1);
							smethod_5(iLGenerator, m);
							iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							iLGenerator.Emit(OpCodes.Stelem_Ref);
						}
					}
					else
					{
						iLGenerator.Emit(OpCodes.Ldarg_1);
						smethod_5(iLGenerator, m);
						iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						iLGenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				iLGenerator.Emit(OpCodes.Ret);
				Delegate5 @delegate = (Delegate5)dynamicMethod.CreateDelegate(typeof(Delegate5));
				dictionary_6.Add(class34_0, @delegate);
				return @delegate;
			}
			return value;
		}

		public static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			}
			if (int_3 > -129 && int_3 < 128)
			{
				ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
			}
			else
			{
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
			}
		}

		public static Class13 smethod_6(Class13 class13_3)
		{
			Class13 @class = class13_3.vmethod_8();
			if (@class.method_0())
			{
				object obj = class13_3.vmethod_4(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object object_ = Convert.ChangeType(obj, underlyingType);
					Class13 class2 = smethod_7(Class13.smethod_1(underlyingType, object_));
					if (class2 != null)
					{
						return class2 as Class14;
					}
				}
			}
			return class13_3;
		}

		public static Class14 smethod_7(Class13 class13_3)
		{
			Class14 @class = class13_3 as Class14;
			if (@class == null && class13_3.vmethod_0())
			{
				@class = class13_3.vmethod_8() as Class14;
			}
			return @class;
		}

		public static IntPtr smethod_8(object object_0)
		{
			if (object_0 != null)
			{
				if (((Class13)object_0).method_2())
				{
					return ((Class17)object_0).method_7();
				}
				if (((Class13)object_0).vmethod_0())
				{
					Class19 @class = (Class19)object_0;
					try
					{
						return @class.vmethod_11();
					}
					catch
					{
					}
				}
				object obj2 = ((Class13)object_0).vmethod_4(typeof(IntPtr));
				if (obj2 != null && obj2.GetType() == typeof(IntPtr))
				{
					return (IntPtr)obj2;
				}
				throw new Exception1();
			}
			return IntPtr.Zero;
		}

		public static object smethod_9(object object_0)
		{
			if (dictionary_7 == null)
			{
				dictionary_7 = new Dictionary<Type, Delegate6>();
			}
			if (object_0 != null)
			{
				try
				{
					Type type = object_0.GetType();
					if (!dictionary_7.TryGetValue(type, out var value))
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[1] { typeof(object) }, restrictedSkipVisibility: true);
						ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
						iLGenerator.Emit(OpCodes.Ldarg_0);
						iLGenerator.Emit(OpCodes.Unbox_Any, type);
						iLGenerator.Emit(OpCodes.Box, type);
						iLGenerator.Emit(OpCodes.Ret);
						Delegate6 @delegate = (Delegate6)dynamicMethod.CreateDelegate(typeof(Delegate6));
						dictionary_7.Add(type, @delegate);
						return @delegate(object_0);
					}
					return value(object_0);
				}
				catch
				{
					return null;
				}
			}
			return null;
		}

		public static void smethod_10(IntPtr intptr_0, byte byte_0, int int_3)
		{
			if (delegate7_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[3]
				{
					typeof(IntPtr),
					typeof(byte),
					typeof(int)
				}, typeof(Class12), skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldarg_1);
				iLGenerator.Emit(OpCodes.Ldarg_2);
				iLGenerator.Emit(OpCodes.Initblk);
				iLGenerator.Emit(OpCodes.Ret);
				delegate7_0 = (Delegate7)dynamicMethod.CreateDelegate(typeof(Delegate7));
			}
			delegate7_0(intptr_0, byte_0, int_3);
		}

		public static void smethod_11(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (delegate8_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[3]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class12), skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				iLGenerator.Emit(OpCodes.Ldarg_0);
				iLGenerator.Emit(OpCodes.Ldarg_1);
				iLGenerator.Emit(OpCodes.Ldarg_2);
				iLGenerator.Emit(OpCodes.Cpblk);
				iLGenerator.Emit(OpCodes.Ret);
				delegate8_0 = (Delegate8)dynamicMethod.CreateDelegate(typeof(Delegate8));
			}
			delegate8_0(intptr_0, intptr_1, uint_0);
		}

		[CompilerGenerated]
		public static int smethod_12(Class31 class31_0, Class31 class31_1)
		{
			return ((Class30)(object)class31_0).class31_0.int_0.CompareTo(((Class30)(object)class31_1).class31_0.int_0);
		}

		static Class35()
		{
			dictionary_1 = new Dictionary<object, Class13>();
			dictionary_2 = new Dictionary<MethodBase, Delegate5>();
			dictionary_3 = new Dictionary<MethodBase, Delegate5>();
			dictionary_4 = new Dictionary<Class34, Delegate5>();
			dictionary_5 = new Dictionary<Class34, Delegate5>();
			dictionary_6 = new Dictionary<Class34, Delegate5>();
		}
	}

	internal enum Enum2 : byte
	{

	}

	internal enum Enum3 : byte
	{

	}

	public class Class25 : Class13
	{
		public Class13 class13_0;

		public Type type_0;

		public Class25()
			: this(null)
		{
		}

		internal override void vmethod_10(Class13 class13_1)
		{
			if (class13_1 is Class25)
			{
				class13_0 = ((Class25)class13_1).class13_0;
				type_0 = ((Class25)class13_1).type_0;
			}
			else
			{
				class13_0 = class13_1.vmethod_8();
			}
		}

		internal override void vmethod_2(Class13 class13_1)
		{
			vmethod_10(class13_1);
		}

		public Class25(object object_0)
			: base((Enum3)0)
		{
			class13_0 = (Class13)object_0;
			type_0 = null;
		}

		public Class25(object object_0, Type type_1)
			: base((Enum3)0)
		{
			class13_0 = (Class13)object_0;
			type_0 = type_1;
		}

		public override string ToString()
		{
			if (class13_0 == null)
			{
				return Enum4.NULL.ToString();
			}
			return class13_0.ToString();
		}

		internal override object vmethod_4(Type type_1)
		{
			if (class13_0 != null)
			{
				if (type_1 != null && type_1.IsByRef)
				{
					type_1 = type_1.GetElementType();
				}
				if (class13_0 is Class13)
				{
					if (type_0 != null)
					{
						return class13_0.vmethod_4(type_0);
					}
					object obj = class13_0.vmethod_4(type_1);
					if (obj != null && type_1 != null && obj.GetType() != type_1)
					{
						if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
						{
							obj = ((FieldInfo)obj).FieldHandle;
						}
						else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
						{
							obj = ((Type)obj).TypeHandle;
						}
						else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
						{
							obj = ((MethodBase)obj).MethodHandle;
						}
					}
					return obj;
				}
				object obj2 = class13_0;
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return null;
		}

		internal override bool vmethod_5(Class13 class13_1)
		{
			if (class13_1.vmethod_0())
			{
				return ((Class19)class13_1).vmethod_5(this);
			}
			object obj = vmethod_4(null);
			object obj2 = class13_1.vmethod_4(null);
			return obj == obj2;
		}

		internal override bool vmethod_6(Class13 class13_1)
		{
			if (class13_1.vmethod_0())
			{
				return ((Class19)class13_1).vmethod_6(this);
			}
			object obj = vmethod_4(null);
			object obj2 = class13_1.vmethod_4(null);
			return obj != obj2;
		}

		internal override Class13 vmethod_8()
		{
			if (!(class13_0 is Class13 @class))
			{
				return this;
			}
			return @class.vmethod_8();
		}

		internal override bool vmethod_7()
		{
			if (class13_0 != null)
			{
				if (class13_0 is Class13 @class)
				{
					if (@class.vmethod_4(null) != null)
					{
						return true;
					}
					return false;
				}
				return true;
			}
			return false;
		}
	}

	public class Class26 : Class13
	{
		public string string_0;

		public Class26(string string_1)
			: base((Enum3)6)
		{
			string_0 = string_1;
		}

		internal override void vmethod_10(Class13 class13_0)
		{
			string_0 = ((Class26)class13_0).string_0;
		}

		internal override void vmethod_2(Class13 class13_0)
		{
			vmethod_10(class13_0);
		}

		public override string ToString()
		{
			if (string_0 == null)
			{
				return Enum4.NULL.ToString();
			}
			return '*' + string_0 + '*';
		}

		internal override bool vmethod_7()
		{
			return string_0 != null;
		}

		internal override object vmethod_4(Type type_0)
		{
			return string_0;
		}

		internal override bool vmethod_5(Class13 class13_0)
		{
			if (class13_0.vmethod_0())
			{
				return ((Class19)class13_0).vmethod_5(this);
			}
			object obj = string_0;
			object obj2 = class13_0.vmethod_4(null);
			return obj == obj2;
		}

		internal override bool vmethod_6(Class13 class13_0)
		{
			if (!class13_0.vmethod_0())
			{
				object obj = string_0;
				object obj2 = class13_0.vmethod_4(null);
				return obj != obj2;
			}
			return ((Class19)class13_0).vmethod_6(this);
		}

		internal override Class13 vmethod_8()
		{
			return this;
		}
	}

	internal class Class36
	{
		public List<Class13> list_0 = new List<Class13>();

		[SpecialName]
		public int method_0()
		{
			return list_0.Count;
		}

		public void method_1()
		{
			list_0.Clear();
		}

		public void method_2(Class13 class13_0)
		{
			list_0.Add(class13_0);
		}

		public Class13 method_3()
		{
			return list_0[list_0.Count - 1];
		}

		public Class13 method_4()
		{
			Class13 result = method_3();
			if (list_0.Count != 0)
			{
				list_0.RemoveAt(list_0.Count - 1);
			}
			return result;
		}
	}

	internal enum Enum4
	{
		const_0 = 0,
		InfinityValue = 1,
		NAN = 2,
		Add = 3,
		TruncationNotSupported = 4,
		NULL = 5,
		doppelpunkt = 72,
		ganse = 42,
		bindestrich = 55
	}

	internal static Class32[] class32_0;

	internal static int[] int_0;

	internal static List<string> list_0;

	public static BinaryReader binaryReader_0;

	public static byte[] byte_0;

	public static bool bool_0;

	public static object object_0;

	public static int int_1;

	internal static object[] smethod_0()
	{
		return new object[1];
	}

	internal static object[] smethod_1<T>(int int_2, object object_1, object object_2, ref T gparam_0)
	{
		lock (object_0)
		{
			if (!bool_0)
			{
				bool_0 = true;
				smethod_4();
			}
		}
		Class32 @class = null;
		if (class32_0[int_2] != null)
		{
			@class = class32_0[int_2];
		}
		else
		{
			binaryReader_0.BaseStream.Position = int_0[int_2];
			@class = new Class32();
			Module module = typeof(Class12).Module;
			int metadataToken = smethod_6(binaryReader_0);
			int num = smethod_6(binaryReader_0);
			int num2 = smethod_6(binaryReader_0);
			int num3 = smethod_6(binaryReader_0);
			@class.object_0 = module.ResolveMethod(metadataToken);
			ParameterInfo[] parameters = ((MethodBase)@class.object_0).GetParameters();
			@class.class28_0 = new Class28[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				Type type = parameters[i].ParameterType;
				Class28 class2 = new Class28();
				class2.bool_0 = type.IsByRef;
				class2.int_0 = i;
				@class.class28_0[i] = class2;
				if (type.IsByRef)
				{
					type = type.GetElementType();
				}
				Enum0 @enum = (Enum0)0;
				@enum = ((!(type == typeof(string))) ? ((!(type == typeof(byte))) ? ((type == typeof(sbyte)) ? ((Enum0)1) : ((!(type == typeof(short))) ? ((!(type == typeof(ushort))) ? ((!(type == typeof(int))) ? ((!(type == typeof(uint))) ? ((!(type == typeof(long))) ? ((!(type == typeof(ulong))) ? ((!(type == typeof(float))) ? ((!(type == typeof(double))) ? ((!(type == typeof(bool))) ? ((!(type == typeof(IntPtr))) ? ((!(type == typeof(UIntPtr))) ? ((type == typeof(char)) ? ((Enum0)15) : ((Enum0)0)) : ((Enum0)13)) : ((Enum0)12)) : ((Enum0)11)) : ((Enum0)10)) : ((Enum0)9)) : ((Enum0)8)) : ((Enum0)7)) : ((Enum0)6)) : ((Enum0)5)) : ((Enum0)4)) : ((Enum0)3))) : ((Enum0)2)) : ((Enum0)14));
				class2.enum0_0 = @enum;
			}
			@class.list_1 = new List<Class29>(num);
			for (int j = 0; j < num; j++)
			{
				int num4 = smethod_6(binaryReader_0);
				Class29 class3 = new Class29();
				class3.type_0 = null;
				if (num4 >= 0 && num4 < 50)
				{
					class3.enum0_0 = (Enum0)((uint)num4 & 0x1Fu);
					class3.bool_0 = (num4 & 0x20) > 0;
				}
				class3.int_0 = j;
				@class.list_1.Add(class3);
			}
			@class.list_2 = new List<Class30>(num2);
			for (int k = 0; k < num2; k++)
			{
				int num5 = smethod_6(binaryReader_0);
				int num6 = smethod_6(binaryReader_0);
				Class30 class4 = new Class30();
				class4.int_0 = num5;
				class4.int_1 = num6;
				Class31 class5 = (class4.class31_0 = new Class31());
				num5 = smethod_6(binaryReader_0);
				num6 = smethod_6(binaryReader_0);
				int num7 = smethod_6(binaryReader_0);
				class5.int_0 = num5;
				class5.int_1 = num6;
				class5.int_3 = num7;
				switch (num7)
				{
				case 0:
					class5.type_0 = module.ResolveType(smethod_6(binaryReader_0));
					break;
				case 1:
					class5.int_2 = smethod_6(binaryReader_0);
					break;
				default:
					smethod_6(binaryReader_0);
					break;
				}
				@class.list_2.Add(class4);
			}
			@class.list_0 = new List<Class27>(num3);
			for (int l = 0; l < num3; l++)
			{
				Class27 class6 = new Class27();
				byte b = (byte)(class6.enum2_0 = (Enum2)binaryReader_0.ReadByte());
				if (b < 176)
				{
					int num8 = byte_0[b];
					if (num8 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj = null;
						switch (num8)
						{
						case 1:
							obj = smethod_6(binaryReader_0);
							goto IL_0557;
						case 2:
							obj = binaryReader_0.ReadInt64();
							goto IL_0557;
						case 3:
							obj = binaryReader_0.ReadSingle();
							goto IL_0557;
						case 4:
							obj = binaryReader_0.ReadDouble();
							goto IL_0557;
						case 5:
						{
							int num9 = smethod_6(binaryReader_0);
							int[] array = new int[num9];
							for (int m = 0; m < num9; m++)
							{
								array[m] = smethod_6(binaryReader_0);
							}
							obj = array;
							goto IL_0557;
						}
						default:
							{
								throw new Exception();
							}
							IL_0557:
							class6.object_0 = obj;
							break;
						}
					}
					@class.list_0.Add(class6);
					continue;
				}
				throw new Exception();
			}
			class32_0[int_2] = @class;
		}
		Class35 class7 = new Class35();
		class7.class32_0 = @class;
		ParameterInfo[] parameters2 = ((MethodBase)@class.object_0).GetParameters();
		bool flag = false;
		int num10 = 0;
		if (@class.object_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.object_0;
			if (methodInfo.ReturnType != typeof(void))
			{
				flag = true;
			}
		}
		if (((MethodBase)@class.object_0).IsStatic)
		{
			class7.class13_0 = new Class13[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class13_0[n] = Class13.smethod_1(parameterType, ((object[])object_1)[n]);
				if (parameterType.IsByRef)
				{
					num10++;
				}
			}
		}
		else
		{
			class7.class13_0 = new Class13[parameters2.Length + 1];
			if (((MemberInfo)@class.object_0).DeclaringType.IsValueType)
			{
				class7.class13_0[0] = new Class24(new Class25(object_2), ((MemberInfo)@class.object_0).DeclaringType);
			}
			else
			{
				class7.class13_0[0] = new Class25(object_2);
			}
			for (int num11 = 0; num11 < parameters2.Length; num11++)
			{
				Type parameterType2 = parameters2[num11].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class13_0[num11 + 1] = Class13.smethod_1(parameterType2, ((object[])object_1)[num11]);
					num10++;
				}
				else
				{
					class7.class13_0[num11 + 1] = Class13.smethod_1(parameterType2, ((object[])object_1)[num11]);
				}
			}
		}
		class7.class13_1 = new Class13[@class.list_1.Count];
		for (int num12 = 0; num12 < @class.list_1.Count; num12++)
		{
			Class29 class8 = @class.list_1[num12];
			switch (class8.enum0_0)
			{
			case (Enum0)0:
				class7.class13_1[num12] = null;
				break;
			case (Enum0)7:
			case (Enum0)8:
				class7.class13_1[num12] = new Class16(0L, class8.enum0_0);
				break;
			case (Enum0)9:
			case (Enum0)10:
				class7.class13_1[num12] = new Class18(0.0, class8.enum0_0);
				break;
			case (Enum0)12:
				class7.class13_1[num12] = new Class17(IntPtr.Zero);
				break;
			case (Enum0)13:
				class7.class13_1[num12] = new Class17(UIntPtr.Zero);
				break;
			case (Enum0)14:
				class7.class13_1[num12] = null;
				break;
			case (Enum0)1:
			case (Enum0)2:
			case (Enum0)3:
			case (Enum0)4:
			case (Enum0)5:
			case (Enum0)6:
			case (Enum0)11:
			case (Enum0)15:
				class7.class13_1[num12] = new Class15(0, class8.enum0_0);
				break;
			case (Enum0)16:
				class7.class13_1[num12] = new Class25(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num13 = 0;
		if (flag)
		{
			num13 = 1;
		}
		num13 += num10;
		object[] array2 = new object[num13];
		if (flag)
		{
			array2[0] = null;
		}
		if (@class.object_0 is MethodInfo)
		{
			MethodInfo methodInfo2 = (MethodInfo)@class.object_0;
			if (methodInfo2.ReturnType != typeof(void) && class7.class13_2 != null)
			{
				array2[0] = class7.class13_2.vmethod_4(methodInfo2.ReturnType);
			}
		}
		if (num10 > 0)
		{
			int num14 = 0;
			if (flag)
			{
				num14++;
			}
			for (int num15 = 0; num15 < parameters2.Length; num15++)
			{
				Type parameterType3 = parameters2[num15].ParameterType;
				if (!parameterType3.IsByRef)
				{
					continue;
				}
				parameterType3 = parameterType3.GetElementType();
				if (class7.class13_0[num15] != null)
				{
					if (((MethodBase)@class.object_0).IsStatic)
					{
						array2[num14] = class7.class13_0[num15].vmethod_4(parameterType3);
					}
					else
					{
						array2[num14] = class7.class13_0[num15 + 1].vmethod_4(parameterType3);
					}
				}
				else
				{
					array2[num14] = null;
				}
				num14++;
			}
		}
		if (!((MethodBase)@class.object_0).IsStatic && ((MemberInfo)@class.object_0).DeclaringType.IsValueType)
		{
			gparam_0 = (T)class7.class13_0[0].vmethod_4(((MemberInfo)@class.object_0).DeclaringType);
		}
		return array2;
	}

	internal static object[] smethod_2(int int_2, object object_1, object object_2)
	{
		return smethod_1(int_2, object_1, object_2, ref int_1);
	}

	internal static object[] smethod_3<T>(int int_2, object object_1, ref T gparam_0)
	{
		return smethod_1(int_2, object_1, gparam_0, ref gparam_0);
	}

	internal static void smethod_4()
	{
		if (int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class12).Assembly.GetManifestResourceStream("ET5Q58buC6CWEvDUW6.Ivtqb4scanYBGEx1Ry"));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			smethod_5(byte_);
		}
	}

	internal static void smethod_5(byte[] byte_1)
	{
		MemoryStream input = new MemoryStream(byte_1);
		binaryReader_0 = new BinaryReader(input);
		byte_0 = new byte[255];
		int num = smethod_6(binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = binaryReader_0.ReadByte();
			byte_0[num2] = binaryReader_0.ReadByte();
		}
		num = smethod_6(binaryReader_0);
		list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			list_0.Add(Encoding.Unicode.GetString(binaryReader_0.ReadBytes(smethod_6(binaryReader_0))));
		}
		num = smethod_6(binaryReader_0);
		class32_0 = new Class32[num];
		int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			class32_0[k] = null;
			int_0[k] = smethod_6(binaryReader_0);
		}
		int num3 = (int)binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = int_0[l];
			int_0[l] = num3;
			num3 += num4;
		}
	}

	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = 0u;
		uint num2 = binaryReader_1.ReadByte();
		num = 0u | (num2 & 0x3Fu);
		if ((num2 & 0x40u) != 0)
		{
			flag = true;
		}
		if (num2 < 128)
		{
			if (flag)
			{
				return (int)(~num);
			}
			return (int)num;
		}
		int num3 = 0;
		while (true)
		{
			uint num4 = binaryReader_1.ReadByte();
			num |= (num4 & 0x7F) << 7 * num3 + 6;
			if (num4 < 128)
			{
				break;
			}
			num3++;
		}
		if (flag)
		{
			return (int)(~num);
		}
		return (int)num;
	}

	[CompilerGenerated]
	public static int smethod_7<T>(Class31 class31_0, Class31 class31_1)
	{
		return ((Class30)(object)class31_0).class31_0.int_0.CompareTo(((Class30)(object)class31_1).class31_0.int_0);
	}

	static Class12()
	{
		class32_0 = null;
		int_0 = null;
		bool_0 = false;
		object_0 = 1;
	}
}
