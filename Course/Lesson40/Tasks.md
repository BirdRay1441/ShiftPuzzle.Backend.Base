Итоговый урок курса.


---
# Практика А-B:

1. Пройти тест по основа C#


---
# Практика B:

1. Пройти тест по основа ASP.NET


---
# Практика С:

**Техническое задание**

**Название проекта:** Сервис поиска и добавления попутчиков для доставки

**Описание проекта:** Создание веб-сервиса для поиска и добавления попутчиков, которые могут помочь в доставке грузов или пассажиров в определенном направлении.

**Требования к API:**
1. **Поиск попутчиков по направлению:** 
    - Метод: GET
    - Путь: /api/carpool/search
    - Параметры запроса: 
        - origin (начальная точка)
        - destination (конечная точка)
    - Ответ: Список попутчиков, удовлетворяющих указанным критериям.

2. **Добавление попутчика:**
    - Метод: POST
    - Путь: /api/carpool/add
    - Тело запроса (формат JSON):
        ```
        {
            "name": "Имя попутчика",
            "date": "Дата путешествия",
            "reward": "Вознаграждение за перевозку"
        }
        ```
    - Ответ: Подтверждение успешного добавления попутчика.

3. **Удаление попутчика:**
    - Метод: DELETE
    - Путь: /api/carpool/{id}
    - Параметры запроса: 
        - id (идентификатор попутчика)
    - Ответ: Подтверждение успешного удаления попутчика.

**Данные попутчика:**
- Имя (name): Строка, не более 255 символов.
- Дата (date): Дата путешествия в формате YYYY-MM-DD.
- Вознаграждение за перевозку (reward): Число, представляющее собой сумму денег за перевозку.

**Ссылка на репозиторий:**
Скиньте в форму: 

**Примечания:**
- Для хранения данных о попутчиках может быть использована база данных SQLite или любая другая подходящая технология.
- API может быть защищено с помощью механизма аутентификации, например, с помощью токенов JWT. (есило сложно можно не делать) 