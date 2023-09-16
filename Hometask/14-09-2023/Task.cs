using Hometask._14_09_2023;
using Microsoft.Win32;
using System.Security.Principal;

/*
Payment Demo App (Click)

1.User: register qilash bilan account yaratiladi, Telefon no'mer, Ism, familiya, UserName (Passport malumotlarini kiritishingiz mumkin).
  va default karta ham yaratiladi(balanse = 0, bu kartaga cashbacklar tushib turadi). 

  User{
    Id,
    Firstname,
    Lastname,
    PhoneNumber,
    ...
  }

  User malumotlarini filega yozing.

2.Card: userlar o'z kartalarini appimizga ulaydi (eslatma: userda default holda bitta karta generatsiya qilingan).
  Default holda kartada pul bo'lsin (10000, 50000, 100000 ...).

  Card{
    Id, // 16talik raqam
    ExpirationDate,
    ...
  }

  Card malumotlarini filega yozing.

  Bir foydalanuvchi bir nechta karta qo'shishligi mumkin.
  (-manfiy qiymat kiritilganda xatolik uchun #encapsulation dan foydalanishingizni tavsiya qilaman)

3.Payment: 
  Karta no'merni kiritgan holda o'tkazma qilinsin va bunda qo'shimcha 2% to'lov sistemasi uchun yechilsin
  va 1% keshback qaytarsin (cashback default kartaga tushsin, #delegate va #eventlardan foydalanishingiz ham mumkin). 

  Payment{
    Id,
    Amount,
    Date
    ...
  }

  To'lov yoki o'tkazma qilish dan oldin account egasini cartasidagi pulni tekshirish kerak
  va o'tkazma qilinayotgan kartani bazadan(filega yozilgan kartalar orasidan) qidirish kerak,
  agar karta bazada yo'q bo'lsa o'tkazma bekor qilinishi kerak.

  O'tkazma va Cash o'tkazma malumotlarini filega yozing.
  
4.Statistics:
  Account egasi oxirgi 1 oylik o'tkazmalar jami chiqimlar, Kirimlar, ro'yhatini olsin.  

5.Hohshingizga qarab qo'shimcha va tuzatishlar kiritishingiz mumkin 
  (balkim qo'shimcha modellar yozarsiz). */
