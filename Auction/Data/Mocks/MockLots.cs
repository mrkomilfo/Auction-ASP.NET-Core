﻿using Auction.Data.Interfaces;
using Auction.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Data.Mocks
{
    public class MockLots : ILots
    {
        public IEnumerable<Lot> Lots
        {
            get
            {
                return new List<Lot>
                {
                    new Lot
                    {
                        name = "Jeep Grand Cherokee WK2 Laredo",
                        desc = "Авто в идеальном состоянии, пробег родной, крашенных элементов нет",
                        image = "/img/Jeep.jpg",
                        year = 2011,
                        transmission = 0,
                        engineVolume = 3.6,
                        fuel = 0,
                        body = 0,
                        drive = 2,
                        mileage = 69000,
                        price = 30000,
                        premium = true,
                        exposing = new DateTime(2019, 9, 2, 23, 0, 0),
                        ending = new DateTime(2019, 10, 2, 23, 0, 0),
                    },

                    new Lot
                    {
                        name = "Skoda Octavia II",
                        desc = "В отличном техническом состоянии",
                        image = "/img/Audi.jpg",
                        year = 2010,
                        transmission = 1,
                        engineVolume = 1.4,
                        fuel = 0,
                        body = 10,
                        drive = 1,
                        mileage = 163000,
                        price = 14000,
                        premium = false,
                        exposing = new DateTime(2019, 9, 2, 23, 0, 0),
                        ending = new DateTime(2019, 10, 2, 23, 0, 0),
                    },

                    new Lot
                    {
                        name = "SEAT Altea I",
                        desc = "В машине все работает, колеса 16, ТО до августа 2020г",
                        image = "/img/Seat.jpg",
                        year = 2013,
                        transmission = 1,
                        engineVolume = 1.4,
                        fuel = 0,
                        body = 6,
                        drive = 1,
                        mileage = 94000,
                        price = 22000,
                        premium = true,
                        exposing = new DateTime(2019, 9, 2, 23, 0, 0),
                        ending = new DateTime(2019, 10, 2, 23, 0, 0),
                    },

                    new Lot
                    {
                        name = "Opel Insignia I cosmo",
                        desc = "Автомобиль в отличном состоянии. Технически исправен.Масло от замены до замены. Экономичный.",
                        image = "/img/Opel.jpg",
                        year = 2011,
                        transmission = 0,
                        engineVolume = 2.0,
                        fuel = 1,
                        body = 9,
                        drive = 1,
                        mileage = 157000,
                        price = 22000,
                        premium = true,
                        exposing = new DateTime(2019, 9, 2, 23, 0, 0),
                        ending = new DateTime(2019, 10, 2, 23, 0, 0),
                    },
                };
            }
        }

        public Lot getLot(int lotId)
        {
            throw new NotImplementedException();
        }
    }
}
