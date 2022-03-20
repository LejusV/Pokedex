using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Braixen Species to store common natural stats of all Braixens
	#region BraixenSpecies
	public class BraixenSpecies : PokemonSpecies
	{
#nullable enable
		private static BraixenSpecies? _instance = null;
#nullable restore
        public static BraixenSpecies Instance => _instance ?? (_instance = new BraixenSpecies());

		#region BraixenSpecies Constructor
		public BraixenSpecies() : base(
			654,
			"Braixen",
			Fire.Instance,
			1.0,
			14.5,
			new PokemonStats(
				59, // HPs
				59, 58, // Attack & Defense
				90, 70, // Spacial Attack & Defense
				73 // Speed
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
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Tail-Whip",
				"Ember",
				"Flamethrower",
				"Psybeam",
				"Low-Kick",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Overheat",
				"Howl",
				"Covet",
				"Shock-Wave",
				"Embargo",
				"Lucky-Chant",
				"Zen-Headbutt",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Magic-Room",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Incinerate",
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