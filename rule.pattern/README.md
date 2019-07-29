# Rule Pattern

- Consider using the Rules Pattern when you have a growing amount of conditional complexity
- Separate the logic of each individual rule and its effects into its own class
- Every rule is executed and the evaluator examines the results

##### Structure

```mermaid
graph LR
A[Evaluator] -- 0..1 --> B[Rule]
B -- 1..n --> A
C[ConcreteRule] --> B
