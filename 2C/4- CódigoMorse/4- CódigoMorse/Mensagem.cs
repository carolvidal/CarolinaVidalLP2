﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__CódigoMorse
{
    class Mensagem
    {
        public string txt { get; set; }
        private char[] letra = new char[]
        {
            'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
        };
        private string[] tab = new string[]
        {
            ".-", "-...", "-.-.", "-..", ".",
            "..-.", "--.", "....", "..", ".---",
            "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-",
            "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        public string Codificar()
        {
            string codigo = "", morse = "";

            Console.WriteLine("Mensagem:");
            txt = Console.ReadLine();

            for (int i = 0; i < txt.Length; i++)
            {
                for (int p = 0; p < 26; p++)
                {
                    if (txt[i] == letra[p])
                    {
                        morse = tab[p];
                    }
                }

                string cod = morse + " ";
                codigo += cod;
            }

            return codigo;
        }

        public string Decodificar()
        {
            string mensagem = "";
            char caracter = ' ';

            Console.WriteLine("Mensagem:");
            txt = Console.ReadLine();

            string[] codigo = txt.Split(' ');

            for (int i = 0; i < codigo.Length; i++)
            {
                for (int p = 0; p < 26; p++)
                {
                    if (codigo[i] == tab[p])
                    {
                        caracter = letra[p];
                    }
                }

                char cod = caracter;
                mensagem += cod;
            }

            return mensagem;
        }
    }
}
