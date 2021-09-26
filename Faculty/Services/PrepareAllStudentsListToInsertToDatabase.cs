using Faculty.Interfaces;
using Faculty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculty.Services
{
    public class PrepareAllStudentsListToInsertToDatabase : IAllStudents
    {
        public IEnumerable<Student> Students 
        {
            get 
            {
                return new List<Student> {
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_1_SR_02"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_2_SR_02"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_3_SR_03"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_4_SR_06"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_5_SR_05"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_6_SR_03"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_7_SR_05"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_8_SR_06"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_9_SR_02"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_10_SR_01"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_11_SR_01"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_12_SR_05"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_13_SR_03"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_14_SR_06"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_15_SR_03"},
                new Student { GroupId = 4, FirstName = "Andy", LastName = "Jones_16_SR_04"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_17_SR_02"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_18_SR_05"},
                new Student { GroupId = 4, FirstName = "Andy", LastName = "Jones_19_SR_04"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_20_SR_05"},
                new Student { GroupId = 4, FirstName = "Andy", LastName = "Jones_21_SR_04"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_22_SR_03"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_23_SR_03"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_24_SR_01"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_25_SR_06"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_26_SR_02"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_27_SR_05"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_28_SR_02"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_29_SR_02"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_30_SR_02"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_31_SR_06"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_32_SR_02"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_33_SR_02"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_34_SR_05"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_35_SR_06"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_36_SR_01"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_37_SR_01"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_38_SR_03"},
                new Student { GroupId = 4, FirstName = "Andy", LastName = "Jones_39_SR_04"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_40_SR_06"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_41_SR_05"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_42_SR_05"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_43_SR_06"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_44_SR_01"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_45_SR_02"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_46_SR_05"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_47_SR_01"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_48_SR_03"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_49_SR_01"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_50_SR_06"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_51_SR_06"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_52_SR_03"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_53_SR_06"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_54_SR_01"},
                new Student { GroupId = 4, FirstName = "Andy", LastName = "Jones_55_SR_04"},
                new Student { GroupId = 6, FirstName = "Andy", LastName = "Jones_56_SR_06"},
                new Student { GroupId = 1, FirstName = "Andy", LastName = "Jones_57_SR_01"},
                new Student { GroupId = 5, FirstName = "Andy", LastName = "Jones_58_SR_05"},
                new Student { GroupId = 3, FirstName = "Andy", LastName = "Jones_59_SR_03"},
                new Student { GroupId = 2, FirstName = "Andy", LastName = "Jones_60_SR_02"} };
            }
        }
    }
}
