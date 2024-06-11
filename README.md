# Roman-Numerals
A app that can convert integers to roman numerals


# The Problem

The Roman numeral system developed in Ancient Rome and was used throughout its Empire.

In this system, numbers are written using specific letters, each representing certain values. The letters are always uppercase, as there are no lowercase letters in the Roman alphabet. The letters are I, V, X, L, C, D, and M.

Your task is to develop a program that converts Indo-Arabic numbers to the Roman format and vice versa.

The rules for forming Roman numerals are presented below.

Each letter corresponds to a specific value:

I = 1

V = 5

X = 10

L = 50

C = 100

D = 500

M = 1000

By grouping the above letters, we can represent numbers according to a set of rules:

With the exception of V, L, and D, other numerals can be repeated a maximum of three times:

III = 3

XXX = 30

CCC = 300

MMM = 3000

For numbers from 4000 onwards, the digits are the same as for the units (IV, V, VI, VII, VIII, IX, X), but with a macron (bar) over the digit:

ĪV̄ = 4000

V̄ = 5000

V̄Ī = 6000

V̄ĪĪ = 7000

V̄ĪĪĪ = 8000

ĪX̄ = 9000

X̄ = 10000

When written to the right of larger numerals, I, X, and C are added to the values of the preceding numerals:

VIII = 5 + 1 + 1 + 1 = 8

LXII = 50 + 10 + 1 + 1 = 62

CLVIII = 158

MCXX = 1000 + 100 + 10 + 10 = 1120

But if the numerals I, X, and C are to the left of larger numerals, their values are subtracted, as in:

IV = 5 - 1 = 4

IX = 10 - 1 = 9

XC = 100 - 10 = 90
