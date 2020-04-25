/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Stelem_Any,
        No,
        Unaligned,
        Ldind_I8,
        Or,
        Conv_Ovf_U4_Un,
        Ldelem_Any,
        Stfld,
        Conv_Ovf_U,
        Throw,
        Endfinally,
        //Calli,
        Ldelema,
        Br,
        Conv_U,
        Ldarga,
        Conv_Ovf_I2,
        Ldind_U1,
        Conv_U2,
        Stind_I4,
        Newarr,
        CallExtern,
        Stind_R8,
        Shr_Un,
        Add,
        Ldflda,
        Ldc_I4,
        Stloc,
        Conv_Ovf_U8,
        Box,
        Pop,
        Rem_Un,
        Ldelem_I,
        Ldind_I,
        Ldobj,
        Conv_I4,
        Ldfld,
        Stelem_R8,
        Conv_Ovf_I_Un,
        Conv_I,
        Initblk,
        Ldelem_I2,
        Nop,
        Stobj,
        Cpobj,
        Clt_Un,
        Volatile,
        Mul,
        Ldelem_I1,
        Ldloca,
        Mul_Ovf_Un,
        Bge_Un,
        Ldelem_I8,
        Ckfinite,
        Unbox,
        Cgt,
        Ldind_I4,
        Add_Ovf_Un,
        Bgt,
        Ldind_R8,
        Shl,
        Dup,
        Stelem_I,
        Jmp,
        Ble,
        Bne_Un,
        Stelem_R4,
        Ldind_I1,
        Ldtoken,
        Ldsfld,
        Clt,
        Stind_I2,
        Ldind_I2,
        Newanon,
        Starg,
        Ldarg,
        Conv_Ovf_I2_Un,
        Cgt_Un,
        Blt,
        Ldelem_U2,
        Stsfld,
        Conv_R_Un,
        Localloc,
        Sizeof,
        Ldind_U4,
        Callvirt,
        Mkrefany,
        Cpblk,
        Ldind_Ref,
        Stind_Ref,
        Sub,
        Div,
        Rethrow,
        Arglist,
        Ldsflda,
        Conv_Ovf_I4,
        Conv_Ovf_I1_Un,
        Ldind_R4,
        Conv_R4,
        Ldelem_I4,
        And,
        Stind_I1,
        Conv_I1,
        Ldftn,
        Ldvirtftn,
        Readonly,
        Stelem_I8,
        Refanyval,
        Sub_Ovf_Un,
        Ldstr,
        Conv_Ovf_U1,
        Bgt_Un,
        Xor,
        Shr,
        Ldc_I8,
        Constrained,
        Add_Ovf,
        Ldtype, // custom
        Castclass,
        Call,
        Not,
        Stind_I8,
        Stelem_I1,
        Conv_Ovf_U4,
        Bge,
        Ldlen,
        Conv_Ovf_I4_Un,
        Stelem_Ref,
        Stelem_I4,
        Ceq,
        Conv_U1,
        Conv_I8,
        Blt_Un,
        Stelem_I2,
        Conv_U4,
        Conv_Ovf_U_Un,
        Div_Un,
        Conv_Ovf_U2,
        Beq,
        Brfalse,
        Ldloc,
        Ldelem_Ref,
        Conv_Ovf_U2_Un,
        Conv_Ovf_I,
        Conv_I2,
        Ldelem_R8,
        Sub_Ovf,

        //Pseudo instruction
        StackSpace,
        Stind_R4,
        Conv_Ovf_I8,
        Neg,
        Ldelem_U1,
        Leave,
        Mul_Ovf,
        Break,
        Brtrue,
        Refanytype,
        Ldc_R4,
        Isinst,
        Conv_U8,
        Ldind_U2,
        Newobj,
        Rem,
        Ldelem_U4,
        Ble_Un,
        Conv_Ovf_I8_Un,
        Ldc_R8,
        Endfilter,
        Tail,
        Conv_R8,
        Stind_I,
        Initobj,
        Unbox_Any,
        Ldelem_R4,
        Ret,
        Conv_Ovf_U8_Un,
        Conv_Ovf_U1_Un,
        Switch,
        Ldnull,
        Conv_Ovf_I1,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 8422174002946443901;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}