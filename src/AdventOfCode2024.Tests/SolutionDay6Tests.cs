﻿using NUnit.Framework;

namespace AdventOfCode2024.Day6.Tests;

public static class SolutionDay6Tests
{
	[Test]
	public static void Part1()
	{
		var input =
			"""
			....#.....
			.........#
			..........
			..#.......
			.......#..
			..........
			.#..^.....
			........#.
			#.........
			......#...
			""";

		Assert.That(SolutionDay6.RunPart1([.. input.Split(Environment.NewLine)]), Is.EqualTo(41));
	}

	[Test]
	public static void Part2()
	{
		var input =
			"""
			....#.....
			.........#
			..........
			..#.......
			.......#..
			..........
			.#..^.....
			........#.
			#.........
			......#...
			""";

		Assert.That(SolutionDay6.RunPart2([.. input.Split(Environment.NewLine)]), Is.EqualTo(6));
	}
}