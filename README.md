# Gilded Rose Refactoring Sample (C# / NUnit)

This repository contains my refactoring exercise based on the well-known
Gilded Rose kata originally created by Terry Hughes and popularized by
Emily Bache.

The goal of the kata is to safely improve a legacy codebase whose behavior
is defined by a growing set of item rules. The original implementation
relies heavily on conditional logic and is intentionally difficult to
extend.

My approach focuses on making the behavior easier to reason about and test
while preserving the existing behavior of the system.

---

## Where to Start

If reviewing the code, I recommend looking at the files in this order:

1. **ApprovalTest.cs**

   An approval test that captures the console output for 30 days of system
   behavior. This provides a safety net while refactoring the legacy logic.

2. **GildedRose.cs**

   The original legacy implementation that updates item quality.

3. **StandardMagicBox.cs / LegendaryMagicBox.cs**

   Examples of smaller components that encapsulate item-specific behavior.

4. **StandardItemMagicBoxTests.cs**

   Focused unit tests that document the rules for individual item types.

---

## Build

dotnet build GildedRose.sln

---

## Run the Program

Run the simulation for 10 days:

dotnet run --project GildedRose -- 10

---

## Run Tests

dotnet test

---

## Notes

The approval test included in this repository originates from the Emily
Bache version of the kata and serves as a characterization test for the
existing behavior of the system. It allows refactoring work to proceed
with confidence that externally visible behavior has not changed.