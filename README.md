# KT_25_DefaultFactory

# Вариант 1. Фабрика по умолчанию
1) Интерфейс IInitializable { void Initialize(); }.
2) Классы DefaultUser : IInitializable и DefaultSettings : IInitializable, каждый со своим конструктором без параметров и своей реализацией Initialize() (заполняет поля значениями по умолчанию).
3) Обобщённый метод T CreateAndInitialize<T>() where T : IInitializable, new(), создающий объект и вызывающий Initialize().
4) Продемонстрируйте вызов для DefaultUser и DefaultSettings.
5) Продемонстрируйте (закомментированным кодом с пояснением или отдельным экспериментом), что без new() строка new T() не компилируется.

# Результаты и проверочные ключи
<img width="1351" height="228" alt="изображение" src="https://github.com/user-attachments/assets/e985ecf5-83e6-4273-8db8-85f0c74d8721" />

# Мои результаты:
<img width="857" height="210" alt="изображение" src="https://github.com/user-attachments/assets/cb154f08-66b4-4540-8332-8fa394c317d4" />

# А также мой результат с ошибкой компиляции CS0304 на строке new T():
<img width="1918" height="1137" alt="изображение" src="https://github.com/user-attachments/assets/b0743eb9-cdb0-46f0-b6cb-5708a2c92171" />
<img width="1696" height="240" alt="изображение" src="https://github.com/user-attachments/assets/89fbcd34-16a0-45e7-b0bc-dfe590643589" />
