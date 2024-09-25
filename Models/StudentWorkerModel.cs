using System.ComponentModel.DataAnnotations;

/***************************************************************
* Name         : StudentWorkerCalculator/C# Final
* Author       : Cory Howard
* Created      : 07/29/2024
* Course       : CIS 169 - C# 30430
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program lets a user input their student details, hourly pay and hours worked
*                and then calculates their weekly pay
*                      Input : decimal, double, strings
*                      Output: strings
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

// Not sure how well I did the requirements but I'm doing this while on vacation in Hawaii so it's a bit of a crunch

namespace C_SharpFinal.Models {
    public class StudentWorkerModel : StudentModel {

        [Required(ErrorMessage = "Please enter a valid number")]
        [Range(7.25, 14.75, ErrorMessage = "Please Enter a number between 7.25 and 14.75")]
        private decimal _hourlyRate; // can only be between 7.25 and 14.75

        [Required(ErrorMessage = "Please enter a valid number")]
        [Range(1, 15, ErrorMessage = "Please Enter a number between 1 and 15")]
        private double _hoursWorked; // can only be between 1 and 15

        const decimal RATE_MIN = 7.25M;
        const decimal RATE_MAX = 14.75M;

        const double WORKED_MIN = 1;
        const double WORKED_MAX = 15;

        public StudentWorkerModel() : base() {

            HourlyRate = 0; 
            HoursWorked = 0; 

        }

        public StudentWorkerModel(decimal hourlyRate, double hoursWorked, string name, string id) : base (name, id) {

            // fixes to min or max if too low or too high
            if (hourlyRate < RATE_MIN) {
                hourlyRate = RATE_MIN;
            } else if (hourlyRate > RATE_MAX) {
                hourlyRate = RATE_MAX;
            };

            if (hoursWorked < WORKED_MIN) {
                hoursWorked = WORKED_MIN;
            } else if (hoursWorked > WORKED_MAX) {
                hoursWorked = WORKED_MAX;
            };


            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public decimal HourlyRate { get => _hourlyRate; set => _hourlyRate = value; }
        public double HoursWorked { get => _hoursWorked; set => _hoursWorked = value; }


        // Calculates weekly pay for student worker by multiplying hourly rate and hours worked together.
        // If rate is not between $7.25 and $14.75, or hours worked is not between 1 and 15, return 0 as instructed.
        public decimal weeklySalary() {

            decimal weeklySalary = 0;

            if (HourlyRate < RATE_MIN || HourlyRate > RATE_MAX) {
                return weeklySalary;
            }

            if (HoursWorked < WORKED_MIN || HoursWorked > WORKED_MAX) {
                return weeklySalary;
            } else {
                weeklySalary = HourlyRate * Convert.ToDecimal(HoursWorked);
                return weeklySalary;
            }
        }
    }
}
