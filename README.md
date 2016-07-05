# nunit-3-with-nunit-2-base-class

Sample project showing how NUnit 3 does not discover tests with an NUnit 2 base class.

This is the repro for [nunit/nunit#1633](https://github.com/nunit/nunit/issues/1633).

I have two test classes:

1. `Tests` uses NUnit 3 and it's test is discovered by the NUnit 3 runner.
2. `DerivedTests` also uses NUnit 3, but it derives from a base class which uses the `[SetUp]` attribute from NUnit 2.  This test is not discovered by the NUnit 3 runner.


