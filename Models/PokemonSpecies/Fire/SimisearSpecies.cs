using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Simisear Species to store common natural stats of all Simisears
	#region SimisearSpecies
	public class SimisearSpecies : PokemonSpecies
	{
#nullable enable
		private static SimisearSpecies? _instance = null;
#nullable restore
        public static SimisearSpecies Instance => _instance ?? (_instance = new SimisearSpecies());

		#region SimisearSpecies Constructor
		public SimisearSpecies() : base(
			514,
			"Simisear",
			Fire.Instance,
			1.0,
			28.0,
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
				"Fire-Punch",
				"Cut",
				"Leer",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
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
				"Overheat",
				"Rock-Tomb",
				"Covet",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}