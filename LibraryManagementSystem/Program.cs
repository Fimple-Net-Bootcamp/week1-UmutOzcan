using LibraryManagementSystem;

Library library = new();

Book book1 = new( 1, "The Witcher", new DateTime(2001, 01, 01), "Andrzej Sapkowski");
Book book2 = new( 2, "The Wizard of Oz", new DateTime(2002, 02, 02), "L. Frank Baum");
Book book3 = new( 3, "1984", new DateTime(2003, 03, 03), "George Orwell");
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

Member member1 = new()
{
    Name = "Umut",
    Surname = "Ozcan",
    No = 101
};
Member member2 = new()
{
    Name = "Yusuf",
    Surname = "Ozcan",
    No = 102
};

// Anlık Kütüphane Durumu
library.Print();

// Kütüphane üye kayıtları
library.AddMember(member1);
library.AddMember(member2);

// Kitap ödünç verme 
library.BorrowBook(book1, member1);
library.BorrowBook(book2, member2);

library.Print();

// Kitabı geri verme
library.ReturnBook(book2, member2);
library.ReturnBook(book1, member1);

Console.ReadKey();