namespace Services
{
    public class UnityInputService : IInputService
    {
        public float HorizontalInput => UnityEngine.Input.GetAxis("Horizontal");
    }
}