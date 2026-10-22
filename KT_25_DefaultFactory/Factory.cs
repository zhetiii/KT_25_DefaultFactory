namespace KT_25_DefaultFactory
{
    public static class Factory
    {
        public static T CreateAndInitialize<T>() where T : IInitializable, new()
        {
            T item = new T();
            item.Initialize();
            return item;
        }

        /* 
         * Демонстрация:
         * Если убрать ограничение `new()`, то строка `T item = new T();` 
         * выдаст ошибку компиляции CS0304, так как компилятор не знает, 
         * есть ли у типа T доступный конструктор без параметров.
         * 
         * public static T InvalidCreate<T>() where T : IInitializable
         * {
         *     T item = new T(); // Ошибка CS0304
         *     return item;
         * }
         */
    }
}
