
using System;
using System.Collections.Generic;

namespace Slats.Models

{
    public class Quarter
    {
        public int Id { get; set; }
        public int FY { get; set; }
        public int CY { get; }
        public int CyQuarter { get; }
        public int QuarterNum { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string QuarterCode { get; set; }
        public string CyQuarterCode { get; set; }

        public Quarter(int id, int fy, int quarterNum, int cy, int cyQuarter, DateTime start, DateTime end, string quarterCode, string cyQuarterCode)
        {
            Id = id;
            FY = fy;
            QuarterNum = quarterNum;
            CY = cy;
            CyQuarter = cyQuarter;
            Start = start;
            End = end;
            QuarterCode = quarterCode;
            CyQuarterCode = cyQuarterCode;
        }
    }

    public class Quarters
    {
        List<Quarter> Qrt = new List<Quarter>();

        public Quarters()
        {            
            Qrt.Add(new Quarter(1, 2015, 1, 2014, 4, new DateTime(2014, 10, 1), new DateTime(2014, 12, 31), "FY15Q1", "CY14Q4"));
            Qrt.Add(new Quarter(2, 2015, 2, 2015, 1, new DateTime(2015, 1, 1), new DateTime(2015, 3, 31), "FY15Q2", "CY15Q1"));
            Qrt.Add(new Quarter(3, 2015, 3, 2015, 2, new DateTime(2015, 4, 1), new DateTime(2015, 6, 30), "FY15Q3", "CY15Q2"));
            Qrt.Add(new Quarter(4, 2015, 4, 2015, 3, new DateTime(2015, 7, 1), new DateTime(2015, 9, 31), "FY15Q4", "CY15Q3"));
            Qrt.Add(new Quarter(5, 2016, 1, 2015, 4, new DateTime(2015, 9, 1), new DateTime(2015, 12, 31), "FY16Q1", "CY15Q4"));
            Qrt.Add(new Quarter(6, 2016, 2, 2016, 1, new DateTime(2016, 1, 1), new DateTime(2016, 3, 31), "FY16Q2", "CY16Q1"));
            Qrt.Add(new Quarter(7, 2016, 3, 2016, 2, new DateTime(2016, 4, 1), new DateTime(2016, 6, 30), "FY16Q3", "CY16Q2"));
            Qrt.Add(new Quarter(8, 2016, 4, 2016, 3, new DateTime(2016, 7, 1), new DateTime(2016, 9, 31), "FY16Q4", "CY16Q3"));
            Qrt.Add(new Quarter(9, 2017, 1, 2016, 4, new DateTime(2016, 9, 1), new DateTime(2016, 12, 31), "FY17Q1", "CY16Q4"));
            Qrt.Add(new Quarter(10, 2017, 2, 2017, 1, new DateTime(2017, 1, 1), new DateTime(2017, 3, 31), "FY17Q2", "CY17Q1"));
            Qrt.Add(new Quarter(11, 2017, 3, 2017, 2, new DateTime(2017, 4, 1), new DateTime(2017, 6, 30), "FY17Q3", "CY17Q2"));
            Qrt.Add(new Quarter(12, 2017, 4, 2017, 3, new DateTime(2017, 7, 1), new DateTime(2017, 9, 31), "FY17Q4", "CY17Q3"));
            Qrt.Add(new Quarter(13, 2018, 1, 2017, 4, new DateTime(2017, 9, 1), new DateTime(2017, 12, 31), "FY18Q1", "CY17Q4"));
            Qrt.Add(new Quarter(14, 2018, 2, 2018, 1, new DateTime(2018, 1, 1), new DateTime(2018, 3, 31), "FY18Q2", "CY18Q1"));
            Qrt.Add(new Quarter(15, 2018, 3, 2018, 2, new DateTime(2018, 4, 1), new DateTime(2018, 6, 30), "FY18Q3", "CY18Q2"));
            Qrt.Add(new Quarter(16, 2018, 4, 2018, 3, new DateTime(2018, 7, 1), new DateTime(2018, 9, 31), "FY18Q4", "CY18Q3"));
            Qrt.Add(new Quarter(17, 2019, 1, 2018, 4, new DateTime(2018, 9, 1), new DateTime(2018, 12, 31), "FY19Q1", "CY18Q4"));
            Qrt.Add(new Quarter(18, 2019, 2, 2019, 1, new DateTime(2019, 1, 1), new DateTime(2019, 3, 31), "FY19Q2", "CY19Q1"));
            Qrt.Add(new Quarter(19, 2019, 3, 2019, 2, new DateTime(2019, 4, 1), new DateTime(2019, 6, 30), "FY19Q3", "CY19Q2"));
            Qrt.Add(new Quarter(20, 2019, 4, 2019, 3, new DateTime(2019, 7, 1), new DateTime(2019, 9, 31), "FY19Q4", "CY19Q3"));
            Qrt.Add(new Quarter(21, 2020, 1, 2019, 4, new DateTime(2019, 9, 1), new DateTime(2019, 12, 31), "FY20Q1", "CY19Q4"));
            Qrt.Add(new Quarter(22, 2020, 2, 2020, 1, new DateTime(2020, 1, 1), new DateTime(2020, 3, 31), "FY20Q2", "CY20Q1"));
            Qrt.Add(new Quarter(23, 2020, 3, 2020, 2, new DateTime(2020, 4, 1), new DateTime(2020, 6, 30), "FY20Q3", "CY20Q2"));
            Qrt.Add(new Quarter(24, 2020, 4, 2020, 3, new DateTime(2020, 7, 1), new DateTime(2020, 9, 31), "FY20Q4", "CY20Q3"));
            Qrt.Add(new Quarter(25, 2021, 1, 2020, 4, new DateTime(2020, 9, 1), new DateTime(2020, 12, 31), "FY21Q1", "CY20Q4"));
            Qrt.Add(new Quarter(26, 2021, 2, 2021, 1, new DateTime(2021, 1, 1), new DateTime(2021, 3, 31), "FY21Q2", "CY21Q1"));
            Qrt.Add(new Quarter(27, 2021, 3, 2021, 2, new DateTime(2021, 4, 1), new DateTime(2021, 6, 30), "FY21Q3", "CY21Q2"));
            Qrt.Add(new Quarter(28, 2021, 4, 2021, 3, new DateTime(2021, 7, 1), new DateTime(2021, 9, 31), "FY21Q4", "CY21Q3"));
            Qrt.Add(new Quarter(29, 2022, 1, 2021, 4, new DateTime(2021, 9, 1), new DateTime(2021, 12, 31), "FY22Q1", "CY21Q4"));
            Qrt.Add(new Quarter(30, 2022, 2, 2022, 1, new DateTime(2022, 1, 1), new DateTime(2022, 3, 31), "FY22Q2", "CY22Q1"));
            Qrt.Add(new Quarter(31, 2022, 3, 2022, 2, new DateTime(2022, 4, 1), new DateTime(2022, 6, 30), "FY22Q3", "CY22Q2"));
            Qrt.Add(new Quarter(32, 2022, 4, 2022, 3, new DateTime(2022, 7, 1), new DateTime(2022, 9, 31), "FY22Q4", "CY22Q3"));
            Qrt.Add(new Quarter(33, 2023, 1, 2022, 4, new DateTime(2022, 9, 1), new DateTime(2022, 12, 31), "FY23Q1", "CY22Q4"));
            Qrt.Add(new Quarter(34, 2023, 2, 2023, 1, new DateTime(2023, 1, 1), new DateTime(2023, 3, 31), "FY23Q2", "CY23Q1"));
            Qrt.Add(new Quarter(35, 2023, 3, 2023, 2, new DateTime(2023, 4, 1), new DateTime(2023, 6, 30), "FY23Q3", "CY23Q2"));
            Qrt.Add(new Quarter(36, 2023, 4, 2023, 3, new DateTime(2023, 7, 1), new DateTime(2023, 9, 31), "FY23Q4", "CY23Q3"));
            Qrt.Add(new Quarter(37, 2024, 1, 2023, 4, new DateTime(2023, 9, 1), new DateTime(2023, 12, 31), "FY24Q1", "CY23Q4"));
            Qrt.Add(new Quarter(38, 2024, 2, 2024, 1, new DateTime(2024, 1, 1), new DateTime(2024, 3, 31), "FY24Q2", "CY24Q1"));
            Qrt.Add(new Quarter(39, 2024, 3, 2024, 2, new DateTime(2024, 4, 1), new DateTime(2024, 6, 30), "FY24Q3", "CY24Q2"));
            Qrt.Add(new Quarter(40, 2024, 4, 2024, 3, new DateTime(2024, 7, 1), new DateTime(2024, 9, 31), "FY24Q4", "CY24Q3"));
            Qrt.Add(new Quarter(41, 2025, 1, 2024, 4, new DateTime(2024, 9, 1), new DateTime(2024, 12, 31), "FY25Q1", "CY24Q4"));
            Qrt.Add(new Quarter(42, 2025, 2, 2025, 1, new DateTime(2025, 1, 1), new DateTime(2025, 3, 31), "FY25Q2", "CY25Q1"));
            Qrt.Add(new Quarter(43, 2025, 3, 2025, 2, new DateTime(2025, 4, 1), new DateTime(2025, 6, 30), "FY25Q3", "CY25Q2"));
            Qrt.Add(new Quarter(44, 2025, 4, 2025, 3, new DateTime(2025, 7, 1), new DateTime(2025, 9, 31), "FY25Q4", "CY25Q3"));
            Qrt.Add(new Quarter(45, 2026, 1, 2025, 4, new DateTime(2025, 9, 1), new DateTime(2025, 12, 31), "FY26Q1", "CY25Q4"));
            Qrt.Add(new Quarter(46, 2026, 2, 2026, 1, new DateTime(2026, 1, 1), new DateTime(2026, 3, 31), "FY26Q2", "CY26Q1"));
            Qrt.Add(new Quarter(47, 2026, 3, 2026, 2, new DateTime(2026, 4, 1), new DateTime(2026, 6, 30), "FY26Q3", "CY26Q2"));
            Qrt.Add(new Quarter(48, 2026, 4, 2026, 3, new DateTime(2026, 7, 1), new DateTime(2026, 9, 31), "FY26Q4", "CY26Q3"));
            Qrt.Add(new Quarter(49, 2027, 1, 2026, 4, new DateTime(2026, 9, 1), new DateTime(2026, 12, 31), "FY27Q1", "CY26Q4"));
            Qrt.Add(new Quarter(50, 2027, 2, 2027, 1, new DateTime(2027, 1, 1), new DateTime(2027, 3, 31), "FY27Q2", "CY27Q1"));
            Qrt.Add(new Quarter(51, 2027, 3, 2027, 2, new DateTime(2027, 4, 1), new DateTime(2027, 6, 30), "FY27Q3", "CY27Q2"));
            Qrt.Add(new Quarter(52, 2027, 4, 2027, 3, new DateTime(2027, 7, 1), new DateTime(2027, 9, 31), "FY27Q4", "CY27Q3"));
            Qrt.Add(new Quarter(53, 2028, 1, 2027, 4, new DateTime(2027, 9, 1), new DateTime(2027, 12, 31), "FY28Q1", "CY27Q4"));
            Qrt.Add(new Quarter(54, 2028, 2, 2028, 1, new DateTime(2028, 1, 1), new DateTime(2028, 3, 31), "FY28Q2", "CY28Q1"));
            Qrt.Add(new Quarter(55, 2028, 3, 2028, 2, new DateTime(2028, 4, 1), new DateTime(2028, 6, 30), "FY28Q3", "CY28Q2"));
            Qrt.Add(new Quarter(56, 2028, 4, 2028, 3, new DateTime(2028, 7, 1), new DateTime(2028, 9, 31), "FY28Q4", "CY28Q3"));
            Qrt.Add(new Quarter(57, 2029, 1, 2028, 4, new DateTime(2028, 9, 1), new DateTime(2028, 12, 31), "FY29Q1", "CY28Q4"));
            Qrt.Add(new Quarter(58, 2029, 2, 2029, 1, new DateTime(2029, 1, 1), new DateTime(2029, 3, 31), "FY29Q2", "CY29Q1"));
            Qrt.Add(new Quarter(59, 2029, 3, 2029, 2, new DateTime(2029, 4, 1), new DateTime(2029, 6, 30), "FY29Q3", "CY29Q2"));
            Qrt.Add(new Quarter(60, 2029, 4, 2029, 3, new DateTime(2029, 7, 1), new DateTime(2029, 9, 31), "FY29Q4", "CY29Q3"));
            Qrt.Add(new Quarter(61, 2030, 1, 2029, 4, new DateTime(2029, 9, 1), new DateTime(2029, 12, 31), "FY30Q1", "CY29Q4"));
            Qrt.Add(new Quarter(62, 2030, 2, 2030, 1, new DateTime(2030, 1, 1), new DateTime(2030, 3, 31), "FY30Q2", "CY30Q1"));
            Qrt.Add(new Quarter(63, 2030, 3, 2030, 2, new DateTime(2030, 4, 1), new DateTime(2030, 6, 30), "FY30Q3", "CY30Q2"));
            Qrt.Add(new Quarter(64, 2030, 4, 2030, 3, new DateTime(2030, 7, 1), new DateTime(2030, 9, 31), "FY30Q4", "CY30Q3"));


        }
    }
            
        
}
