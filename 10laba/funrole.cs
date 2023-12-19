﻿﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace _10laba;

public class funrole
{
    public void adm(int userid)
    {
        bool pravda = true;
        while (pravda != false)
        {
            Console.Clear();
            user user = new user();
            pathjson pathjson = new pathjson();
            sotrudnik sotrudnik = new sotrudnik();
            List<user> users = Serialization.Deserialization<List<user>>(pathjson.pathdlyaavtoriz);
            List<sotrudnik> sotrudniks = Serialization.Deserialization<List<sotrudnik>>(pathjson.pathdlyasotrudnik);
            foreach (user user1 in users)
            {
                foreach (sotrudnik sotrudnik1 in sotrudniks)
                {
                    if (userid == sotrudnik1.user_id)
                    {
                        Console.Clear();
                        Console.WriteLine(" |-----------------------------------------------------------|");
                        Console.WriteLine($"           Вы залетели как adm, {sotrudnik1.namee}            ");
                        Console.WriteLine(" |-----------------------------------------------------------|");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("|-----------------------------------------------------------|");
                        Console.WriteLine("|                        Вы adm                             |");
                        Console.WriteLine("|-----------------------------------------------------------|");

                    }
                }
            }

            int i = 1;
            foreach (user user2 in users)
            {
                Console.WriteLine($"     {i++}  {user2.Login}");
            }

            var adm = new admin();
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Z:
                    adm.dobavlenie();
                    break;
                case ConsoleKey.X:
                    adm.izmen();
                    break;
                case ConsoleKey.C:
                    adm.ydal();
                    break;
                case ConsoleKey.E:
                    pravda = false;
                    break;
                default:
                    var vibor = adm.CursorMenu(3, users.Count + 2) - 3; //то что рисунки в паинте ебать ахуеть
                    Console.Clear();
                    Console.WriteLine(
                        $"ID: {users[vibor].id}\nЛогин: {users[vibor].Login}\nПароль: {users[vibor].Password}\nРоль: {users[vibor].role}");
                    Console.ReadKey();
                    break;
            }
        }
    }
