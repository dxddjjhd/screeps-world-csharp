namespace Player
{
    public static class Entry
    {
        [Transpose.Name("tick")]
        public static void Tick() => Colony.Tick();
    }
}
