﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiczbyPierwszeVer_1.Models
{
    public class MyNumber
    {
        [Required(ErrorMessage = "Podaj liczbę!!")]
        
        [Range(2,100,ErrorMessage = "Podaj liczbę z zakresu 2 do 100")]
        [Display(Name = "Podaj liczbę wierszy: ")]
        public int NumRows { get; set; }


        [Required(ErrorMessage = "Podaj liczbę!!")]
        [DataType("To musi być liczba")]
        [Range(2, 100, ErrorMessage = "Podaj liczbę z zakresu 2 do 100")]
        [Display(Name = "Podaj liczbę kolumn: ")]
        public int NumCols { get; set; }
    }
}