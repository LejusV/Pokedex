using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gorebyss Species to store common natural stats of all Gorebysss
	#region GorebyssSpecies
	public class GorebyssSpecies : PokemonSpecies
	{
#nullable enable
		private static GorebyssSpecies? _instance = null;
#nullable restore
        public static GorebyssSpecies Instance => _instance ?? (_instance = new GorebyssSpecies());

		#region GorebyssSpecies Constructor
		public GorebyssSpecies() : base(
			368,
			"Gorebyss",
			Water.Instance,
			1.8,
			22.6,
			new PokemonStats(
				55, // HPs
				84, 105, // Attack & Defense
				114, 75, // Spacial Attack & Defense
				52 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Bind",
				"Body-Slam",
				"Double-Edge",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Captivate",
				"Coil",
				"Round",
				"Scald",
				"Draining-Kiss",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}