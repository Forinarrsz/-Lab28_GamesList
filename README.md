# Лабораторная работа №28. Веб-сервер на C#: список любимых игр

## Основная информация
- ФИО: Шувалова А.Е.
- Группа: ИСП-231
- Дата: 04.2026

## Описание проекта
REST API для управления списком игр, реализованное на ASP.NET Core с использованием архитектуры контроллеров. Данные хранятся в оперативной памяти сервера в статическом списке. Проект демонстрирует работу с основными HTTP-методами (GET, POST, PUT, DELETE), валидацию входных данных, возврат корректных статус-кодов и тестирование эндпоинтов через утилиту curl.

## Инструкция по запуску
```bash
cd GamesApi && dotnet run
```
Сервер запустится по адресу http://localhost:5000 (или другому порту, указанному в выводе терминала).

## Таблица маршрутов
| Метод | Маршрут | Описание | Статус ответа |
|-------|---------|----------|---------------|
| GET | /api/games | Получить все игры | 200 OK |
| GET | /api/games/{id} | Получить игру по ID | 200 OK / 404 Not Found |
| GET | /api/games/favourites | Получить только избранные игры | 200 OK |
| POST | /api/games | Добавить новую игру | 201 Created / 400 Bad Request |
| PUT | /api/games/{id} | Полностью обновить игру | 200 OK / 404 Not Found |
| DELETE | /api/games/{id} | Удалить игру | 204 No Content / 404 Not Found |

## Примеры curl-команд

### GET-запросы
```bash
# Получить все игры
curl http://localhost:5000/api/games

# Получить игру по ID
curl http://localhost:5000/api/games/1

# Получить избранные игры
curl http://localhost:5000/api/games/favourites

# Проверка статус-кода (вернёт 404)
curl -i http://localhost:5000/api/games/99
```

### POST (Создание)
```bash
# Успешное добавление
curl -X POST http://localhost:5000/api/games \
  -H "Content-Type: application/json" \
  -d "{\"title\":\"Stardew Valley\",\"genre\":\"Simulation\",\"releaseYear\":2016,\"isFavourite\":true}"

# Проверка валидации (пустое название вернёт 400)
curl -X POST http://localhost:5000/api/games \
  -H "Content-Type: application/json" \
  -d "{\"title\":\"\",\"genre\":\"RPG\",\"releaseYear\":2020}"
```

### PUT (Обновление)
```bash
curl -X PUT http://localhost:5000/api/games/2 \
  -H "Content-Type: application/json" \
  -d "{\"title\":\"The Witcher 3\",\"genre\":\"RPG\",\"releaseYear\":2015,\"isFavourite\":true}"
```

### DELETE (Удаление)
```bash
curl -X DELETE http://localhost:5000/api/games/1
```

## Технологии
- .NET 9 / ASP.NET Core
- Архитектура Controllers & Routing
- In-Memory Storage (List<T>)
- curl для тестирования HTTP-запросов
- Git & GitHub для версионирования
```
