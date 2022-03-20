using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grumpig Species to store common natural stats of all Grumpigs
	#region GrumpigSpecies
	public class GrumpigSpecies : PokemonSpecies
	{
#nullable enable
		private static GrumpigSpecies? _instance = null;
#nullable restore
        public static GrumpigSpecies Instance => _instance ?? (_instance = new GrumpigSpecies());

		#region GrumpigSpecies Constructor
		public GrumpigSpecies() : base(
			326,
			"Grumpig",
			Psychic.Instance,
			0.9,
			71.5,
			new PokemonStats(
				80, // HPs
				45, 65, // Attack & Defense
				90, 110, // Spacial Attack & Defense
				80 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Psybeam",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Teeter-Dance",
				"Odor-Sleuth",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Power-Gem",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Bulldoze",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}