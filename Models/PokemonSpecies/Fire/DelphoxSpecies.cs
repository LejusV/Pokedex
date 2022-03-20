using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Delphox Species to store common natural stats of all Delphoxs
	#region DelphoxSpecies
	public class DelphoxSpecies : PokemonSpecies
	{
#nullable enable
		private static DelphoxSpecies? _instance = null;
#nullable restore
        public static DelphoxSpecies Instance => _instance ?? (_instance = new DelphoxSpecies());

		#region DelphoxSpecies Constructor
		public DelphoxSpecies() : base(
			655,
			"Delphox",
			Fire.Instance, Psychic.Instance,
			1.5,
			39.0,
			new PokemonStats(
				75, // HPs
				69, 72, // Attack & Defense
				114, 100, // Spacial Attack & Defense
				104 // Speed
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
				"Hyper-Beam",
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
				"Shadow-Ball",
				"Future-Sight",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Blast-Burn",
				"Overheat",
				"Signal-Beam",
				"Howl",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Embargo",
				"Lucky-Chant",
				"Switcheroo",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
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
				"Mystical-Fire",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}