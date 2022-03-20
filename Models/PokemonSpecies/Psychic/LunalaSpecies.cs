using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lunala Species to store common natural stats of all Lunalas
	#region LunalaSpecies
	public class LunalaSpecies : PokemonSpecies
	{
#nullable enable
		private static LunalaSpecies? _instance = null;
#nullable restore
        public static LunalaSpecies Instance => _instance ?? (_instance = new LunalaSpecies());

		#region LunalaSpecies Constructor
		public LunalaSpecies() : base(
			792,
			"Lunala",
			Psychic.Instance, Ghost.Instance,
			4.0,
			120.0,
			new PokemonStats(
				137, // HPs
				113, 89, // Attack & Defense
				137, 107, // Spacial Attack & Defense
				97 // Speed
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
				"Fly",
				"Roar",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Teleport",
				"Night-Shade",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Magic-Coat",
				"Cosmic-Power",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Air-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Trick-Room",
				"Charge-Beam",
				"Wide-Guard",
				"Psyshock",
				"Round",
				"Sky-Drop",
				"Acrobatics",
				"Work-Up",
				"Night-Daze",
				"Phantom-Force",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Moongeist-Beam"
			};
		}
		#endregion
	}
	#endregion
}