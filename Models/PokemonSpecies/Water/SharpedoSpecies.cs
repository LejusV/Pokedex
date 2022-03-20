using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sharpedo Species to store common natural stats of all Sharpedos
	#region SharpedoSpecies
	public class SharpedoSpecies : PokemonSpecies
	{
#nullable enable
		private static SharpedoSpecies? _instance = null;
#nullable restore
        public static SharpedoSpecies Instance => _instance ?? (_instance = new SharpedoSpecies());

		#region SharpedoSpecies Constructor
		public SharpedoSpecies() : base(
			319,
			"Sharpedo",
			Water.Instance, Dark.Instance,
			1.8,
			88.8,
			new PokemonStats(
				70, // HPs
				120, 40, // Attack & Defense
				95, 40, // Spacial Attack & Defense
				95 // Speed
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
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Dive",
				"Poison-Fang",
				"Rock-Tomb",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Assurance",
				"Poison-Jab",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Zen-Headbutt",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}