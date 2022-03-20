using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Simipour Species to store common natural stats of all Simipours
	#region SimipourSpecies
	public class SimipourSpecies : PokemonSpecies
	{
#nullable enable
		private static SimipourSpecies? _instance = null;
#nullable restore
        public static SimipourSpecies Instance => _instance ?? (_instance = new SimipourSpecies());

		#region SimipourSpecies Constructor
		public SimipourSpecies() : base(
			516,
			"Simipour",
			Water.Instance,
			1.0,
			29.0,
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
				"Ice-Punch",
				"Cut",
				"Leer",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Waterfall",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Covet",
				"Water-Pulse",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}