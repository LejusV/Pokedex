using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pelipper Species to store common natural stats of all Pelippers
	#region PelipperSpecies
	public class PelipperSpecies : PokemonSpecies
	{
#nullable enable
		private static PelipperSpecies? _instance = null;
#nullable restore
        public static PelipperSpecies Instance => _instance ?? (_instance = new PelipperSpecies());

		#region PelipperSpecies Constructor
		public PelipperSpecies() : base(
			279,
			"Pelipper",
			Water.Instance, Flying.Instance,
			1.2,
			28.0,
			new PokemonStats(
				60, // HPs
				50, 100, // Attack & Defense
				95, 70, // Spacial Attack & Defense
				65 // Speed
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
				"Fly",
				"Double-Edge",
				"Growl",
				"Supersonic",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
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
				"Whirlpool",
				"Uproar",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Water-Sport",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Fling",
				"Seed-Bomb",
				"Giga-Impact",
				"Defog",
				"Gunk-Shot",
				"Captivate",
				"Ominous-Wind",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Sky-Drop",
				"Hurricane",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}