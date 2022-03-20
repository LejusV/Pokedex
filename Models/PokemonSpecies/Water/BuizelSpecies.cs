using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Buizel Species to store common natural stats of all Buizels
	#region BuizelSpecies
	public class BuizelSpecies : PokemonSpecies
	{
#nullable enable
		private static BuizelSpecies? _instance = null;
#nullable restore
        public static BuizelSpecies Instance => _instance ?? (_instance = new BuizelSpecies());

		#region BuizelSpecies Constructor
		public BuizelSpecies() : base(
			418,
			"Buizel",
			Water.Instance,
			0.7,
			29.5,
			new PokemonStats(
				55, // HPs
				65, 35, // Attack & Defense
				60, 30, // Spacial Attack & Defense
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
				"Double-Slap",
				"Ice-Punch",
				"Razor-Wind",
				"Headbutt",
				"Growl",
				"Sonic-Boom",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Bulk-Up",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Me-First",
				"Aqua-Ring",
				"Aqua-Tail",
				"Switcheroo",
				"Captivate",
				"Aqua-Jet",
				"Double-Hit",
				"Soak",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Tail-Slap",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}