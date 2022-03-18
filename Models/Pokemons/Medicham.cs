using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Medicham Species to store common natural stats of all Medichams
	#region SpeciesMedicham
	public class SpeciesMedicham : PokemonSpecies
	{
#nullable enable
		private static SpeciesMedicham? _instance = null;
#nullable restore
        public static SpeciesMedicham Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMedicham();
                }
                return _instance;
            }
        }

		#region SpeciesMedicham Constructor
		public SpeciesMedicham() : base(
			308,
			"Medicham",
			1.3,
			31.5,
			60, // HPs
			60, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			80		
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

	//Medicham PokemonInstance Class
	#region Medicham
	public class MedichamInstance : PokemonInstance
	{
		#region Medicham Constructors
		/// <summary>
		/// Medicham Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MedichamInstance(string nickname, int level)
		: base(
				SpeciesMedicham.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Medicham Builder only waiting for a Level
		/// </summary>
		public MedichamInstance(int level)
		: base(
				SpeciesMedicham.Instance, // PokemonInstance Species
				"Medicham", level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Medicham Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MedichamInstance() : base(
			SpeciesMedicham.Instance, // PokemonInstance Species
			Fighting.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}