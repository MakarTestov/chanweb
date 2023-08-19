# Запуска через Docker

## Сборка образа (отдельно от VS)
Переходим в папку, где находится Dockerfile. 
Сборка образа происходит следующей командой:
```bash
docker build -t app/comscience:23.01 -f .\Dockerfile ../
```

Для запуска собранного образа запускаем следующую команду
```bash
docker run --name comscience -p 1100:1100 -e TZ="Europe/Moscow" -d app/comscience:23.01
```