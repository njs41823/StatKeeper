using System;
using System.ComponentModel.DataAnnotations;
using StatKeeper.Models;

namespace StatKeeper.ViewModels
{
    public class TeamViewModel
    {
        private readonly Team _team;

        public TeamViewModel(Team team)
        {
            _team = team ?? throw new ArgumentNullException(nameof(team), "Parameter" + nameof(team) + " cannot be null.");
        }

        public int TeamId => _team.TeamId;

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string TeamName
        {
            get => _team.Name;
            set => _team.Name = value;
        }
    }
}