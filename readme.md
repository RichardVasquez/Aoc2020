# [Advent of Code 2020](https://adventofcode.com/2020) Solvers

This is the third year I've tried doing Advent of Code, and this is the first year I've completed it.  I
had a little help, specifically using the [Sprache](https://github.com/sprache/Sprache) parser builder
and beating up its [calculator example](https://github.com/sprache/Sprache/tree/develop/samples/LinqyCalculator)
to make the "bad" calculators needed for [problem 18](https://adventofcode.com/2020/day/18).

I originally wrote these as individual projects for each day, and they written slapdash to try to keep a high
ranking in a private leaderboard for each year.  In some cases, that led to "wall of code" solutions rather 
than elegant ones.  I've spent a few days since, cleaning them up, and doing some refactoring, but after
a while, it's time to put it aside and move on to something else.

I'll probably update this one more time for the option to use external input files.  For now,
the puzzle input is encoded in the application.

There's some rewrites after looking at other people's code over the past week that was written
in other languages such as C or Python.  I learned a few things from them, and it crept into my C#
as I switched from 25 individual projects into this monolith.

##Output

```text
----------------------------------------------------------------------
     Solving 25 problems
      1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15,
     16, 17, 18, 19, 20, 21, 22, 23, 24, 25
----------------------------------------------------------------------
  1 - Report Repair
        982464
        18 milliseconds
        162292410
        1 milliseconds

  2 - Password Philosophy
        666
        30 milliseconds
        670
        1 milliseconds

  3 - Toboggan Trajectory
        262
        0 milliseconds
        2698900776
        1 milliseconds

  4 - Passport Processing
        264
        8 milliseconds
        224
        32 milliseconds

  5 - Binary Boarding
        906
        0 milliseconds
        519
        1 milliseconds

  6 - Custom Customs
        7283
        1 milliseconds
        3520
        3 milliseconds

  7 - Handy Haversacks
        233
        3 milliseconds
        421550
        6 milliseconds

  8 - Handheld Halting
        2051
        9 milliseconds
        2304
        80 milliseconds

  9 - Encoding Error
        1212510616
        32 milliseconds
        171265123
        10 milliseconds

 10 - Adapter Array
        2574
        6 milliseconds
        2644613988352
        4 milliseconds

 11 - Seating System
        2438
        485 milliseconds
        2174
        509 milliseconds

 12 - Rain Risk
        757
        8 milliseconds
        51249
        2 milliseconds

 13 - Shuttle Search
        4722
        28 milliseconds
        825305207525452
        0 milliseconds

 14 - Docking Data
        10452688630537
        8 milliseconds
        2881082759597
        102 milliseconds

 15 - Rambunctious Recitation
        412
        3 milliseconds
        243
        4493 milliseconds

 16 - Ticket Translation
        20975
        2 milliseconds
        910339449193
        51 milliseconds

 17 - Conway Cubes
        336
        41 milliseconds
        2620
        3335 milliseconds

 18 - Operation Order
        5374004645253
        411 milliseconds
        88782789402798
        170 milliseconds

 19 - Monster Messages
        147
        35 milliseconds
        263
        358 milliseconds

 20 - Jurassic Jigsaw
        7492183537913
        16 milliseconds
        2323
        5 milliseconds

 21 - Allergen Assessment
        Part 1: 2779
        39 milliseconds
        lkv,lfcppl,jhsrjlj,jrhvk,zkls,qjltjd,xslr,rfpbpn
        16 milliseconds

 22 - Crab Combat
        36257
        4 milliseconds
        33304
        4905 milliseconds

 23 - Crab Cups
        54896723
        1 milliseconds
        138
        444 milliseconds

 24 - Lobby Layout
        438
        12 milliseconds
        4038
        8659 milliseconds

 25 - Combo Breaker
        16933668
        338 milliseconds
        Start Vacation!
        0 milliseconds

----------------------------------------------------------------------

```