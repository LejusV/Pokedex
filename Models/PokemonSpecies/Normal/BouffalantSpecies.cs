using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bouffalant Species to store common natural stats of all Bouffalants
	#region BouffalantSpecies
	public class BouffalantSpecies : PokemonSpecies
	{
#nullable enable
		private static BouffalantSpecies? _instance = null;
#nullable restore
        public static BouffalantSpecies Instance => _instance ?? (_instance = new BouffalantSpecies());

		#region BouffalantSpecies Constructor
		public BouffalantSpecies() : base(
			626,
			"Bouffalant",
			Normal.Instance,
			1.6,
			94.6,
			new PokemonStats(
				95, // HPs
				110, 95, // Attack & Defense
				40, 95, // Spacial Attack & Defense
				55 // Speed
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
				"Swords-Dance",
				"Cut",
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Thrash",
				"Leer",
				"Surf",
				"Strength",
				"Earthquake",
				"Toxic",
				"Rage",
				"Double-Team",
				"Focus-Energy",
				"Skull-Bash",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Taunt",
				"Superpower",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Mud-Shot",
				"Payback",
				"Poison-Jab",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Cotton-Guard",
				"Head-Charge",
				"Belch",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}