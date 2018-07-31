namespace TypedMethodBuilder
{
    public static class IL<TInstance>
    {
        public static IL<Param<TInstance, Empty>, Empty, Empty> MethodBuilder()
            => new IL<Param<TInstance, Empty>, Empty, Empty>();

        public static IL<Param<TInstance, Param<T, Empty>>, Empty, Empty> MethodBuilder<T>()
            => new IL<Param<TInstance, Param<T, Empty>>, Empty, Empty>();

        public static IL<Param<TInstance, Param<T, Param<T2, Empty>>>, Empty, Empty> MethodBuilder<T, T2>()
            => new IL<Param<TInstance, Param<T, Param<T2, Empty>>>, Empty, Empty>();

        public static IL<Param<TInstance, Param<T, Param<T2, Param<T3, Empty>>>>, Empty, Empty> MethodBuilder<T, T2, T3>()
            => new IL<Param<TInstance, Param<T, Param<T2, Param<T3, Empty>>>>, Empty, Empty>();

        public static IL<Param<TInstance, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, Empty, Empty> MethodBuilder<T, T2, T3, T4>()
            => new IL<Param<TInstance, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, Empty, Empty>();
    }
}
