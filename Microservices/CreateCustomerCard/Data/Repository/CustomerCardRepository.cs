using System;
using System.Collections.Generic;
using System.Linq;
using TDonCashless.Microservices.CreateCustomerCard.Data.Context;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Interfaces;
using TDonCashless.Microservices.CreateCustomerCard.Domain.Models;

namespace TDonCashless.Microservices.CreateCustomerCard.Data.Repository
{
    public class CustomerCardRepository : ICustomerCardRepository
    {
        private CustomerCardDbContext _ctx;

        public CustomerCardRepository(CustomerCardDbContext ctx)
        {
            _ctx = ctx;
        }

        public long CreateCardToken(long cardNumber, int cvv)
        {
            var cardNumberAsString = cardNumber.ToString();
            var lastFourDigits = cardNumberAsString.Substring(cardNumberAsString.Length - 4, 4);

            var numberOfRotations = cvv;
            int[] numberArray = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Int32.TryParse(Convert.ToString(lastFourDigits[i]), out numberArray[i]);
            }

            return RightCircularRotationRecursive(numberArray, numberOfRotations);
        }

        private long RightCircularRotationRecursive(int[] numberArray, int rotations)
        {
            if (rotations > 0)
            {
                int temp = 0;

                for (int i = 0; i < numberArray.Length - 1; i++)
                {    
                    temp = numberArray[0];
                    numberArray[0] = numberArray[i + 1];
                    numberArray[i + 1] = temp;
                }

                return RightCircularRotationRecursive(numberArray, rotations - 1);
            }
            else
            {
                var result = "";

                foreach (var number in numberArray)
                {
                    result += number.ToString();
                }

                return Convert.ToInt64(result);
            }
        }

        public IEnumerable<CustomerCard> GetCustomerCards()
        {
            return _ctx.CustomerCards;
        }

        public CustomerCard InsertNewCustomerCard(CustomerCard card)
        {
            _ctx.CustomerCards.Add(card);

            _ctx.SaveChanges();

            return card;
        }

        public CustomerCard GetCustomerCardById(int customerCardId)
        {
            return _ctx.CustomerCards.Single(cc => cc.CustomerCardId == customerCardId);
        }

        public CustomerCardLog InsertNewLogCustomerCardCreation(CustomerCard newCard)
        {
            var logRecord = new CustomerCardLog()
            {
                CustomerCardId = newCard.CustomerCardId,
                CustomerId = newCard.CustomerId,
                CardNumber = newCard.CardNumber,
                CVV = newCard.CVV,
                RegistrationDate = newCard.RegistrationDate,
                Token = newCard.Token
            };

            _ctx.Add(logRecord);

            _ctx.SaveChanges();

            return logRecord;
        }
    }
}