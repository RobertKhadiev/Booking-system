Миграция в postgresql: 
disk:\path\Aero-booking-system> 
dotnet ef database update --project ../Aero-booking-system.DAL

Тестовые данные:
INSERT INTO public."Restaurants" ("Name", "AvgPrice", "AvgServiceTime", "CreatedAt") VALUES ('Karavella', 2000, 30, NOW());
INSERT INTO public."Restaurants" ("Name", "AvgPrice", "AvgServiceTime", "CreatedAt") VALUES ('Molodost', 1000, 15, NOW());
INSERT INTO public."Restaurants" ("Name", "AvgPrice", "AvgServiceTime", "CreatedAt") VALUES ('Myaso i salat', 1500, 60, NOW());

Не реализовано: Распределение клиентов по столам, проверка входящих данных.