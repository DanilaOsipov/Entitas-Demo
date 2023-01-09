using Entitas;
using Entitas.CodeGeneration.Attributes;
using Services;

namespace InputComponents
{
    [Unique, Input] public class InputService : IComponent { public IInputService Value; }
}