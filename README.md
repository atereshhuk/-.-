# Курсовая работа

Тема — **"Просмотр конфигурации ПК"**.

Язык программирования - **C#**. 
Среда разработки - **Visual Studio 2013**. 
Использовались: 
* класс Environment 
* класс DriveInfo
* пространство имен Microsoft.Win32.

Программа показывает: 
* ОC 
* Тип
* Имя машины
* Имя пользователя, который зашел в систему
* Информацию о БИОС (версия и дата)
* Информация о разделах жесткого диска (тип, файловая система, размер ОБЩИЙ, размер СВОБОДНЫЙ, имя диска)
* Информация о процессоре (ИД, название, кол.ядер, частота)

Программа простая. Можно ее расширять. 

P.S Есть проблема с выводом информации о дисководах. DriveInfo.VolumeName не может получить его название и программа падает
