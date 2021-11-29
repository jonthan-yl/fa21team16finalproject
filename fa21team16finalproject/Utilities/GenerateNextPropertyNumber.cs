using Microsoft.AspNetCore.Identity;
using System;
using System.Text;
using System.Linq;
using fa21team16finalproject.Models;
using fa21team16finalproject.DAL;
using System.Threading.Tasks;

namespace fa21team16finalproject.Utilities
{
    public static class GenerateNextConfirmationNumber
    {
        public static Int32 GetNextConfirmationNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_NUMBER = 21901;

            Int32 intMaxPropertyNumber; //the current maximum course number
            Int32 intNextPropertyNumber; //the course number for the next class

            if (_context.Orders.Count() == 0) //there are no registrations in the database yet
            {
                intMaxPropertyNumber = START_NUMBER; //registration numbers start at 101
            }
            else
            {
                intMaxPropertyNumber = _context.Orders.Max(c => c.ConfirmationNumber); //this is the highest number in the database right now
            }

            //add one to the current max to find the next one
            intNextPropertyNumber = intMaxPropertyNumber + 1;

            //return the value
            return intNextPropertyNumber;
        }

    }
}