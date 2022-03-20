using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Starly Species to store common natural stats of all Starlys
	#region StarlySpecies
	public class StarlySpecies : PokemonSpecies
	{
#nullable enable
		private static StarlySpecies? _instance = null;
#nullable restore
        public static StarlySpecies Instance => _instance ?? (_instance = new StarlySpecies());

		#region StarlySpecies Constructor
		public StarlySpecies() : base(
			396,
			"Starly",
			Normal.Instance, Flying.Instance,
			0.3,
			2.0,
			new PokemonStats(
				40, // HPs
				55, 30, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				60 // Speed
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
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Fury-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Mirror-Move",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Feather-Dance",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Final-Gambit",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}