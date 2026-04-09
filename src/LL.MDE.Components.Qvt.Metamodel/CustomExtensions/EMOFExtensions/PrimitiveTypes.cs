using LL.MDE.Components.Qvt.Metamodel.EMOF;

namespace LL.MDE.Components.Qvt.Metamodel.EMOFExtensions
{
    public static class PrimitiveTypes
    {
        public static readonly IPrimitiveType BOOLEAN = new PrimitiveType() { Name = "bool" };
        public static readonly IPrimitiveType INTEGER = new PrimitiveType() { Name = "int" };
        public static readonly IPrimitiveType REAL = new PrimitiveType() { Name = "double" };
        public static readonly IPrimitiveType STRING = new PrimitiveType() {Name = "string"};
        public static readonly IPrimitiveType UNLIMITEDNATURAL = new PrimitiveType() { Name = "unlimitednatural" };
    }
}