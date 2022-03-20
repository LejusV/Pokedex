using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pidgeot Species to store common natural stats of all Pidgeots
	#region PidgeotSpecies
	public class PidgeotSpecies : PokemonSpecies
	{
#nullable enable
		private static PidgeotSpecies? _instance = null;
#nullable restore
        public static PidgeotSpecies Instance => _instance ?? (_instance = new PidgeotSpecies());

		#region PidgeotSpecies Constructor
		public PidgeotSpecies() : base(
			18,
			"Pidgeot",
			Normal.Instance, Flying.Instance,
			1.5,
			39.5,
			new PokemonStats(
				83, // HPs
				80, 75, // Attack & Defense
				70, 70, // Spacial Attack & Defense
				101 // Speed
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
				"Gust",
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
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
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Round",
				"Work-Up",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}