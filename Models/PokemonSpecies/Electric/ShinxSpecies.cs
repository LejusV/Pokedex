using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shinx Species to store common natural stats of all Shinxs
	#region ShinxSpecies
	public class ShinxSpecies : PokemonSpecies
	{
#nullable enable
		private static ShinxSpecies? _instance = null;
#nullable restore
        public static ShinxSpecies Instance => _instance ?? (_instance = new ShinxSpecies());

		#region ShinxSpecies Constructor
		public ShinxSpecies() : base(
			403,
			"Shinx",
			Electric.Instance,
			0.5,
			9.5,
			new PokemonStats(
				45, // HPs
				65, 34, // Attack & Defense
				40, 34, // Spacial Attack & Defense
				45 // Speed
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
				"Double-Kick",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Leer",
				"Bite",
				"Roar",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Spark",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Secret-Power",
				"Fake-Tears",
				"Signal-Beam",
				"Howl",
				"Shock-Wave",
				"Natural-Gift",
				"Magnet-Rise",
				"Night-Slash",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Volt-Switch",
				"Wild-Charge",
				"Snarl",
				"Confide",
				"Eerie-Impulse",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}