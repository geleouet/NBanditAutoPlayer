﻿//
// BanditType.fs
//
// Author:
//       Dupire Gael <>
//
// Copyright (c) 2016 gaeldupire
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
module BanditType
open System

type Weigth                = double
type NormalizedWeigth      = double
type Reward                = double
type InfLimit              = double
type SupLimit              = double
type BanditResult = 
    | BanditReward of Reward
    | Nothing

type RewardStageDefinition = { StageWeigth : Weigth; StageReward : Reward }
type RewardDefinitions     = RewardStageDefinition list

type Interval              = { From : InfLimit; To : SupLimit }
type RewardStage           = { NormalizedWeigth : NormalizedWeigth; StageReward : Reward; SelectionInterval : Interval }
type RewardDistribution    = RewardStage list
