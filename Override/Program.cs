﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Класс «Сотрудник». Добавьте к уже созданному классу информацию о заработной плате сотрудника.Выполните перегрузку +,-,><,!=,==,Equals.
            //Clerk a = new Clerk("Karasik","28.07.2001","323223232","lol@gmail.com","Clerk","Does nothing but complain",10);
            //Clerk b = new Clerk("Karasik", "28.07.2001", "323223232", "lol@gmail.com", "Clerk", "Does nothing but complain", 10);

            //a += 10;

            //Console.WriteLine(a);

            //if(a > b)
            //{
            //    Console.WriteLine("A > B");
            //}

            //b+= 10;

            //if(a == b)
            //{
            //    Console.WriteLine("A == B");
            //}

            //if (a.Equals(b))
            //{
            //    Console.WriteLine("A and B are equal");
            //}
            #endregion
            #region #2 «Матрица». Выполните перегрузку + (для сложения матриц), – (для вычитания матриц). * (умножение матриц друг на друга, умножение матрицы на число), == (проверка матриц на равенство), != и Equals
            //try
            //{
            //    Matrix a = new Matrix(3,3);
            //    Matrix b = new Matrix(3,3);
            //    a.Random(1,10);
            //    b.Random(10,20);
            //    a.PrintMatrix();
            //    Console.WriteLine();
            //    b.PrintMatrix();
            //    Matrix c = a + b;
            //    Console.WriteLine();
            //    Console.WriteLine("Summ:");
            //    c.PrintMatrix();
            //    c = a - b;
            //    Console.WriteLine();
            //    Console.WriteLine("Substraction:");
            //    c.PrintMatrix();
            //    c = a * b;
            //    Console.WriteLine();
            //    Console.WriteLine("Multiplication:");
            //    c.PrintMatrix();
            //    a *= 2;
            //    Console.WriteLine();
            //    Console.WriteLine("Matrix a was multiplicated by 2:");
            //    a.PrintMatrix();

            //    Console.WriteLine();
            //    Matrix d1 = new Matrix(3,3);
            //    Matrix d2 = new Matrix(3,3);
            //    Console.WriteLine("D1:");
            //    d1.PrintMatrix();
            //    Console.WriteLine("D2:");
            //    d2.PrintMatrix();


            //    if (d1 == d2)
            //    {
            //        Console.WriteLine("D1 & D2 are equal");
            //    }
            //    Console.WriteLine();
            //    d2.Random(1,20);
            //    Console.WriteLine("D1:");
            //    d1.PrintMatrix();
            //    Console.WriteLine("D2:");
            //    d2.PrintMatrix();
            //    if (d1 != d2)
            //    {
            //        Console.WriteLine("D1 & D2 are not equal");
            //    }


            //}
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion
            #region #3 «Город». Выполните перегрузку + (для увеличения количества жителей на указанную величину), — (для уменьшения количества жителей на указанную величину), == (проверка на равенство двух городов по количеству жителей), < и >, !=,==
            //City Odesa = new City("Odesa","Ukraine","+380",5,10000000);
            //City Kharkiv = new City("Odesa", "Ukraine", "+380", 5, 10000000);
            //Console.WriteLine(Odesa.ToString());
            //Console.WriteLine();
            //Console.WriteLine(Kharkiv.ToString());
            //Console.WriteLine();
            //if (Odesa == Kharkiv)
            //{
            //    Console.WriteLine("Odesa and Kharkiv populations are equal");
            //}
            //Odesa += 100000;
            //Console.WriteLine(Odesa.ToString());
            //Console.WriteLine();
            //Console.WriteLine(Kharkiv.ToString());
            //Console.WriteLine();
            //if (Odesa > Kharkiv)
            //{
            //    Console.WriteLine("Odesa > Kharkiv populations");
            //}
            #endregion
            #region #4 «Кредитная карточка». Добавьте к уже созданному классу информацию о сумме денег на карте.Выполнитеперегрузку + (для увеличения суммы денег на указаннуювеличину), – , == (проверка на равенство CVC кода), < и >, !=
            //try
            //{
            //    CreditCard a = new CreditCard("Name","1234567890123456","123",6,25,100);
            //    a.PrintCardDetails();
            //    Console.WriteLine();
            //    a += 1000;
            //    a.PrintCardDetails();
            //    Console.WriteLine();
            //    a -= 1100;
            //    a.PrintCardDetails();
            //    CreditCard b = new CreditCard("Name2", "6234556890123456", "123", 6, 25, 100);
            //    Console.WriteLine("Card B:");
            //    b.PrintCardDetails();
            //    if(a == b)
            //    {
            //        Console.WriteLine("CVC of A and B are equal");
            //    }

            //}
            //catch(Exception ex)
            //{

            //    Console.WriteLine(ex.ToString());
            //}
            #endregion
        }
    }
}
