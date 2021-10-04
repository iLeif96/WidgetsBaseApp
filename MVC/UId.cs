namespace iLeif.MVC
{
    public struct UId
    {
        private static ulong _idsCounter = 0;
        private ulong _id;

        private UId(ulong id) => _id = id;

        public static UId Generate() => new(_idsCounter++);

        public override string ToString() => _id.ToString();
        public override bool Equals(object obj) => obj is UId uid && _id.Equals(uid._id);
    }
}
