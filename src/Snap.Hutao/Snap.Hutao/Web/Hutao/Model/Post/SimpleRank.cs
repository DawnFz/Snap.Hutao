﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Hutao.Web.Hoyolab.Takumi.GameRecord.SpiralAbyss;

namespace Snap.Hutao.Web.Hutao.Model.Post;

/// <summary>
/// 数值
/// </summary>
public class SimpleRank
{
    /// <summary>
    /// 构造一个新的数值
    /// </summary>
    /// <param name="rank">排行</param>
    public SimpleRank(Rank rank)
    {
        AvatarId = rank.AvatarId;
        Value = rank.Value;
    }

    /// <summary>
    /// 角色Id
    /// </summary>
    public int AvatarId { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    public int Value { get; set; }
}
