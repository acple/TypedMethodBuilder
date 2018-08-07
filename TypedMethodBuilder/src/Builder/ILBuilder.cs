namespace TypedMethodBuilder
{
    public static class IL
    {
        public static IL<Param<object, Empty>, Empty, Empty> MethodBuilder()
            => IL<Param<object, Empty>, Empty, Empty>.New;

        public static IL<Param<object, Param<T, Empty>>, Empty, Empty> MethodBuilder<T>()
            => IL<Param<object, Param<T, Empty>>, Empty, Empty>.New;

        public static IL<Param<object, Param<T, Param<T2, Empty>>>, Empty, Empty> MethodBuilder<T, T2>()
            => IL<Param<object, Param<T, Param<T2, Empty>>>, Empty, Empty>.New;

        public static IL<Param<object, Param<T, Param<T2, Param<T3, Empty>>>>, Empty, Empty> MethodBuilder<T, T2, T3>()
            => IL<Param<object, Param<T, Param<T2, Param<T3, Empty>>>>, Empty, Empty>.New;

        public static IL<Param<object, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, Empty, Empty> MethodBuilder<T, T2, T3, T4>()
            => IL<Param<object, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, Empty, Empty>.New;
    }

    public static class IL<TInstance>
        where TInstance : class
    {
        public static IL<Param<TInstance, Empty>, Empty, Empty> MethodBuilder()
            => IL<Param<TInstance, Empty>, Empty, Empty>.New;

        public static IL<Param<TInstance, Param<T, Empty>>, Empty, Empty> MethodBuilder<T>()
            => IL<Param<TInstance, Param<T, Empty>>, Empty, Empty>.New;

        public static IL<Param<TInstance, Param<T, Param<T2, Empty>>>, Empty, Empty> MethodBuilder<T, T2>()
            => IL<Param<TInstance, Param<T, Param<T2, Empty>>>, Empty, Empty>.New;

        public static IL<Param<TInstance, Param<T, Param<T2, Param<T3, Empty>>>>, Empty, Empty> MethodBuilder<T, T2, T3>()
            => IL<Param<TInstance, Param<T, Param<T2, Param<T3, Empty>>>>, Empty, Empty>.New;

        public static IL<Param<TInstance, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, Empty, Empty> MethodBuilder<T, T2, T3, T4>()
            => IL<Param<TInstance, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, Empty, Empty>.New;
    }
}
