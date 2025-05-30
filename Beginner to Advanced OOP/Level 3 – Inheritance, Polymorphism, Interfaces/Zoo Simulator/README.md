# Zoo Simulator

## Goals
Base class <code>Animal</code>, derived classes <code>Lion</code>, <code>Elephant</code>, etc.

### Steps:
- Each animal overrides MakeSound()</code>.
- Store all animals in a <code>List\<Animal></code>.
- Loop through list and call <code>MakeSound()</code> on each.

<br/><br/>

# 🐾 Zoo Simulator – Level 3 Practice & Challenges

## ✅ Practice Tasks (Warm-up)

### 1. ➕ Add More Animals
- Create at least **3 new animal classes** (e.g., `Monkey`, `Tiger`, `Snake`)
- Override `MakeSound()` with appropriate sounds

---

### 2. 🎨 Add a `Describe()` Method
- Add a `virtual` method `Describe()` to the `Animal` class:
```csharp
public virtual void Describe()
{
    Console.WriteLine($"I am a {Name}.");
}
```
- Override it in derived classes to provide custom descriptions

---

### 3. 🐾 Loop Over `Describe()` and `MakeSound()`
- In your `Main()` method:
```csharp
foreach (Animal animal in zoo)
{
    animal.Describe();
    animal.MakeSound();
}
```

---

## ⭐ Extra Bonus Task: Use an Interface for Feeding

### 1. Define Interface
```csharp
public interface IFeedable
{
    void Eat();
}
```

### 2. Implement in Animals
```csharp
public class Lion : Animal, IFeedable
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} roars: ROAR!");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} the lion eats meat.");
    }
}
```

### 3. Loop and Feed Animals
```csharp
foreach (Animal animal in zoo)
{
    if (animal is IFeedable feedable)
    {
        feedable.Eat();
    }
}
```

---

## 🧠 Challenge Tasks (Harder)

### 1. 🏷 Add Animal Type with `enum`
```csharp
public enum AnimalType { Lion, Elephant, Monkey, Tiger, Snake }
```

Update `Animal`:
```csharp
public AnimalType Type { get; set; }

public Animal(string name, AnimalType type)
{
    Name = name;
    Type = type;
}
```

Update `Describe()`:
```csharp
public override void Describe()
{
    Console.WriteLine($"I am a {Type} named {Name}.");
}
```

---

### 2. ⏱ Add Random Behavior
Use `Random` to vary animal behavior:
```csharp
Random rnd = new Random();

public override void MakeSound()
{
    if (rnd.Next(0, 2) == 0)
        Console.WriteLine($"{Name} is sleeping...");
    else
        Console.WriteLine($"{Name} roars: ROAR!");
}
```

---

### 3. 🦁 Group Animals by Type
Group and count animals:
```csharp
var grouped = zoo.GroupBy(a => a.GetType().Name);

foreach (var group in grouped)
{
    Console.WriteLine($"{group.Key}: {group.Count()} animals");
}
```

---

### 4. 🎭 Use Abstract Class + Interface Combo
Each animal should:
- Inherit from `Animal`
- Implement both `ISoundMaker` and `IFeedable`

Test with:
```csharp
List<ISoundMaker> soundMakers = new List<ISoundMaker>();
List<IFeedable> feedables = new List<IFeedable>();
```

---

## 🚀 Next-Level Challenges (Advanced)

### 1. 📄 Save Zoo Data to File
- Serialize the zoo list to a file using `System.Text.Json` or `Newtonsoft.Json`
```csharp
File.WriteAllText("zoo.json", JsonSerializer.Serialize(zoo));
```

---

### 2. 📋 Load Zoo from File
- Read from `zoo.json` and rebuild the list of animals

---

### 3. 🎮 Add Basic Console UI
Create a simple menu:
- View all animals
- Add new animal
- Hear all sounds
- Feed all animals

Use a loop with `Console.ReadLine()` for interaction.

---

### 4. 🌐 Add ZooKeeper Class
Create a `ZooKeeper` class that can:
- Interact with any animal
- Feed, describe, or check animal types
- Keep logs of interactions

---

### 5. 📦 Use Dependency Injection (for future)
Structure code with interfaces and services to prepare for more complex architecture.


<br/><br/><br/>

## 🧠 Understanding Abstract Classes vs Interfaces

### 📚 Abstract Class vs Interface in C#

| Feature / Purpose                                        | **Abstract Class**                            | **Interface**                                         |
| -------------------------------------------------------- | --------------------------------------------- | ----------------------------------------------------- |
| Can have method implementation?                          | ✅ Yes – can include full method bodies        | 🚫 No (until C# 8+, which allows default methods)     |
| Can have fields?                                         | ✅ Yes                                         | 🚫 No                                                 |
| Can define constructors?                                 | ✅ Yes                                         | 🚫 No                                                 |
| Can inherit multiple?                                    | ❌ No – only one abstract or base class        | ✅ Yes – a class can implement many interfaces         |
| Can force derived classes to implement specific members? | ✅ Yes (`abstract` methods)                    | ✅ Yes (all members must be implemented)               |
| Use case                                                 | "Is-a" relationship – shared behavior & state | "Can-do" or "Can-be-used-as" – capability or contract |
| Instantiation                                            | ❌ Cannot instantiate directly                 | ❌ Cannot instantiate directly                         |

---

### ✅ Use an **Abstract Class** When:

1. **You have shared code** you want all subclasses to inherit.
2. **You want to prevent direct instantiation** of the base class.
3. **You expect to have future default logic** in the base class.

```csharp
public abstract class Animal
{
    public string Name { get; set; }

    public Animal(string name) => Name = name;

    public virtual void Describe()
    {
        Console.WriteLine($"I am {Name}, an animal.");
    }

    public abstract void MakeSound();
}
```

---

### ✅ Use an **Interface** When:

1. **You want to define a capability**, not a shared base identity.
2. **You want multiple unrelated classes to share a behavior**.
3. **You need to support multiple inheritance of behavior**.

```csharp
public interface IFeedable
{
    void Eat();
}

public interface ISoundMaker
{
    void MakeSound();
}
```

```csharp
public class Lion : Animal, IFeedable, ISoundMaker
{
    public override void MakeSound() => Console.WriteLine("ROAR!");

    public void Eat() => Console.WriteLine($"{Name} eats meat.");
}
```

---

### 🧠 Real-Life Analogy

- **Abstract class (`Animal`)**: A blueprint for a type of object. All animals share a common identity.
- **Interface (`IFeedable`)**: A contract or license. Anything that can be fed agrees to implement `Eat()`.

---

### 🚦 Rule of Thumb

- Use an **abstract class** when creating a base for a family of related types.
- Use an **interface** to declare a capability that unrelated types may share.
