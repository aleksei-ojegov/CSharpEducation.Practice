Создайте библиотеку классов. Создайте там интерфейс ILogger с методоми

Trace(string), Info(string), Debug(string), Warning(string), Error(string), Fatal(string),

а также метод Log(string, LogLevel). Добавьте классы FileLogger и

ConsoleLogger, реализующие этот интерфейс. Реализованные методы должны

писатьв консоль/файл сообщения типа “<dateTime> | <class> | <logLevel> |

<message>”. Используйте эти классы для логирования операций в предыдущих

заданиях.
