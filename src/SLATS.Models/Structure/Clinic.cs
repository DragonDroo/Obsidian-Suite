using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class Clinic : EntityTracked
    {
        public int ProviderID { get; set; }
        public string Name { get; set; }
        public virtual StaffProvider Provider { get; set; }

    }
}

//ID...................1
//StaffID..............CIEN.................8027
//CLINIC NAME..........KER/AUDIO/30/BILLABLE
//ABBREV...............AUK30B
//PHYSICAL LOCATION....2nd FLOOR, AUDIOLOGY
//CLINIC GROUP.........AUDIOLOGY
//PATIENT FRIENDLY NAME..AUDIOLOGY CLINIC
//PhoneNumber..........336-515-5000
//EXT..................21228
//APPT LENGTH..........30
//DISP INC PER/HR......30-MIN 
//OVER BOOKS...........10
//MAX FUTURE...........390
//WORK LOAD VAL FLAG...Y
//NON-COUNT............N
//DIRECT PT SCHED......N
//DISPLAY APPT FLAG....Y
//Pre Appt Letter......KER GENERIC
//Clinic Cx Letter.....KERNERSVILLE CLINIC CANCELLED
//Appt Cx Letter.......KERNERSVILLE APP CANCELLED
//SC...................203
//SC NAME..............AUDIOLOGY
//CC...................
//CC NAME..............
//VARIABLE APPT........Y
//CLINIC START HOUR....8
//WORK ON HOLIDAY FLAG.
//AUTO REBOOK..........16
//PROHIBIT CLINIC......Y
//DEFAULT TO PCC.......
//ASK F/ CI-CO.........Y
//ALLOW NO SHOW........0
//PROVIDER.............
//DEF PROV FLAG........N
//INSTITUTION..........KERNERSVILLE VA CLINIC
//DIVISION.............KERNERSVILLE VA CLINIC
//AT INST FLAG.........Y
//Vista Create Date....1
//Vista Edit Date......43392
//Inactivation Date....
//Reactivation Date....


//Columns
//Name Type Size
//ID Long Integer 4
//StaffID Long Integer 4
//CIEN Double 8
//CLINIC NAME Short Text 255
//ABBREV Short Text 255
//PHYSICAL LOCATION Short Text 255
//CLINIC GROUP Short Text 255
//PATIENT FRIENDLY NAME Short Text 255
//PhoneNumber Short Text 255
//EXT Double 8
//APPT LENGTH Double 8
//DISP INC PER/HR Short Text 255
//OVER BOOKS Double 8
//MAX FUTURE Short Text 255
//WORK LOAD VAL FLAG Short Text 255
//NON-COUNT Short Text 255
//DIRECT PT SCHED Short Text 255
//DISPLAY APPT FLAG Short Text 255
//Pre Appt Letter Short Text 255
//Clinic Cx Letter Short Text 255
//Appt Cx Letter Short Text 255
//SC Double 8
//SC NAME Short Text 255
//CC Double 8
//CC NAME Short Text 255
//VARIABLE APPT Short Text 255
//CLINIC START HOUR Double 8
//U:\Universal PSS\PSS Admin wc4.accdb Thursday, February 17, 2022
//Table: Clinics Page: 6
//WORK ON HOLIDAY FLAG Short Text 255
//AUTO REBOOK Double 8
//PROHIBIT CLINIC Short Text 255
//DEFAULT TO PCC Short Text 255
//ASK F/ CI-CO Short Text 255
//ALLOW NO SHOW Double 8
//PROVIDER Short Text 255
//DEF PROV FLAG Short Text 255
//INSTITUTION Short Text 255
//DIVISION Short Text 255
//AT INST FLAG Short Text 255
//Vista Create Date Date With Time 8
//Vista Edit Date Date With Time 8
//Inactivation Date Short Text 255
//Reactivation Date Short Text 255
//Table Indexes
//Name Number of Fields
//PrimaryKey 1
//Fields:
//ID Ascending
//StaffID 1
//Fields:
//StaffID Ascending