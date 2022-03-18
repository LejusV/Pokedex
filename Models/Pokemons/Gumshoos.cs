using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gumshoos Species to store common natural stats of all Gumshooss
	#region SpeciesGumshoos
	public class SpeciesGumshoos : PokemonSpecies
	{
#nullable enable
		private static SpeciesGumshoos? _instance = null;
#nullable restore
        public static SpeciesGumshoos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGumshoos();
                }
                return _instance;
            }
        }

		#region SpeciesGumshoos Constructor
		public SpeciesGumshoos() : base(
			735,
			"Gumshoos",
			0.7,
			14.2,
			88, // HPs
			110, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			45		
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
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Crunch",
				"Torment",
				"Facade",
				"Taunt",
				"Yawn",
				"Odor-Sleuth",
				"Rock-Tomb",
				"U-Turn",
				"Payback",
				"Fling",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gumshoos PokemonInstance Class
	#region Gumshoos
	public class GumshoosInstance : PokemonInstance
	{
		#region Gumshoos Constructors
		/// <summary>
		/// Gumshoos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GumshoosInstance(string nickname, int level)
		: base(
				SpeciesGumshoos.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gumshoos Builder only waiting for a Level
		/// </summary>
		public GumshoosInstance(int level)
		: base(
				SpeciesGumshoos.Instance, // PokemonInstance Species
				"Gumshoos", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gumshoos Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GumshoosInstance() : base(
			SpeciesGumshoos.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}