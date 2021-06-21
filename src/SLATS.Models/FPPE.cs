using System;
using System.Collections.Generic;
using System.Text;

namespace Slats.Models
{
    public class FPPE : EntityTracked
    {
       // public ID.....................37
        public DateTime IniFrom { get; set; }
        public DateTime IniTo         { get; set; }
        public DateTime IniPSB        { get; set; }
        public DateTime Ext1From      { get; set; }
        public DateTime Ext1To        { get; set; }
        public DateTime Ext1PSB       { get; set; }
        public DateTime EXT2From      { get; set; }
        public DateTime Ext2To        { get; set; }
        public DateTime Ext2PSB       { get; set; }
        public DateTime Ext3From      { get; set; }
        public DateTime Ext3To        { get; set; }
        public DateTime Ext3PSB       { get; set; }
        public DateTime Completion    { get; set; }
        public DateTime CompletionPSB { get; set; }
        public int Privilege              { get; set; } 
        public int Comments               { get; set; }
        public int Practitioner           { get; set; }
        public string Criteria            { get; set; }
        public bool CompletedSuccessfully { get; set; }
        public string Comment             { get; set; }
        public string Ext1Comment         { get; set; }
        public string Ext2Comment         { get; set; }
        public string Ext3Comment         { get; set; }
        public string CompletionComment   { get; set; }
        public int IniCPR                 { get; set; }
        public int iniCPR2                { get; set; }
        public int ext1CPR                { get; set; }
        public int ext2CPR                { get; set; }
        public int ext3CPR                { get; set; }
        public int fppeForm               { get; set; }
        public int Mentor { get; set; }
    }
}

//ID.....................37
//IniFrom................43727
//IniTo..................43787
//IniPSB.................43727
//Ext1From...............43788
//Ext1To.................43848
//Ext1PSB................
//EXT2From...............43849
//Ext2To.................43968
//Ext2PSB................
//Ext3From...............43969
//Ext3To.................44088
//Ext3PSB................
//Completion.............44028
//CompletionPSB..........44033
//Privilege..............Core
//Comments...............
//Practitioner...........530677
//Criteria...............Initial
//CompletedSuccessfully..FALSE
//Comment................
//Ext1Comment............
//Ext2Comment............
//Ext3Comment............
//CompletionComment......Approved in PSB on 7/21/2020
//IniCPR.................679
//iniCPR2................0
//ext1CPR................0
//ext2CPR................0
//ext3CPR................0
//fppeForm...............428
//Mentor.................0
