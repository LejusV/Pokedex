using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vaporeon Species to store common natural stats of all Vaporeons
	#region VaporeonSpecies
	public class VaporeonSpecies : PokemonSpecies
	{
#nullable enable
		private static VaporeonSpecies? _instance = null;
#nullable restore
        public static VaporeonSpecies Instance => _instance ?? (_instance = new VaporeonSpecies());

		#region VaporeonSpecies Constructor
		public VaporeonSpecies() : base(
			134,
			"Vaporeon",
			Water.Instance,
			1.0,
			29.0,
			new PokemonStats(
				130, // HPs
				65, 60, // Attack & Defense
				110, 95, // Spacial Attack & Defense
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Dive",
				"Hyper-Voice",
				"Signal-Beam",
				"Muddy-Water",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Last-Resort",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Captivate",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}