﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterRaveCard.Models.Card
{
    public class Card
    {
        public Card(string cardNo, string expirymonth, string expiryyear, string cvv, string txref)
        {
            CardNo = cardNo;
            Expirymonth = expirymonth;
            Expiryyear = expiryyear;
            Cvv = cvv;
            TxRef = txref;
        }

        public Card(string cardNo, string expirymonth, string expiryyear, string cvv, string pin)
        {
            CardNo = cardNo;
            Expirymonth = expirymonth;
            Expiryyear = expiryyear;
            Cvv = cvv;
            Pin = pin;
        }

        public string CardNo { get; set; }
        public string Expirymonth { get; set; }
        public string Expiryyear { get; set; }
        public string Cvv { get; set; }
        public string Pin { get; set; }
        public string TxRef { get; set; }

    }
}