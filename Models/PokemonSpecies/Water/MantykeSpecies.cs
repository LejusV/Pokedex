using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mantyke Species to store common natural stats of all Mantykes
	#region MantykeSpecies
	public class MantykeSpecies : PokemonSpecies
	{
#nullable enable
		private static MantykeSpecies? _instance = null;
#nullable restore
        public static MantykeSpecies Instance => _instance ?? (_instance = new MantykeSpecies());

		#region MantykeSpecies Constructor
		public MantykeSpecies() : base(
			458,
			"Mantyke",
			Water.Instance, Flying.Instance,
			1.0,
			65.0,
			new PokemonStats(
				45, // HPs
				20, 50, // Attack & Defense
				60, 120, // Spacial Attack & Defense
				50 // Speed
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
				"Wing-Attack",
				"Slam",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Supersonic",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Earthquake",
				"Toxic",
				"Agility",
				"Double-Team",
				"Confuse-Ray",
				"Haze",
				"Waterfall",
				"Swift",
				"Amnesia",
				"Bubble",
				"Splash",
				"Rest",
				"Rock-Slide",
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
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Air-Cutter",
				"Signal-Beam",
				"Aerial-Ace",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Tailwind",
				"Aqua-Ring",
				"Air-Slash",
				"Captivate",
				"Wide-Guard",
				"Round",
				"Scald",
				"Acrobatics",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}