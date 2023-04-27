# Этапы работы над проектом
## Реализация метода создания пользователем массива строк (_UserInput_).
Пользователь вводит размер **массива строк**, после чего он создается методом. Далее происходит проход по этому массиву в цикле "_for_" с предложением пользователю на каждом этапе итерации ввести в _i_-тую ячейку очередную строку. По завершению цикла метод возвращает **массив строк** _str_arr_.
## Реализация метода вывода массива строк (_ResultOutput_).
Метод принимает **массив строк**  проходит по нему в цикле "_for_", выводя на каждом этапе итерации _i_-тую строку.
## Реализация метода _CountCalculation_.
Строки заданной длины будут помещаться в **под-массив строк** (_sub_str_arr_).
Для создания **под-массива строк** необходимо знать его размер. Именно для этого используется метод _CountCalculation_. Метод принимает созданный пользователем на предыдущем этапе **массив строк** (_str_arr_), проходит по нему с проверкой _i_-той строки на соответствие условию: **строка имеет три или менее символа**. Если условие выполняется происходит инкремент переменной _count_. По завершению цикла метод возвращает _count_.
## Реализация метода _GetSubstringsArr_.
После того как размер **под-массива строк** стал известен, метод _GetSubstringsArr_ создает его (_sub_str_arr_) и на следующем этапе заполняет строками удовлетворяющих условию: **их длина три или менее символа**; которые берет из исходного **массива строк** (_str_arr_), после чего метод возвращает **под-массив строк** (_sub_str_arr_).