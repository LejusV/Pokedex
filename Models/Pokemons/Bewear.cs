using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bewear Species to store common natural stats of all Bewears
	#region SpeciesBewear
	public class SpeciesBewear : PokemonSpecies
	{
#nullable enable
		private static SpeciesBewear? _instance = null;
#nullable restore
        public static SpeciesBewear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBewear();
                }
                return _instance;
            }
        }

		#region SpeciesBewear Constructor
		public SpeciesBewear() : base(
			760,
			"Bewear",
			2.1,
			135.0,
			120, // HPs
			125, 80, // Attack & Defense
			55, 60, // Special Attack & Defense
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
				"Swords-Dance",
				"Bind",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flail",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Bulk-Up",
				"Hammer-Arm",
				"Payback",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Bewear PokemonInstance Class
	#region Bewear
	public class BewearInstance : PokemonInstance
	{
		#region Bewear Constructors
		/// <summary>
		/// Bewear Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BewearInstance(string nickname, int level)
		: base(
				SpeciesBewear.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bewear Builder only waiting for a Level
		/// </summary>
		public BewearInstance(int level)
		: base(
				SpeciesBewear.Instance, // PokemonInstance Species
				"Bewear", level,
				Normal.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bewear Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public BewearInstance() : base(
			SpeciesBewear.Instance, // PokemonInstance Species
			Normal.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}