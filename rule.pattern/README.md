# Rule Pattern

- Every rule is executed and the evaluator examines the results

#####Structure

```mermaid
graph LR
A[Evaluator] -- 0..1 --> B[Rule]
B -- 1..n --> A
C[ConcreteRule] --> B
