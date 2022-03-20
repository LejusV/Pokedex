using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Simisage Species to store common natural stats of all Simisages
	#region SimisageSpecies
	public class SimisageSpecies : PokemonSpecies
	{
#nullable enable
		private static SimisageSpecies? _instance = null;
#nullable restore
        public static SimisageSpecies Instance => _instance ?? (_instance = new SimisageSpecies());

		#region SimisageSpecies Constructor
		public SimisageSpecies() : base(
			512,
			"Simisage",
			Grass.Instance,
			1.1,
			30.5,
			new PokemonStats(
				75, // HPs
				98, 63, // Attack & Defense
				98, 63, // Spacial Attack & Defense
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
				"Cut",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Covet",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}