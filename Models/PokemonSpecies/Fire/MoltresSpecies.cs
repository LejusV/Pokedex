using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Moltres Species to store common natural stats of all Moltress
	#region MoltresSpecies
	public class MoltresSpecies : PokemonSpecies
	{
#nullable enable
		private static MoltresSpecies? _instance = null;
#nullable restore
        public static MoltresSpecies Instance => _instance ?? (_instance = new MoltresSpecies());

		#region MoltresSpecies Constructor
		public MoltresSpecies() : base(
			146,
			"Moltres",
			Fire.Instance, Flying.Instance,
			2.0,
			60.0,
			new PokemonStats(
				90, // HPs
				100, 90, // Attack & Defense
				125, 85, // Spacial Attack & Defense
				90 // Speed
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
				"Wing-Attack",
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Overheat",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Air-Slash",
				"Giga-Impact",
				"Defog",
				"Ominous-Wind",
				"Flame-Charge",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Hurricane",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion
}