// готово фууулллл

    public void tipovbral(int userid)
    {
        bool pravda = true;
        while (pravda != false)
        {
            Console.Clear();
            user user = new user();
            pathjson pathjson = new pathjson();
            sotrudnik sotrudnik = new sotrudnik();
            List<sotrudnik> sotrudniks = Serialization.Deserialization<List<sotrudnik>>(pathjson.pathdlyasotrudnik) ??
                                         new List<sotrudnik>();
            List<user> users = Serialization.Deserialization<List<user>>(pathjson.pathdlyaavtoriz) ?? new List<user>();
            foreach (sotrudnik sotrudnik1 in sotrudniks)
            {
                if (userid == sotrudnik1.user_id)
                {
                    Console.Clear();
                    Console.WriteLine(" |-----------------------------------------------------------|");
                    Console.WriteLine($"       Вы залетели как tipovbral, {sotrudnik1.namee}         ");
                    Console.WriteLine(" |-----------------------------------------------------------|");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("|-----------------------------------------------------------|");
                    Console.WriteLine("|                      Вы tipovbral                         |");
                    Console.WriteLine("|-----------------------------------------------------------|");
                }
            }

            int i = 1;
            foreach (sotrudnik sotrudnik2 in sotrudniks)
            {
                Console.WriteLine($"     {i++}  {sotrudnik2.namee}");
            }

            var tipovbral = new tipovbral();
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Z:
                    tipovbral.dobavlenie();
                    break;
                case ConsoleKey.X:
                    tipovbral.izmen();
                    break;
                case ConsoleKey.C:
                    tipovbral.ydal();
                    break;
                case ConsoleKey.E:
                    pravda = false;
                    break;
                default:
                    var vibor = tipovbral.CursorMenu(3, sotrudniks.Count + 2) -
                                3; //то что рисунки в паинте ебать ахуеть
                    Console.Clear();
                    Console.WriteLine($"ID: {sotrudniks[vibor].id}\n" +
                                      $"Фамилия: {sotrudniks[vibor].surname}\n" +
                                      $"Имя: {sotrudniks[vibor].namee}\n" +
                                      $"Отчество: {sotrudniks[vibor].middlename}\n" +
                                      $"Дата рождения: {sotrudniks[vibor].datarod}\n" +
                                      $"Паспорт: {sotrudniks[vibor].passportNomSer}\n" +
                                      $"Должность: {sotrudniks[vibor].dolshnost}\n" +
                                      $"Зарплата: {sotrudniks[vibor].zp}\n" +
                                      $"ID юзера: {sotrudniks[vibor].user_id}");
                    Console.ReadKey();
                    break;
            }
        }
    }
    // работает фулл 


    public void skladmen(int userid)
    {
        bool pravda = true;
        while (pravda != false)
        {
            Console.Clear();
            user user = new user();
            pathjson pathjson = new pathjson();
            tovar tovar = new tovar();
            List<sotrudnik> sotrudniks = Serialization.Deserialization<List<sotrudnik>>(pathjson.pathdlyasotrudnik);
            List<user> users = Serialization.Deserialization<List<user>>(pathjson.pathdlyaavtoriz) ?? new List<user>();
            List<tovar> tovars = Serialization.Deserialization<List<tovar>>(pathjson.pathdlyasklad);
            foreach (sotrudnik sotrudnik in sotrudniks)
            {
                if (sotrudnik.user_id == userid)
                {
                    Console.Clear();
                    Console.WriteLine(" |-----------------------------------------------------------|");
                    Console.WriteLine($"       Вы залетели как skladmen, {sotrudnik.namee}          ");
                    Console.WriteLine(" |-----------------------------------------------------------|");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("|-----------------------------------------------------------|");
                    Console.WriteLine("|                      Вы skladmen                          |");
                    Console.WriteLine("|-----------------------------------------------------------|");

                }
            }

            int i = 1;
            foreach (tovar tovar1 in tovars)
            {
                Console.WriteLine($"     {i++}  {tovar1.naimenovanie}");
            }

            var skladmen = new skladmen();
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Z:
                    skladmen.dobavlenie();
                    break;
                case ConsoleKey.X:
                    skladmen.izmen();
                    break;
                case ConsoleKey.C:
                    skladmen.ydal();
                    break;
                case ConsoleKey.E:
                    pravda = false;
                    break;
                default:
                    var vibor = skladmen.CursorMenu(3, tovars.Count + 2) - 3; //то что рисунки в паинте ебать ахуеть
                    Console.Clear();
                    Console.WriteLine(
                        $"ID: {tovars[vibor].id}\nНаименование: {tovars[vibor].naimenovanie}\nКоличество: {tovars[vibor].skokavsego}\nЦена за штуку: {tovars[vibor].odnashtykacena}");
                    Console.ReadKey();
                    break;
            }
        }
    }
    // криво но работает 

    public void prodashnik(int userid)
    {
        Console.Clear();
        var skladmen = new skladmen();

        pathjson pathjson = new pathjson();
        var tovars = Serialization.Deserialization<List<tovar>>(pathjson.pathdlyasklad);
        var sotrudniks = Serialization.Deserialization<List<sotrudnik>>(pathjson.pathdlyasotrudnik);
        foreach (sotrudnik sotrudnik in sotrudniks)
        {
            if (sotrudnik.user_id == userid)
            {
                Console.Clear();
                Console.WriteLine(" |-----------------------------------------------------------|");
                Console.WriteLine($"       Вы залетели как prodashnik, {sotrudnik.namee}         ");
                Console.WriteLine(" |-----------------------------------------------------------|");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("|-----------------------------------------------------------|");
                Console.WriteLine("|                      Вы prodashnik                        |");
                Console.WriteLine("|-----------------------------------------------------------|");


            }
        }

        int i = 1;
        foreach (tovar tovar in tovars)
        {
            Console.WriteLine($"     {i++}  {tovar.naimenovanie}");
        }

        var key = new ConsoleKeyInfo();
        var r = 0;
        while (key.KeyChar != 'e')
        {
            Console.Clear();
            var vibor = skladmen.CursorMenu(3, tovars.Count + 2) - 3;
            
            var end = true;
            while (end)
            {
                
                Console.WriteLine($"Выбран товар {tovars[vibor].naimenovanie}  на складе {tovars[vibor].skokavsego}" +
                                  $"Кол-во {r}");
                var colvo = tovars[vibor].skokavsego;
                var price = tovars[vibor].odnashtykacena;
                key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case '+':
                        if (r < colvo)
                        {
                            r++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Столько нет на складе");
                        }

                        break;
                    case '-':
                        if (r > 0) r--;

                        break;
                    case 's':

                        var pokypkas = Serialization.Deserialization<List<pokypka>>(pathjson.pathpokypki);

                        var all_prise = price * r;
                        tovars[vibor].skokavsego = colvo - r;
                        
                        var pokyp = new pokypka();
                        pokyp.skokavsego = colvo - r;
                        pokyp.cenavsego = all_prise;
                        pokyp.chokupili = tovars[vibor].naimenovanie;
                        pokypkas.Add(pokyp);
                        
                        Serialization.Sirialize(pokypkas,pathjson.pathpokypki);
                        Serialization.Sirialize(tovars,pathjson.pathdlyasklad);
                        
                        

                        
                        end = false;
                        break;

                        Console.ReadKey();



                }


            }
        }
    }
}
        