using System;
using System.ComponentModel.DataAnnotations;
using StatKeeper.Models;

namespace StatKeeper.ViewModels
{
    public class PlayerViewModel
    {
        private readonly Player _player;

        public PlayerViewModel(Player player)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player), "Parameter" + nameof(player) + " cannot be null.");
        }

        public int PlayerId => _player.PlayerId;

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string PlayerName
        {
            get => _player.Name;
            set => _player.Name = value;
        }
    }
}