//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StatKeeper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatLine
    {
        public int StatLineId { get; set; }
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public int GameId { get; set; }
        public int TwoPointFieldGoalsAttempted { get; set; }
        public int TwoPointFieldGoalsMade { get; set; }
        public int ThreePointFieldGoalsAttempted { get; set; }
        public int ThreePointFieldGoalsMade { get; set; }
        public int FreeThrowsAttempted { get; set; }
        public int FreeThrowsMade { get; set; }
        public int OffensiveRebounds { get; set; }
        public int DefensiveRebounds { get; set; }
        public int Assists { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Turnovers { get; set; }
    }
}