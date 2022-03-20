using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zapdos Species to store common natural stats of all Zapdoss
	#region ZapdosSpecies
	public class ZapdosSpecies : PokemonSpecies
	{
#nullable enable
		private static ZapdosSpecies? _instance = null;
#nullable restore
        public static ZapdosSpecies Instance => _instance ?? (_instance = new ZapdosSpecies());

		#region ZapdosSpecies Constructor
		public ZapdosSpecies() : base(
			145,
			"Zapdos",
			Electric.Instance, Flying.Instance,
			1.6,
			52.6,
			new PokemonStats(
				90, // HPs
				90, 85, // Attack & Defense
				125, 90, // Spacial Attack & Defense
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
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Charge",
				"Secret-Power",
				"Air-Cutter",
				"Signal-Beam",
				"Aerial-Ace",
				"Shock-Wave",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Giga-Impact",
				"Defog",
				"Discharge",
				"Charge-Beam",
				"Ominous-Wind",
				"Round",
				"Sky-Drop",
				"Volt-Switch",
				"Wild-Charge",
				"Confide",
				"Magnetic-Flux"
			};
		}
		#endregion
	}
	#endregion
}