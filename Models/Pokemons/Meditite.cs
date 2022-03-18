using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Meditite Species to store common natural stats of all Meditites
	#region SpeciesMeditite
	public class SpeciesMeditite : PokemonSpecies
	{
#nullable enable
		private static SpeciesMeditite? _instance = null;
#nullable restore
        public static SpeciesMeditite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMeditite();
                }
                return _instance;
            }
        }

		#region SpeciesMeditite Constructor
		public SpeciesMeditite() : base(
			307,
			"Meditite",
			0.6,
			11.2,
			30, // HPs
			40, 55, // Attack & Defense
			40, 55, // Special Attack & Defense
			60		
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

	//Meditite PokemonInstance Class
	#region Meditite
	public class MedititeInstance : PokemonInstance
	{
		#region Meditite Constructors
		/// <summary>
		/// Meditite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MedititeInstance(string nickname, int level)
		: base(
				SpeciesMeditite.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meditite Builder only waiting for a Level
		/// </summary>
		public MedititeInstance(int level)
		: base(
				SpeciesMeditite.Instance, // PokemonInstance Species
				"Meditite", level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meditite Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MedititeInstance() : base(
			SpeciesMeditite.Instance, // PokemonInstance Species
			Fighting.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}