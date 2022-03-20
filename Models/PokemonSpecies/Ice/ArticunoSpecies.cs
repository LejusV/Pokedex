using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Articuno Species to store common natural stats of all Articunos
	#region ArticunoSpecies
	public class ArticunoSpecies : PokemonSpecies
	{
#nullable enable
		private static ArticunoSpecies? _instance = null;
#nullable restore
        public static ArticunoSpecies Instance => _instance ?? (_instance = new ArticunoSpecies());

		#region ArticunoSpecies Constructor
		public ArticunoSpecies() : base(
			144,
			"Articuno",
			Ice.Instance, Flying.Instance,
			1.7,
			55.4,
			new PokemonStats(
				90, // HPs
				85, 100, // Attack & Defense
				95, 125, // Spacial Attack & Defense
				85 // Speed
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
				"Whirlwind",
				"Fly",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Mist",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
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
				"Hail",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Signal-Beam",
				"Sheer-Cold",
				"Aerial-Ace",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Defog",
				"Ominous-Wind",
				"Round",
				"Sky-Drop",
				"Frost-Breath",
				"Hurricane",
				"Freeze-Dry",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}