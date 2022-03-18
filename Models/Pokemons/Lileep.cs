using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lileep Species to store common natural stats of all Lileeps
	#region SpeciesLileep
	public class SpeciesLileep : PokemonSpecies
	{
#nullable enable
		private static SpeciesLileep? _instance = null;
#nullable restore
        public static SpeciesLileep Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLileep();
                }
                return _instance;
            }
        }

		#region SpeciesLileep Constructor
		public SpeciesLileep() : base(
			345,
			"Lileep",
			1.0,
			23.8,
			66, // HPs
			41, 77, // Attack & Defense
			61, 87, // Special Attack & Defense
			23		
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
				"Swords-Dance",
				"Bind",
				"Body-Slam",
				"Double-Edge",
				"Acid",
				"Mega-Drain",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Barrier",
				"Constrict",
				"Amnesia",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Mirror-Coat",
				"Psych-Up",
				"Ancient-Power",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Ingrain",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Tickle",
				"Bullet-Seed",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Rock-Polish",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Lileep PokemonInstance Class
	#region Lileep
	public class LileepInstance : PokemonInstance
	{
		#region Lileep Constructors
		/// <summary>
		/// Lileep Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LileepInstance(string nickname, int level)
		: base(
				SpeciesLileep.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lileep Builder only waiting for a Level
		/// </summary>
		public LileepInstance(int level)
		: base(
				SpeciesLileep.Instance, // PokemonInstance Species
				"Lileep", level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lileep Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LileepInstance() : base(
			SpeciesLileep.Instance, // PokemonInstance Species
			Rock.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}