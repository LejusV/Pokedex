using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Medicham Species to store common natural stats of all Medichams
	#region MedichamSpecies
	public class MedichamSpecies : PokemonSpecies
	{
#nullable enable
		private static MedichamSpecies? _instance = null;
#nullable restore
        public static MedichamSpecies Instance => _instance ?? (_instance = new MedichamSpecies());

		#region MedichamSpecies Constructor
		public MedichamSpecies() : base(
			308,
			"Medicham",
			Fighting.Instance, Psychic.Instance,
			1.3,
			31.5,
			new PokemonStats(
				60, // HPs
				60, 75, // Attack & Defense
				60, 75, // Spacial Attack & Defense
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
				"Hyper-Beam",
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
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
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
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"Low-Sweep",
				"Round",
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