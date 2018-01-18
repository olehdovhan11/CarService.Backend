﻿using CarService.DataAccess.Model;
using CarService.DbAccess.Entities;
using System;

namespace CarService.DataAccess.Model
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public int? DialogId { get; set; }
        public Dialog Dialog { get; set; }
    }
}