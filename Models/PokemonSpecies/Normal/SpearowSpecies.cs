using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spearow Species to store common natural stats of all Spearows
	#region SpearowSpecies
	public class SpearowSpecies : PokemonSpecies
	{
#nullable enable
		private static SpearowSpecies? _instance = null;
#nullable restore
        public static SpearowSpecies Instance => _instance ?? (_instance = new SpearowSpecies());

		#region SpearowSpecies Constructor
		public SpearowSpecies() : base(
			21,
			"Spearow",
			Normal.Instance, Flying.Instance,
			0.3,
			2.0,
			new PokemonStats(
				40, // HPs
				60, 30, // Attack & Defense
				31, 31, // Spacial Attack & Defense
				70 // Speed
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
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
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
				"Feather-Dance",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Assurance",
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