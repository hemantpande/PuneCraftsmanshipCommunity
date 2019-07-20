Our plan for refactoring (print this, keep handy)
What flow? Scheduling.

1. Remove any dead code.
2. Declare variables close to usage (may not be in our exact case, so tentative)
3. Understand what the code does.
3.a. Algorithm in simple English - all steps.
3.b. Collaborations - A sequence diagram can help.
4. Apply extract interface refactoring on collaborators. The class can still be tightlly coupled, but our code block should have loose coupling.
5. Choose first step in algorithm. Comment out that step.
6. Create a failing test for the step in the algorithm.
7. Uncomment the algorithm step, ensure test passes.
8. Refactor.
9. Repeat!