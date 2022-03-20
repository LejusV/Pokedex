using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Fearow Species to store common natural stats of all Fearows
	#region FearowSpecies
	public class FearowSpecies : PokemonSpecies
	{
#nullable enable
		private static FearowSpecies? _instance = null;
#nullable restore
        public static FearowSpecies Instance => _instance ?? (_instance = new FearowSpecies());

		#region FearowSpecies Constructor
		public FearowSpecies() : base(
			22,
			"Fearow",
			Normal.Instance, Flying.Instance,
			1.2,
			38.0,
			new PokemonStats(
				65, // HPs
				90, 65, // Attack & Defense
				61, 61, // Spacial Attack & Defense
				100 // Speed
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
				"Razor-Wind",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Growl",
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"False-Swipe",
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
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Assurance",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Drill-Run",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}