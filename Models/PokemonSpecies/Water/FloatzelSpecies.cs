using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Floatzel Species to store common natural stats of all Floatzels
	#region FloatzelSpecies
	public class FloatzelSpecies : PokemonSpecies
	{
#nullable enable
		private static FloatzelSpecies? _instance = null;
#nullable restore
        public static FloatzelSpecies Instance => _instance ?? (_instance = new FloatzelSpecies());

		#region FloatzelSpecies Constructor
		public FloatzelSpecies() : base(
			419,
			"Floatzel",
			Water.Instance,
			1.1,
			33.5,
			new PokemonStats(
				85, // HPs
				105, 55, // Attack & Defense
				85, 50, // Spacial Attack & Defense
				115 // Speed
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
				"Ice-Punch",
				"Razor-Wind",
				"Headbutt",
				"Growl",
				"Roar",
				"Sonic-Boom",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Bulk-Up",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Ice-Fang",
				"Captivate",
				"Aqua-Jet",
				"Double-Hit",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}