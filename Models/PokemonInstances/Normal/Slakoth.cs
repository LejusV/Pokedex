using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Slakoth PokemonInstance Class
	#region Slakoth
	public class Slakoth : PokemonInstance
	{
		#region Slakoth Constructors
		/// <summary>
		/// Slakoth Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Slakoth(string nickname, int level)
		: base(
				SlakothSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slakoth Constructor only waiting for a Level
		/// </summary>
		public Slakoth(int level)
		: this( "Slakoth", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slakoth Constructor waiting for no params
		/// </summary>
		/*
		public Slakoth() : this( "Slakoth", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}