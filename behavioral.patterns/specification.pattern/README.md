# Specification Pattern
- Specification pattern make business rules in chain with boolean result set. Write intention.

#### Use Specification Pattern
- Specify criteria for selection
- In-memory validation
- Retrieving data - like filtering

Specification -- Is Satisfied By --> Object

#### Benefits of the Specification Pattern
- Reduced coupling - Decoupling
- Separation of Concerns
- Avoiding domain knowledge duplication (DRY)
- Easier to test

##### Related Patterns
- Factory

Rules can use Func<T, bool> or Expression<Func<T,bool>>

Sample Boolean expression

```csharp
Func<Song, bool> topSongsPredicate = s => s.Rating > 4;
data.Songs.Where(topSongsPredicate);

Expression<Func<Song, bool>> topSongsExpression = s => s.Rating > 4;
data.Songs.Where(topSongsExpression.Compile());

// Reason why use expession instead of predicate. you can pass around an expression, 
// you can edit that expression and build upon it
```

Example: s => s.Rating > 3

