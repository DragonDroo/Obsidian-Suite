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


