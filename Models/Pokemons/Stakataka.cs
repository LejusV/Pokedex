using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Stakataka Species to store common natural stats of all Stakatakas
	#region SpeciesStakataka
	public class SpeciesStakataka : PokemonSpecies
	{
#nullable enable
		private static SpeciesStakataka? _instance = null;
#nullable restore
        public static SpeciesStakataka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStakataka();
                }
                return _instance;
            }
        }

		#region SpeciesStakataka Constructor
		public SpeciesStakataka() : base(
			805,
			"Stakataka",
			5.5,
			820.0,
			61, // HPs
			131, 211, // Attack & Defense
			53, 101, // Special Attack & Defense
			13		
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Sandstorm",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Facade",
				"Rock-Tomb",
				"Iron-Defense",
				"Rock-Blast",
				"Gyro-Ball",
				"Rock-Polish",
				"Giga-Impact",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Stakataka PokemonInstance Class
	#region Stakataka
	public class StakatakaInstance : PokemonInstance
	{
		#region Stakataka Constructors
		/// <summary>
		/// Stakataka Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StakatakaInstance(string nickname, int level)
		: base(
				SpeciesStakataka.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stakataka Builder only waiting for a Level
		/// </summary>
		public StakatakaInstance(int level)
		: base(
				SpeciesStakataka.Instance, // PokemonInstance Species
				"Stakataka", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stakataka Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public StakatakaInstance() : base(
			SpeciesStakataka.Instance, // PokemonInstance Species
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}