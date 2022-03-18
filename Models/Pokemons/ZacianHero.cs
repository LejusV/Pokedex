using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zacian-Hero Species to store common natural stats of all Zacian-Heros
	#region SpeciesZacian-Hero
	public class SpeciesZacianHero : PokemonSpecies
	{
#nullable enable
		private static SpeciesZacianHero? _instance = null;
#nullable restore
        public static SpeciesZacianHero Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZacianHero();
                }
                return _instance;
            }
        }

		#region SpeciesZacian-Hero Constructor
		public SpeciesZacianHero() : base(
			888,
			"Zacian-Hero",
			2.8,
			110.0,
			92, // HPs
			130, 115, // Attack & Defense
			80, 115, // Special Attack & Defense
			138		
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
				
			};
		}
		#endregion
	}
	#endregion

	//Zacian-Hero PokemonInstance Class
	#region Zacian-Hero
	public class ZacianHeroInstance : PokemonInstance
	{
		#region Zacian-Hero Constructors
		/// <summary>
		/// Zacian-Hero Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZacianHeroInstance(string nickname, int level)
		: base(
				SpeciesZacianHero.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zacian-Hero Builder only waiting for a Level
		/// </summary>
		public ZacianHeroInstance(int level)
		: base(
				SpeciesZacianHero.Instance, // PokemonInstance Species
				"Zacian-Hero", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zacian-Hero Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZacianHeroInstance() : base(
			SpeciesZacianHero.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}