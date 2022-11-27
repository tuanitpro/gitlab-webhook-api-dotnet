# Gitlab Webhook API using .NET 7

WebHook for GibLab CI/CD. Should be sending a message to your Telegram bot when Gitlab CI running.

Using .NET 7 with love.

## How to start

1. With VScode

   `dotnet run`

   `dotnet start`

2. With docker-compose
   `docker-compose up`

## How to build
`docker-compose build` or `dotnet build`

## Run Production as Docker
`docker run -p 5009:5009 -e "TelegramOptions__TelegramToken=YOUR_TELEGRAM_TOKEN"  -e "TelegramOptions__TelegramChatId=YOUR_TELEGRAM_CHAT_ID"  tuanitpro/gitlab_webhook`