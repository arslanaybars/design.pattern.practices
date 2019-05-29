# Adapter Pattern

- A class that would be useful to your application does not implement the interface you require
- You are designing a class or a framework and you want to ensure it is usable by a wide variety of as-yet-unwritten classes and applications
- Adapters are also commonly known as Wrappers

!! Adapter pattern intent to convert the interface of a class into another interface clients expect

**Collabration :** Clientts call operations on an Adapter instance; Adapter instance calls Adaptee operations that carry out the request

##### Related Patterns
- Repository
- Strategy
- Faacade
