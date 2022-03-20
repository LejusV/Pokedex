using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Meditite Species to store common natural stats of all Meditites
	#region MedititeSpecies
	public class MedititeSpecies : PokemonSpecies
	{
#nullable enable
		private static MedititeSpecies? _instance = null;
#nullable restore
        public static MedititeSpecies Instance => _instance ?? (_instance = new MedititeSpecies());

		#region MedititeSpecies Constructor
		public MedititeSpecies() : base(
			307,
			"Meditite",
			Fighting.Instance, Psychic.Instance,
			0.6,
			11.2,
			new PokemonStats(
				30, // HPs
				40, 55, // Attack & Defense
				40, 55, // Spacial Attack & Defense
				60 // Speed
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
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Toxic",
				"Confusion",
				"Psychic",
				"Meditate",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Swift",
				"High-Jump-Kick",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Baton-Pass",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Bulk-Up",
				"Calm-Mind",
				"Gravity",
				"Natural-Gift",
				"Feint",
				"Acupressure",
				"Fling",
				"Power-Trick",
				"Power-Swap",
				"Guard-Swap",
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Bullet-Punch",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}